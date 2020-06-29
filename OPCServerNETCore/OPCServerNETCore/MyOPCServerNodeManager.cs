﻿/* ========================================================================
 * Copyright (c) 2005-2019 The OPC Foundation, Inc. All rights reserved.
 *
 * OPC Foundation MIT License 1.00
 * 
 * Permission is hereby granted, free of charge, to any person
 * obtaining a copy of this software and associated documentation
 * files (the "Software"), to deal in the Software without
 * restriction, including without limitation the rights to use,
 * copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the
 * Software is furnished to do so, subject to the following
 * conditions:
 * 
 * The above copyright notice and this permission notice shall be
 * included in all copies or substantial portions of the Software.
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
 * EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
 * OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
 * NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
 * HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
 * WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
 * FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
 * OTHER DEALINGS IN THE SOFTWARE.
 *
 * The complete license agreement can be found here:
 * http://opcfoundation.org/License/MIT/1.00/
 * ======================================================================*/

using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.Xml;
using System.IO;
using System.Threading;
using System.Reflection;
using Opc.Ua;
using Opc.Ua.Server;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using Opc.Ua.Configuration;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Crypto.Modes.Gcm;
using Quickstarts.MyOPCServer.Properties;

namespace Quickstarts.MyOPCServer
{
    /// <summary>
    /// A node manager for a server that exposes several variables.
    /// </summary>
    public class MyOPCServerNodeManager : CustomNodeManager2
    {

        #region Constructors
        /// <summary>
        /// Initializes the node manager.
        /// </summary>
        public MyOPCServerNodeManager(IServerInternal server, ApplicationConfiguration configuration)
        :
            base(server, configuration, Namespaces.MyOPCServer)
        {
            SystemContext.NodeIdFactory = this;

            // get the configuration for the node manager.
            m_configuration = configuration.ParseExtension<MyOPCServerConfiguration>();

            // use suitable defaults if no configuration exists.
            if (m_configuration == null)
            {
                m_configuration = new MyOPCServerConfiguration();
            }

            apiRequests = new OpenWeatherMapApiRequests();

            List<string> namespaceUris = new List<string>();
            namespaceUris.Add(Namespaces.MyOPCServer);
            namespaceUris.Add(Namespaces.MyOPCServer + "/Instance");

            NamespaceUris = namespaceUris;

            m_typeNamespaceIndex = Server.NamespaceUris.GetIndexOrAppend(namespaceUris[0]);
            m_namespaceIndex = Server.NamespaceUris.GetIndexOrAppend(namespaceUris[1]);

            Console.WriteLine("**************Welcome to MyOPCServer**************");
        }

        private void OnRaiseSystemEvents(object state)
        {
            Console.WriteLine("Data refresh!\n");
            WriteWeatherData(tempCity, tempMeasureOfTemperature);
        }


        #endregion

        #region IDisposable Members
        /// <summary>
        /// An overrideable version of the Dispose.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                // TBD
            }
        }
        #endregion

        #region INodeIdFactory Members
        /// <summary>
        /// Creates the NodeId for the specified node.
        /// </summary>
        public override NodeId New(ISystemContext context, NodeState node)
        {
            return node.NodeId;
        }
        #endregion

        #region INodeManager Members
        /// <summary>
        /// Does any initialization required before the address space can be used.
        /// </summary>
        /// <remarks>
        /// The externalReferences is an out parameter that allows the node manager to link to nodes
        /// in other node managers. For example, the 'Objects' node is managed by the CoreNodeManager and
        /// should have a reference to the root folder node(s) exposed by this node manager.  
        /// </remarks>
        public override void CreateAddressSpace(IDictionary<NodeId, IList<IReference>> externalReferences)
        {
            lock (Lock)
            {
                base.CreateAddressSpace(externalReferences);


                // ensure trigger can be found via the server object. 

                IList<IReference> references = null;



                if (!externalReferences.TryGetValue(Opc.Ua.ObjectIds.ObjectsFolder, out references))
                {
                    externalReferences[Opc.Ua.ObjectIds.ObjectsFolder] = references = new List<IReference>();
                }

                FolderState dataSourcesFolder = CreateFolder(openWeatherObject, "DataSourceFolder", "DataSourceFolder");
                dataSourcesFolder.AddReference(ReferenceTypes.Organizes, true, Opc.Ua.ObjectIds.ObjectsFolder);

                references.Add(new NodeStateReference(ReferenceTypes.Organizes, false, dataSourcesFolder.NodeId));

                dataSourcesFolder.EventNotifier = EventNotifiers.SubscribeToEvents;
                dataSourcesFolder.Description = "A folder containing data sources";

                AddRootNotifier(dataSourcesFolder);



                try
                {
                    SetupNodes();
                }

                catch (Exception e)
                {
                    Utils.Trace(e, "MyOPCServer: Error creating the address space.");
                }


                AddPredefinedNode(SystemContext, dataSourcesFolder);



            }
        }

        private void SetupNodes()
        {

            Console.WriteLine("***Give me a few seconds to setup MyOPCServer***");
            openWeatherObject = FindPredefinedNode<OpenWeatherMapState>(Objects.OpenWeatherMap);

            openWeatherObject.OpenWeatherMapMethod.OnCall = WeatherRequest;


        }
        private ServiceResult WriteWeatherData(string city, string measureOfTemperature)
        {
            if (city != null)
            {
                double conversionFactor = 0;
                switch (measureOfTemperature)
                {

                    case "K":
                        Console.WriteLine("Unit of measurement for Temperature choosed: " + "Kelvin");
                        break;
                    case "C":
                        Console.WriteLine("Unit of measurement for Temperature choosed: " + "Celsius");
                        openWeatherObject.WeatherData.Temperature.Description = "Temperature in Celsius";
                        openWeatherObject.WeatherData.MaxTemperature.Description = "Max Temperature in Celsius";
                        openWeatherObject.WeatherData.MinTemperature.Description = "Min Temperature in Celsius";

                        openWeatherObject.WeatherData.Temperature.Info.Value.DisplayName = "°C";
                        openWeatherObject.WeatherData.Temperature.Info.Value.Description = "degree Celsius";
                        openWeatherObject.WeatherData.Temperature.Info.Value.NamespaceUri = "https://reference.opcfoundation.org/v104/Core/docs/Part8/5.6.3/";
                        openWeatherObject.WeatherData.Temperature.Info.Value.UnitId = 4408652;
                        openWeatherObject.WeatherData.MaxTemperature.Info.Value.DisplayName = "°C";
                        openWeatherObject.WeatherData.MaxTemperature.Info.Value.Description = "degree Celsius";
                        openWeatherObject.WeatherData.MaxTemperature.Info.Value.NamespaceUri = "https://reference.opcfoundation.org/v104/Core/docs/Part8/5.6.3/";
                        openWeatherObject.WeatherData.MaxTemperature.Info.Value.UnitId = 4408652;
                        openWeatherObject.WeatherData.MinTemperature.Info.Value.DisplayName = "°C";
                        openWeatherObject.WeatherData.MinTemperature.Info.Value.Description = "degree Celsius";
                        openWeatherObject.WeatherData.MinTemperature.Info.Value.NamespaceUri = "https://reference.opcfoundation.org/v104/Core/docs/Part8/5.6.3/";
                        openWeatherObject.WeatherData.MinTemperature.Info.Value.UnitId = 4408652;

                        conversionFactor = 273.15;

                        break;

                    default:
                        Console.WriteLine("WARNING: Unit of measure choosed is not available");
                        Console.WriteLine("Automatic set Unit of Mesure for Temperature: KELVIN ");
                        break;
                }

                Console.WriteLine("mesure " + measureOfTemperature);
                OpenWeatherMapDataClass openWeatherData = apiRequests.GetWeatherDataByCity(city.ToString());

                if (openWeatherData != null)
                {
                    openWeatherObject.WeatherData.Temperature.Temp.Value = (float)(openWeatherData.Main.Temp - conversionFactor);
                    openWeatherObject.WeatherData.City.Value = openWeatherData.Name.ToString();
                    openWeatherObject.WeatherData.Date.Value = DateTime.UtcNow.Date;
                    openWeatherObject.WeatherData.Timestamp = DateTime.UtcNow;
                    openWeatherObject.WeatherData.MaxTemperature.Temp.Value = (float)(openWeatherData.Main.TempMax - conversionFactor);
                    openWeatherObject.WeatherData.MinTemperature.Temp.Value = (float)(openWeatherData.Main.TempMin - conversionFactor);
                    openWeatherObject.WeatherData.Pressure.Pressure.Value = openWeatherData.Main.Pressure;

                    if (openWeatherObject.WeatherData.Date.Value != null && openWeatherObject.WeatherData.City.Value != null && openWeatherObject.WeatherData.Timestamp != null)
                    {
                        openWeatherObject.WeatherData.StatusCode = StatusCodes.Good;
                        return ServiceResult.Good;
                    }
                    else
                    {
                        return StatusCodes.BadUnknownResponse;
                    }

                }
            }

            Console.WriteLine("INPUT ERROR: I can't get informations for this city or city is null: " + city);
            return StatusCodes.BadAggregateInvalidInputs;
        }

        private ServiceResult WeatherRequest(ISystemContext context, MethodState method, NodeId objectId, string city, string measureOfTemperature)
        {
            Console.WriteLine("Client with SessionID: "+ context.SessionId+" called WeatherMethod the input is: "+city);

            tempMeasureOfTemperature = measureOfTemperature;
            tempCity = city;

            // start the simulation.
            m_simulationTimer = new Timer(OnRaiseSystemEvents, null, 20000, 20000);

            return WriteWeatherData(tempCity, tempMeasureOfTemperature);
        }

        private TNodeState FindPredefinedNode<TNodeState>(uint id)
           where TNodeState : NodeState
        {
            return (TNodeState)base.FindPredefinedNode(new NodeId(id, m_typeNamespaceIndex), typeof(TNodeState));
        }
        /// <summary>
        /// Creates a new folder.
        /// </summary>
       
        private FolderState CreateFolder(NodeState parent, string path, string name)
        {
            FolderState folder = new FolderState(parent);

            folder.SymbolicName = name;
            folder.ReferenceTypeId = ReferenceTypes.Organizes;
            folder.TypeDefinitionId = Opc.Ua.ObjectTypeIds.FolderType;
            folder.NodeId = new NodeId(path, NamespaceIndex);
            folder.BrowseName = new QualifiedName(path, NamespaceIndex);
            folder.DisplayName = new LocalizedText("en", name);
            folder.WriteMask = AttributeWriteMask.None;
            folder.UserWriteMask = AttributeWriteMask.None;
            folder.EventNotifier = EventNotifiers.None;

            if (parent != null)
            {
                parent.AddChild(folder);
            }

            return folder;
        }
        
        protected override NodeStateCollection LoadPredefinedNodes(ISystemContext context)
        {

            NodeStateCollection predefinedNodes = new NodeStateCollection();
        
          
            predefinedNodes.LoadFromBinaryResource(context,Resources.BinaryNodePath.ToString(), this.GetType().GetTypeInfo().Assembly, true);
            Console.WriteLine("***MyOPCServer: number of Node loaded from source "+predefinedNodes.Count.ToString()+"***");
          
            return predefinedNodes;
        }

      

        public override void DeleteAddressSpace()
        {
            lock (Lock)
            {
                m_simulationTimer.Dispose();
            }

        }
        #endregion
        protected override NodeState AddBehaviourToPredefinedNode(ISystemContext context, NodeState predefinedNode)
        {
            BaseObjectState passiveNode = predefinedNode as BaseObjectState;

            if (passiveNode == null)
            {

                return predefinedNode;
            }

            NodeId typeId = passiveNode.TypeDefinitionId;

            if (!IsNodeIdInNamespace(typeId) || typeId.IdType != IdType.Numeric)
            {
                return predefinedNode;
            }

            switch ((uint)typeId.Identifier)
            {
                // Write cases in same way for all defined ObjectTypes

                case ObjectTypes.OpenWeatherMapType:
                    {
                        if (passiveNode is OpenWeatherMapState)
                        {
                            break; 
                        }

                        OpenWeatherMapState activeNode = new OpenWeatherMapState(passiveNode.Parent);
                        activeNode.Create(context, passiveNode);

                        if (passiveNode.Parent != null)
                        {
                            passiveNode.Parent.ReplaceChild(context, activeNode);
                        }

                        return activeNode;
                    }
                    case ObjectTypes.WeatherEventType:
                    {
                        if (passiveNode is WeatherEventState)
                        {
                            break;
                        }

                        WeatherEventState activeNode = new WeatherEventState(passiveNode.Parent);
                        activeNode.Create(context, passiveNode);

                        if (passiveNode.Parent != null)
                        {
                            passiveNode.Parent.ReplaceChild(context, activeNode);
                        }

                        return activeNode;
                    }
                

            }

            return predefinedNode;
        }


        #region Private Fields
        private MyOPCServerConfiguration m_configuration;
        private OpenWeatherMapApiRequests apiRequests;
      
        private OpenWeatherMapState openWeatherObject;
        private ushort m_namespaceIndex;
        private ushort m_typeNamespaceIndex;

        private Timer m_simulationTimer;
        private string tempMeasureOfTemperature { get; set; }
        private string tempCity { get; set; }
        #endregion
    }
}
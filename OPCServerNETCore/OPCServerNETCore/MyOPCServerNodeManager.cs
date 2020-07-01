/* ========================================================================
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
using RestSharp.Extensions;
using System.Linq;

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
           // Console.WriteLine("Data refresh!\n");
            UpdateValues();
            Console.WriteLine(DateTime.UtcNow);

        }

        #endregion


        #region INodeIdFactory Members
        /// <summary>
        /// Creates the NodeId for the specified node.
        /// </summary>
        /// <summary>

        public override NodeId New(ISystemContext context, NodeState node)
        {
            BaseInstanceState instance = node as BaseInstanceState;

            if (instance != null && instance.Parent != null)
            {
                string id = instance.Parent.NodeId.Identifier as string;

                if (id != null)
                {
                    return new NodeId(id + "_" + instance.SymbolicName, instance.Parent.NodeId.NamespaceIndex);
                }
            }

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

                FolderState root = CreateFolder(null, "CitiesNodes", "CitiesNodes");
                root.AddReference(ReferenceTypes.Organizes, true, Opc.Ua.ObjectIds.ObjectsFolder);

                references.Add(new NodeStateReference(ReferenceTypes.Organizes, false, root.NodeId));

                root.EventNotifier = EventNotifiers.SubscribeToEvents;
                root.Description = "A folder containing data sources";

                AddRootNotifier(root);
                



                try
                {
                    SetupNodes();
                    FolderState citiesNodes = CreateFolder(root, "Cities", "Cities");
                    citiesNodes.Description = "This folder contains nodes of the city stations";

                    WeatherMapVariableState catania = CreateVariable(citiesNodes, "Catania", "Catania", new NodeId(DataTypeIds.WeatherData.Identifier, DataTypeIds.WeatherData.NamespaceIndex), ValueRanks.Scalar);
                    AnalogVariableState childCatania= CreateChild(catania);
                   
                    WeatherMapVariableState palermo = CreateVariable(citiesNodes, "Palermo", "Palermo", new NodeId(DataTypeIds.WeatherData.Identifier, DataTypeIds.WeatherData.NamespaceIndex), ValueRanks.Scalar);
                    AnalogVariableState childPalermo=CreateChild(palermo);
                    WeatherMapVariableState messina = CreateVariable(citiesNodes, "Messina", "Messina", new NodeId(DataTypeIds.WeatherData.Identifier, DataTypeIds.WeatherData.NamespaceIndex), ValueRanks.Scalar);
                    AnalogVariableState childMessina = CreateChild(messina);

                    
                    variables.Add(catania,childCatania);
                    variables.Add(palermo, childPalermo);
                    variables.Add(messina, childMessina);
                }

                catch (Exception e)
                {
                    Utils.Trace(e, "MyOPCServer: Error creating the address space.");
                }


                AddPredefinedNode(SystemContext, root);
                //variable.SetChildValue(SystemContext,BrowseNames.Temperature, variable.Value.Temperature, false);




            }
        }

        private AnalogVariableState CreateChild(WeatherMapVariableState variable)
        {
            AnalogData info = new AnalogData();

            info = variable.Value.Temperature;
          
            AnalogVariableState child = CreateVariableChild(null, "Temperatura", "Temperatura", new NodeId(DataTypeIds.AnalogData.Identifier, DataTypeIds.AnalogData.NamespaceIndex), ValueRanks.Scalar,info);
            
            variable.AddChild(child);

            return child;

           
        }

        private void SetupNodes()
        {

            Console.WriteLine("***Give me a few seconds to setup MyOPCServer***");
            openWeatherObject = FindPredefinedNode<OpenWeatherMapState>(Objects.OpenWeatherMap);


            openWeatherObject.OpenWeatherMapMethod.OnCall = WeatherRequest;


        }

        private ServiceResult WriteWeatherData(string city, string measureOfTemperature)
        {
            WeatherData insideData = new WeatherData();
            AnalogData insideTempData = new AnalogData();
            AnalogData insideMaxTempData = new AnalogData();
            AnalogData insideMinTempData = new AnalogData();
            AnalogData insidePressureData = new AnalogData();
            EUInformation info_press = new EUInformation();
            EUInformation info_temp = new EUInformation();

            lock (Lock)
            {
                if (city != null)
                {
                    double conversionFactor = 0;
                    info_press.DisplayName = new String("Pa");
                    info_press.Description = new String("Pascal");
                    info_press.NamespaceUri = new string("http://www.opcfoundation.org/UA/units/un/cefact");
                    info_press.UnitId = 4932940;



                    switch (measureOfTemperature)
                    {

                        case "K":
                            Console.WriteLine("Unit of measurement for Temperature choosed: " + "Kelvin");
                            info_temp.DisplayName = new String("K");
                            info_temp.Description = new String("Kelvin");
                            info_temp.NamespaceUri = new string("http://www.opcfoundation.org/UA/units/un/cefact");
                            info_temp.UnitId = 5259596;
                            break;
                        case "C":
                            Console.WriteLine("Unit of measurement for Temperature choosed: " + "Celsius");

                            info_temp.DisplayName = new String("°C");
                            info_temp.Description = new String("degree Celsius");
                            info_temp.NamespaceUri = new string("http://www.opcfoundation.org/UA/units/un/cefact");
                            info_temp.UnitId = 4408652;



                            conversionFactor = 273.15;


                            break;

                        default:
                            Console.WriteLine("Unit of measurement for Temperature choosed: " + "Kelvin");
                            info_temp.DisplayName = new String("K");
                            info_temp.Description = new String("Kelvin");
                            info_temp.NamespaceUri = new string("http://www.opcfoundation.org/UA/units/un/cefact");
                            info_temp.UnitId = 5259596;
                            break;
                    }

                    Console.WriteLine("mesure " + measureOfTemperature);
                    OpenWeatherMapDataClass openWeatherData = apiRequests.GetWeatherDataByCity(city.ToString());

                    if (openWeatherData != null)
                    {
                        insideMaxTempData.Data = (float)(openWeatherData.Main.TempMax - conversionFactor);
                        insideMaxTempData.Info = info_temp;
                        insideData.MaxTemperature = insideMaxTempData;




                        insideMinTempData.Data = (float)(openWeatherData.Main.TempMin - conversionFactor);
                        insideMinTempData.Info = info_temp;
                        insideData.MinTemperature = insideMinTempData;


                        insideTempData.Data = (float)(openWeatherData.Main.Temp - conversionFactor);
                        insideTempData.Info = info_temp;
                        insideData.Temperature = insideTempData;

                        insidePressureData.Data = openWeatherData.Main.Pressure;
                        insidePressureData.Info = info_press;
                        insideData.Pressure = insidePressureData;

                        insideData.CityName = new string(city);





                        if (insideData != null)
                        {
                            openWeatherObject.CityName.Value = new String(insideData.CityName);
                            openWeatherObject.WeatherData.Value = insideData;
                            openWeatherObject.WeatherData.StatusCode = StatusCodes.Good;
                            openWeatherObject.WeatherData.Timestamp = DateTime.UtcNow;
                            return ServiceResult.Good;
                        }
                        else
                        {
                            return StatusCodes.BadUnknownResponse;
                        }
                    }
                }
            }

            Console.WriteLine("INPUT ERROR: I can't get informations for this city or city is null: " + city);
            return StatusCodes.BadAggregateInvalidInputs;
        }


        private ServiceResult WeatherRequest(ISystemContext context, MethodState method, NodeId objectId, string city, string measureOfTemperature)
        {

            Console.WriteLine("Client with SessionID: " + context.SessionId + " called WeatherMethod the input is: " + city);

            tempMeasureOfTemperature = measureOfTemperature;
            tempCity = city;

            // start the simulation.
            

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
        /// Creates a new variable.
        /// </summary>


        /// <summary>
        /// Creates a new variable.
        /// </summary>
        /// 
        private AnalogVariableState CreateVariableChild(NodeState parent, string path, string name, NodeId dataType, int valueRank,AnalogData valueAnalog)
        {
            AnalogVariableState variable = new AnalogVariableState(parent);

            

            variable.SymbolicName = name;
            variable.ReferenceTypeId = ReferenceTypes.Organizes;
            variable.TypeDefinitionId = new NodeId(VariableTypeIds.WeatherMapVariableType.Identifier, VariableTypeIds.WeatherMapVariableType.NamespaceIndex);
            variable.NodeId = new NodeId(path, NamespaceIndex);
            variable.BrowseName = new QualifiedName(path, NamespaceIndex);
            variable.DisplayName = new LocalizedText("en", name);
            variable.WriteMask = AttributeWriteMask.DisplayName | AttributeWriteMask.Description;
            variable.UserWriteMask = AttributeWriteMask.DisplayName | AttributeWriteMask.Description;
            variable.Description = new String("Information about weather for" + variable.SymbolicName.ToString());
           
            variable.DataType = dataType;
            variable.ValueRank = valueRank;
            variable.AccessLevel = AccessLevels.CurrentReadOrWrite;
            variable.UserAccessLevel = AccessLevels.CurrentRead;
            variable.Historizing = true;

           variable.Value = valueAnalog;
            
           
            if (variable.Value != null)
            {
                variable.StatusCode = StatusCodes.Good;

            }
            else
            {
                variable.StatusCode = StatusCodes.Bad;
            }
            variable.Timestamp = DateTime.UtcNow;

            if (valueRank == ValueRanks.OneDimension)
            {
                variable.ArrayDimensions = new ReadOnlyList<uint>(new List<uint> { 0 });
            }
            else if (valueRank == ValueRanks.TwoDimensions)
            {
                variable.ArrayDimensions = new ReadOnlyList<uint>(new List<uint> { 0, 0 });
            }

            if (parent != null)
            {

                parent.AddChild(variable);
            }
           

            return variable;
        }


        private WeatherMapVariableState CreateVariable(NodeState parent, string path, string name, NodeId dataType, int valueRank)
        {
            WeatherMapVariableState variable = new WeatherMapVariableState(parent);

            //variable.CityName.Value = "i";

            variable.SymbolicName = name;
            variable.ReferenceTypeId = ReferenceTypes.Organizes;
            variable.TypeDefinitionId = new NodeId(VariableTypeIds.WeatherMapVariableType.Identifier, VariableTypeIds.WeatherMapVariableType.NamespaceIndex);
            variable.NodeId = new NodeId(path, NamespaceIndex);
            variable.BrowseName = new QualifiedName(path, NamespaceIndex);
            variable.DisplayName = new LocalizedText("en", name);
            variable.WriteMask = AttributeWriteMask.DisplayName | AttributeWriteMask.Description;
            variable.UserWriteMask = AttributeWriteMask.DisplayName | AttributeWriteMask.Description;
            variable.Description = new String("Information about weather for" + variable.SymbolicName.ToString());
            //variable.ClearChangeMasks(SystemContext, true);
            variable.DataType = dataType;
            variable.ValueRank = valueRank;
            variable.AccessLevel = AccessLevels.CurrentReadOrWrite;
            variable.UserAccessLevel = AccessLevels.CurrentRead;
            variable.Historizing = true;
      
            
          variable.Value = GetNewValue(variable.SymbolicName.ToString()); 
            if (variable.Value != null)
            {
                variable.StatusCode = StatusCodes.Good;
               


            }
            else
            {
                variable.StatusCode = StatusCodes.Bad;
            }
            variable.Timestamp = DateTime.UtcNow;

            if (valueRank == ValueRanks.OneDimension)
            {
                variable.ArrayDimensions = new ReadOnlyList<uint>(new List<uint> { 0 });
            }
            else if (valueRank == ValueRanks.TwoDimensions)
            {
                variable.ArrayDimensions = new ReadOnlyList<uint>(new List<uint> { 0, 0 });
            }

            if (parent != null)
            {

                parent.AddChild(variable);
            }



            return variable;
        }
        private void UpdateValues() {


            //Console.Write("I'm trying to update nodes ");
            for (int index = 0; index < variables.Count; index++)
            {
                var item = variables.ElementAt(index);
                var itemKey = item.Key;
                var itemValue = item.Value;



                WeatherData weatherInfo = new WeatherData();
                weatherInfo = GetNewValue(itemKey.SymbolicName.ToString());



                if (weatherInfo != null)
                {
                    itemKey.Timestamp = DateTime.UtcNow;
                    itemKey.Value = weatherInfo;
                    itemKey.StatusCode = StatusCodes.Good;

                    

                    itemValue.Timestamp = itemKey.Timestamp;
                    itemValue.Value = weatherInfo.Temperature;
                    itemValue.StatusCode = itemKey.StatusCode;

                    itemKey.ClearChangeMasks(SystemContext, true);
                    Console.WriteLine("Update follow Nodes" + itemKey.SymbolicName+" "+itemValue.SymbolicName);
                }
                else
                {
                    Console.WriteLine("I can't update nodes");
                }


            }
        }
        private WeatherData GetNewValue(String name)

        {

            
            WeatherData weatherInfo = new WeatherData();
            OpenWeatherMapDataClass openWeatherData = apiRequests.GetWeatherDataByCity(name);
            if (openWeatherData != null)
            {

                EUInformation info_temp = new EUInformation();
                EUInformation info_press = new EUInformation();


                info_press.DisplayName = new String("Pa");
                info_press.Description = new String("Pascal");
                info_press.NamespaceUri = new string("http://www.opcfoundation.org/UA/units/un/cefact");
                info_press.UnitId = 4932940;


                info_temp.DisplayName = new String("K");
                info_temp.Description = new String("Kelvin");
                info_temp.NamespaceUri = new string("http://www.opcfoundation.org/UA/units/un/cefact");
                info_temp.UnitId = 5259596;

                weatherInfo.CityName = new string(name);
                AnalogData temperature = new AnalogData();
                AnalogData maxTemperature = new AnalogData();
                AnalogData minTemperature = new AnalogData();
                AnalogData pressure = new AnalogData();

                maxTemperature.Data = openWeatherData.Main.TempMax;
                maxTemperature.Info = info_temp;
                weatherInfo.MaxTemperature = maxTemperature;
                minTemperature.Data = openWeatherData.Main.TempMin;
                minTemperature.Info = info_temp;
                weatherInfo.MinTemperature = minTemperature;
                temperature.Data = openWeatherData.Main.Temp;
                temperature.Info = info_temp;
                weatherInfo.Temperature = temperature;
                pressure.Data = openWeatherData.Main.Pressure;
                pressure.Info = info_press;
                weatherInfo.Pressure = pressure;

            }
            //timer set on 
            m_simulationTimer = new Timer(OnRaiseSystemEvents, null, 20000, 20000);
      
            return weatherInfo;

        }

        protected override NodeStateCollection LoadPredefinedNodes(ISystemContext context)
        {

            NodeStateCollection predefinedNodes = new NodeStateCollection();
            predefinedNodes.LoadFromBinaryResource(context, Resources.BinaryNodePath.ToString(), this.GetType().GetTypeInfo().Assembly, true);
            Console.WriteLine("***MyOPCServer: number of Node loaded from source " + predefinedNodes.Count.ToString() + "***");
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



            }

            return predefinedNode;
        }

        


        #region Private Fields
        private MyOPCServerConfiguration m_configuration;
        private OpenWeatherMapApiRequests apiRequests;

        private Dictionary<WeatherMapVariableState, AnalogVariableState> variables = new Dictionary<WeatherMapVariableState, AnalogVariableState>();
        private ushort m_namespaceIndex;
        private ushort m_typeNamespaceIndex;

        private OpenWeatherMapState openWeatherObject;
        private Timer m_simulationTimer;

        private string tempMeasureOfTemperature { get; set; }
        private string tempCity { get; set; }

        #endregion
    }
}
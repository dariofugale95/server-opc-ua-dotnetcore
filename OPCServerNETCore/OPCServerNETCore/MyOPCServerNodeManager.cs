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
                List<BaseDataVariableState> variables = new List<BaseDataVariableState>();



                try
                {
                    SetupNodes();
                     FolderState citiesNodes = CreateFolder(root, "Cities", "Cities");
                     WeatherMapDataState catania = CreateVariable(citiesNodes, "Catania", "Catania",new NodeId(DataTypeIds.WeatherData.Identifier, DataTypeIds.WeatherData.NamespaceIndex), ValueRanks.Scalar);
                     WeatherMapDataState palermo = CreateVariable(citiesNodes, "Palermo", "Palermo", new NodeId(DataTypeIds.WeatherData.Identifier, DataTypeIds.WeatherData.NamespaceIndex), ValueRanks.Scalar);
                    WeatherMapDataState messina = CreateVariable(citiesNodes, "Messina", "Messina", new NodeId(DataTypeIds.WeatherData.Identifier, DataTypeIds.WeatherData.NamespaceIndex), ValueRanks.Scalar);
                    //  variables.Add(catania);


                }

                catch (Exception e)
                {
                    Utils.Trace(e, "MyOPCServer: Error creating the address space.");
                }


                AddPredefinedNode(SystemContext, root);



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
            WeatherData insideData = new WeatherData();
            AnalogData insideTempData = new AnalogData();
            AnalogData insideMaxTempData = new AnalogData();
            AnalogData insideMinTempData = new AnalogData();
            AnalogData insidePressureData = new AnalogData();
            EUInformation info_press = new EUInformation();
            EUInformation info_temp = new EUInformation();

            lock (Lock) { 
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
        /// Creates a new variable.
        /// </summary>
       

        /// <summary>
        /// Creates a new variable.
        /// </summary>
        /// 
        private WeatherMapDataState CreateVariable(NodeState parent, string path, string name, NodeId dataType, int valueRank)
        {
            WeatherMapDataState variable = new WeatherMapDataState(parent);

            //variable.CityName.Value = "i";
       
            variable.SymbolicName = name;
            variable.ReferenceTypeId = ReferenceTypes.Organizes;
            variable.TypeDefinitionId = new NodeId(VariableTypeIds.WeatherMapDataType.Identifier,VariableTypeIds.WeatherMapDataType.NamespaceIndex);
            variable.NodeId = new NodeId(path, NamespaceIndex);
            variable.BrowseName = new QualifiedName(path, NamespaceIndex);
            variable.DisplayName = new LocalizedText("en", name);
            variable.WriteMask = AttributeWriteMask.DisplayName | AttributeWriteMask.Description;
            variable.UserWriteMask = AttributeWriteMask.DisplayName | AttributeWriteMask.Description;
            Console.WriteLine(dataType);
            variable.DataType = dataType;
            variable.ValueRank = valueRank;
            variable.AccessLevel = AccessLevels.CurrentReadOrWrite;
            variable.UserAccessLevel = AccessLevels.CurrentReadOrWrite;
            variable.Historizing = false;
            
            //variable.Temperature.Temp.Value = (float)10.0;
            variable.Value = GetNewValue(variable);
            if (variable.Value != null)
            {
                variable.StatusCode = StatusCodes.Good;
                //print of console 
                Console.WriteLine("******************************");
                Console.WriteLine(variable.Value.CityName.ToString());
                Console.WriteLine("Temperature Now "+ variable.Value.Temperature.Data.ToString());
                
                Console.WriteLine("Information about units of mesurement: ");
                Console.Write(variable.Value.Temperature.Info.DisplayName.ToString()+ "|"+ variable.Value.Temperature.Info.Description.ToString()+"|"+ variable.Value.Temperature.Info.NamespaceUri.ToString()+"|"+ variable.Value.Temperature.Info.UnitId.ToString());


                Console.WriteLine("");
                Console.WriteLine("Max Temperature of Day: "+ variable.Value.MaxTemperature.Data.ToString());

                Console.WriteLine("Information about units of mesurement: ");
                Console.Write(variable.Value.MaxTemperature.Info.DisplayName.ToString() + "|" + variable.Value.MaxTemperature.Info.Description.ToString() + "|" + variable.Value.MaxTemperature.Info.NamespaceUri.ToString() + "|" + variable.Value.MaxTemperature.Info.UnitId.ToString());
                Console.WriteLine("");

                Console.WriteLine("Min Temperatura of Day: "+variable.Value.MinTemperature.Data.ToString()) ;
                Console.WriteLine("Information about units of mesurement: ");
                Console.Write(variable.Value.MinTemperature.Info.DisplayName.ToString() + "|" + variable.Value.MinTemperature.Info.Description.ToString() + "|" + variable.Value.MinTemperature.Info.NamespaceUri.ToString() + "|" + variable.Value.MinTemperature.Info.UnitId.ToString());

                Console.WriteLine("");
                Console.WriteLine("Pressure of day: " + variable.Value.Pressure.Data.ToString());
                Console.WriteLine("Information about units of mesurement: ");
                Console.Write(variable.Value.Pressure.Info.DisplayName.ToString() + "|" + variable.Value.Pressure.Info.Description.ToString() + "|" + variable.Value.Pressure.Info.NamespaceUri.ToString() + "|" + variable.Value.Pressure.Info.UnitId.ToString());

                

            }
            else {
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

        private WeatherData GetNewValue(WeatherMapDataState variable)

        {
            WeatherData weatherInfo = new WeatherData();
                OpenWeatherMapDataClass openWeatherData = apiRequests.GetWeatherDataByCity(variable.SymbolicName.ToString());
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

                weatherInfo.CityName = new string(variable.SymbolicName.ToString());
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

            return weatherInfo;
            
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
                //m_simulationTimer.Dispose();
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
        private WeatherData weather_prova;
        
        private ushort m_namespaceIndex;
        private ushort m_typeNamespaceIndex;
        
        private OpenWeatherMapState openWeatherObject;
        private Timer m_simulationTimer;

        private string tempMeasureOfTemperature { get; set; }
        private string tempCity { get; set; }
        List<BaseDataVariableState> variables = new List<BaseDataVariableState>();
        #endregion
    }
}
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
            Console.WriteLine(m_typeNamespaceIndex);
            m_namespaceIndex = Server.NamespaceUris.GetIndexOrAppend(namespaceUris[1]);
            Console.WriteLine(m_namespaceIndex);
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

                //IList<IReference> references = null;
                /*
                if (!externalReferences.TryGetValue(ObjectIds.ObjectsFolder, out references))
                {
                    externalReferences[ObjectIds.ObjectsFolder] = references = new List<IReference>();
                }
                */
                /*
                FolderState dataSourcesFolder = CreateFolder(null, "DataSourceFolder", "DataSourceFolder");
                dataSourcesFolder.AddReference(ReferenceTypes.Organizes, true, ObjectIds.ObjectsFolder);
                references.Add(new NodeStateReference(ReferenceTypes.Organizes, false, dataSourcesFolder.NodeId));
                dataSourcesFolder.EventNotifier = EventNotifiers.SubscribeToEvents;
                dataSourcesFolder.Description = "A folder containing data sources";

                AddRootNotifier(dataSourcesFolder);
                */

                try
                {

                    SetupNodes();
                    //BaseDataVariableState openWeatherMapData = CreateVariable(dataSourcesFolder, "/OpenWeatherMapData", "OpenWeatherMapData", DataTypeIds.Float, ValueRanks.Scalar);


                }

                catch (Exception e)
                {
                    Utils.Trace(e, "Error creating the address space.");
                }

               // AddPredefinedNode(SystemContext, dataSourcesFolder);
            }
        }

        private void SetupNodes()
        {
  
          
            Console.WriteLine("SetupNodes");
       
           weather_prova = FindPredefinedNode<OpenWeatherMapState>(Objects.OpenWeatherMap);
      
          
            //Utils.Trace("Received '" + value.ToString() + "'.");
    
            weather_prova.WeatherData.Temperature.Value = (float)23.3 ;
            weather_prova.WeatherData.City.Value = "Catania";
            weather_prova.WeatherData.Date.Value = DateTime.UtcNow.Date;
          
        }

        private TNodeState FindPredefinedNode<TNodeState>(uint id)
           where TNodeState : NodeState
        {
            return (TNodeState)base.FindPredefinedNode(new NodeId(id, m_typeNamespaceIndex), typeof(TNodeState));
        }
        /// <summary>
        /// Creates a new folder.
        /// </summary>
        /*
        private FolderState CreateFolder(NodeState parent, string path, string name)
        {
            FolderState folder = new FolderState(parent);

            folder.SymbolicName = name;
            folder.ReferenceTypeId = ReferenceTypes.Organizes;
            folder.TypeDefinitionId = ObjectTypeIds.FolderType;
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
        */
        protected override NodeStateCollection LoadPredefinedNodes(ISystemContext context)
        {
          
            // Set your .uanodes file to Build Action = Embedded Resource
            // resourcePath parameter of LoadFromBinaryResource() is project name + directory + file name

            NodeStateCollection predefinedNodes = new NodeStateCollection();
            
            //predefinedNodes.LoadFromBinaryResource(context, "Published2/" + "Quickstarts.MyOPCServer.PredefinedNodes.uanodes", this.GetType().GetTypeInfo().Assembly, true);
            predefinedNodes.LoadFromBinaryResource(context, "/Users/giuli/Documents/GitHub/server-opc-ua-dotnetcore/OPCServerNETCore/OPCServerNETCore/Published2/Quickstarts.MyOPCServer.PredefinedNodes.uanodes", this.GetType().GetTypeInfo().Assembly, true);
            Console.WriteLine(predefinedNodes.Count.ToString());
            
            return predefinedNodes;
        }
        
        /// <summary>
        /// Creates a new variable.
        /// </summary>
        /// ObjectsType



        /*
    private BaseDataVariableState CreateVariable(NodeState parent, string path, string name, NodeId dataType, int valueRank)
    {
        BaseDataVariableState variable = new BaseDataVariableState(parent);

        variable.SymbolicName = name;
        variable.ReferenceTypeId = ReferenceTypes.Organizes;
        variable.TypeDefinitionId = VariableTypeIds.BaseDataVariableType;
        variable.NodeId = new NodeId(path, NamespaceIndex);
        variable.BrowseName = new QualifiedName(path, NamespaceIndex);
        variable.DisplayName = new LocalizedText("en", name);
        variable.WriteMask = AttributeWriteMask.DisplayName | AttributeWriteMask.Description;
        variable.UserWriteMask = AttributeWriteMask.DisplayName | AttributeWriteMask.Description;
        variable.DataType = dataType;
        variable.ValueRank = valueRank;
        variable.AccessLevel = AccessLevels.CurrentReadOrWrite;
        variable.UserAccessLevel = AccessLevels.CurrentReadOrWrite;
        variable.Historizing = false;
        variable.Value = apiRequests.GetWeatherDataByCity("Catania");
        variable.StatusCode = StatusCodes.Good;
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
    */
        /// <summary>
        /// Creates a new data type.
        /// </summary>
        /*
        private DataTypeState CreateDataType(NodeState parent, IDictionary<NodeId, IList<IReference>> externalReferences, string path, string name)
        {
            DataTypeState type = new DataTypeState();

            type.SymbolicName = name;
            type.SuperTypeId = DataTypeIds.Structure;
            type.NodeId = new NodeId(path, NamespaceIndex);
            type.BrowseName = new QualifiedName(name, NamespaceIndex);
            type.DisplayName = type.BrowseName.Name;
            type.WriteMask = AttributeWriteMask.None;
            type.UserWriteMask = AttributeWriteMask.None;
            type.IsAbstract = false;

            IList<IReference> references = null;

            if (!externalReferences.TryGetValue(DataTypeIds.Structure, out references))
            {
                externalReferences[DataTypeIds.Structure] = references = new List<IReference>();
            }

            references.Add(new NodeStateReference(ReferenceTypeIds.HasSubtype, false, type.NodeId));

            if (parent != null)
            {
                parent.AddReference(ReferenceTypes.Organizes, false, type.NodeId);
                type.AddReference(ReferenceTypes.Organizes, true, parent.NodeId);
            }

            AddPredefinedNode(SystemContext, type);
            return type;
        }


        /// <summary>
        /// Frees any resources allocated for the address space.
        /// </summary>
        public override void DeleteAddressSpace()
        {
            lock (Lock)
            {
                base.DeleteAddressSpace();
            }
        }*/
        #endregion



        private ServiceResult OnWriteMyNode(ISystemContext context, NodeState node, ref object value)
        {
       
        Console.WriteLine("Received '" + value.ToString() + "'.");

            Utils.Trace("Received '" + value.ToString() + "'.");


            return ServiceResult.Good;
        }
        private OpenWeatherMapState weather_prova;
        
       
        #region Private Fields
        private MyOPCServerConfiguration m_configuration;
        private OpenWeatherMapApiRequests apiRequests;
        private ushort m_namespaceIndex;
        private ushort m_typeNamespaceIndex;
        #endregion
    }
}
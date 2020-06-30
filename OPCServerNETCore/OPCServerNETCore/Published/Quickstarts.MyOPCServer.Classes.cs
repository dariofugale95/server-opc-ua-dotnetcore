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
using System.Xml;
using System.Runtime.Serialization;
using Opc.Ua;

namespace Quickstarts.MyOPCServer
{
    #region OpenWeatherMapState Class
    #if (!OPCUA_EXCLUDE_OpenWeatherMapState)
    /// <summary>
    /// Stores an instance of the OpenWeatherMapType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class OpenWeatherMapState : BaseObjectState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public OpenWeatherMapState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Quickstarts.MyOPCServer.ObjectTypes.OpenWeatherMapType, Quickstarts.MyOPCServer.Namespaces.MyOPCServer, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAADkAAABodHRwczovL2dpdGh1Yi5jb20vZGFyaW9mdWdhbGU5NS9zZXJ2ZXItb3BjLXVhLWRvdG5l" +
           "dGNvcmX/////hGCAAgEAAAABABoAAABPcGVuV2VhdGhlck1hcFR5cGVJbnN0YW5jZQEBmToBAZk6mToA" +
           "AAH/////AwAAABVgiQoCAAAAAQAIAAAAQ2l0eU5hbWUBAe46AC4ARO46AAAADP////8BAf////8AAAAA" +
           "FWCJCgIAAAABAAsAAABXZWF0aGVyRGF0YQEBqjoALwEBuDqqOgAAAQHNOv////8BAf////8AAAAABGGC" +
           "CgQAAAABABQAAABPcGVuV2VhdGhlck1hcE1ldGhvZAEBmzoALwEBmzqbOgAAAQEBAAAAAQD5CwABAZ86" +
           "AQAAABdgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAZw6AC4ARJw6AACWAgAAAAEAKgEBOAAAAAQA" +
           "AABDaXR5AAz/////AAAAAAMAAAAAHQAAAENpdHkgdG8gZ2V0IFdlYXRoZXIgUHJldmlzaW9uAQAqAQFJ" +
           "AAAAFAAAAE1lYXN1cmVPZlRlbXBlcmF0dXJlAAz/////AAAAAAMAAAAAHgAAAEM9Q2Vsc2l1cyxLPUtl" +
           "bHZpbi4gRGVmYXVsdDogSwEAKAEBAAAAAQAAAAAAAAABAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public PropertyState<string> CityName
        {
            get
            {
                return m_cityName;
            }

            set
            {
                if (!Object.ReferenceEquals(m_cityName, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_cityName = value;
            }
        }

        /// <remarks />
        public WeatherMapDataState WeatherData
        {
            get
            {
                return m_weatherData;
            }

            set
            {
                if (!Object.ReferenceEquals(m_weatherData, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_weatherData = value;
            }
        }

        /// <remarks />
        public WeatherMethodState OpenWeatherMapMethod
        {
            get
            {
                return m_openWeatherMapMethodMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_openWeatherMapMethodMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_openWeatherMapMethodMethod = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Populates a list with the children that belong to the node.
        /// </summary>
        /// <param name="context">The context for the system being accessed.</param>
        /// <param name="children">The list of children to populate.</param>
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_cityName != null)
            {
                children.Add(m_cityName);
            }

            if (m_weatherData != null)
            {
                children.Add(m_weatherData);
            }

            if (m_openWeatherMapMethodMethod != null)
            {
                children.Add(m_openWeatherMapMethodMethod);
            }

            base.GetChildren(context, children);
        }

        /// <summary>
        /// Finds the child with the specified browse name.
        /// </summary>
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case Quickstarts.MyOPCServer.BrowseNames.CityName:
                {
                    if (createOrReplace)
                    {
                        if (CityName == null)
                        {
                            if (replacement == null)
                            {
                                CityName = new PropertyState<string>(this);
                            }
                            else
                            {
                                CityName = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = CityName;
                    break;
                }

                case Quickstarts.MyOPCServer.BrowseNames.WeatherData:
                {
                    if (createOrReplace)
                    {
                        if (WeatherData == null)
                        {
                            if (replacement == null)
                            {
                                WeatherData = new WeatherMapDataState(this);
                            }
                            else
                            {
                                WeatherData = (WeatherMapDataState)replacement;
                            }
                        }
                    }

                    instance = WeatherData;
                    break;
                }

                case Quickstarts.MyOPCServer.BrowseNames.OpenWeatherMapMethod:
                {
                    if (createOrReplace)
                    {
                        if (OpenWeatherMapMethod == null)
                        {
                            if (replacement == null)
                            {
                                OpenWeatherMapMethod = new WeatherMethodState(this);
                            }
                            else
                            {
                                OpenWeatherMapMethod = (WeatherMethodState)replacement;
                            }
                        }
                    }

                    instance = OpenWeatherMapMethod;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private PropertyState<string> m_cityName;
        private WeatherMapDataState m_weatherData;
        private WeatherMethodState m_openWeatherMapMethodMethod;
        #endregion
    }
    #endif
    #endregion

    #region WeatherMethodState Class
    #if (!OPCUA_EXCLUDE_WeatherMethodState)
    /// <summary>
    /// Stores an instance of the WeatherMethodType Method.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class WeatherMethodState : MethodState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public WeatherMethodState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Constructs an instance of a node.
        /// </summary>
        /// <param name="parent">The parent.</param>
        /// <returns>The new node.</returns>
        public new static NodeState Construct(NodeState parent)
        {
            return new WeatherMethodState(parent);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAADkAAABodHRwczovL2dpdGh1Yi5jb20vZGFyaW9mdWdhbGU5NS9zZXJ2ZXItb3BjLXVhLWRvdG5l" +
           "dGNvcmX/////BGGCCgQAAAABABEAAABXZWF0aGVyTWV0aG9kVHlwZQEBnToALwEBnTqdOgAAAQEBAAAA" +
           "AQD5CwABAZ86AQAAABdgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAZ46AC4ARJ46AACWAgAAAAEA" +
           "KgEBOAAAAAQAAABDaXR5AAz/////AAAAAAMAAAAAHQAAAENpdHkgdG8gZ2V0IFdlYXRoZXIgUHJldmlz" +
           "aW9uAQAqAQFJAAAAFAAAAE1lYXN1cmVPZlRlbXBlcmF0dXJlAAz/////AAAAAAMAAAAAHgAAAEM9Q2Vs" +
           "c2l1cyxLPUtlbHZpbi4gRGVmYXVsdDogSwEAKAEBAAAAAQAAAAAAAAABAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Event Callbacks
        /// <summary>
        /// Raised when the the method is called.
        /// </summary>
        public WeatherMethodStateMethodCallHandler OnCall;
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Invokes the method, returns the result and output argument.
        /// </summary>
        protected override ServiceResult Call(
            ISystemContext _context,
            NodeId _objectId,
            IList<object> _inputArguments,
            IList<object> _outputArguments)
        {
            if (OnCall == null)
            {
                return base.Call(_context, _objectId, _inputArguments, _outputArguments);
            }

            ServiceResult result = null;

            string city = (string)_inputArguments[0];
            string measureOfTemperature = (string)_inputArguments[1];

            if (OnCall != null)
            {
                result = OnCall(
                    _context,
                    this,
                    _objectId,
                    city,
                    measureOfTemperature);
            }

            return result;
        }
        #endregion

        #region Private Fields
        #endregion
    }

    /// <summary>
    /// Used to receive notifications when the method is called.
    /// </summary>
    /// <exclude />
    public delegate ServiceResult WeatherMethodStateMethodCallHandler(
        ISystemContext context,
        MethodState method,
        NodeId objectId,
        string city,
        string measureOfTemperature);
    #endif
    #endregion

    #region WeatherEventState Class
    #if (!OPCUA_EXCLUDE_WeatherEventState)
    /// <summary>
    /// Stores an instance of the WeatherEventType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class WeatherEventState : BaseEventState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public WeatherEventState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Quickstarts.MyOPCServer.ObjectTypes.WeatherEventType, Quickstarts.MyOPCServer.Namespaces.MyOPCServer, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAADkAAABodHRwczovL2dpdGh1Yi5jb20vZGFyaW9mdWdhbGU5NS9zZXJ2ZXItb3BjLXVhLWRvdG5l" +
           "dGNvcmX/////BGCAAgEAAAABABgAAABXZWF0aGVyRXZlbnRUeXBlSW5zdGFuY2UBAZ86AQGfOp86AAD/" +
           "////CgAAABVgiQoCAAAAAAAHAAAARXZlbnRJZAEBoDoALgBEoDoAAAAP/////wEB/////wAAAAAVYIkK" +
           "AgAAAAAACQAAAEV2ZW50VHlwZQEBoToALgBEoToAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAACgAA" +
           "AFNvdXJjZU5vZGUBAaI6AC4ARKI6AAAAEf////8BAf////8AAAAAFWCJCgIAAAAAAAoAAABTb3VyY2VO" +
           "YW1lAQGjOgAuAESjOgAAAAz/////AQH/////AAAAABVgiQoCAAAAAAAEAAAAVGltZQEBpDoALgBEpDoA" +
           "AAEAJgH/////AQH/////AAAAABVgiQoCAAAAAAALAAAAUmVjZWl2ZVRpbWUBAaU6AC4ARKU6AAABACYB" +
           "/////wEB/////wAAAAAVYIkKAgAAAAAACQAAAExvY2FsVGltZQEBpjoALgBEpjoAAAEA0CL/////AQH/" +
           "////AAAAABVgiQoCAAAAAAAHAAAATWVzc2FnZQEBpzoALgBEpzoAAAAV/////wEB/////wAAAAAVYIkK" +
           "AgAAAAAACAAAAFNldmVyaXR5AQGoOgAuAESoOgAAAAX/////AQH/////AAAAABVgiQoCAAAAAQAKAAAA" +
           "V2VhdGhlck1hcAEBqToALgEBuDqpOgAAAQHNOv////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public WeatherMapDataState WeatherMap
        {
            get
            {
                return m_weatherMap;
            }

            set
            {
                if (!Object.ReferenceEquals(m_weatherMap, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_weatherMap = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Populates a list with the children that belong to the node.
        /// </summary>
        /// <param name="context">The context for the system being accessed.</param>
        /// <param name="children">The list of children to populate.</param>
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_weatherMap != null)
            {
                children.Add(m_weatherMap);
            }

            base.GetChildren(context, children);
        }

        /// <summary>
        /// Finds the child with the specified browse name.
        /// </summary>
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case Quickstarts.MyOPCServer.BrowseNames.WeatherMap:
                {
                    if (createOrReplace)
                    {
                        if (WeatherMap == null)
                        {
                            if (replacement == null)
                            {
                                WeatherMap = new WeatherMapDataState(this);
                            }
                            else
                            {
                                WeatherMap = (WeatherMapDataState)replacement;
                            }
                        }
                    }

                    instance = WeatherMap;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private WeatherMapDataState m_weatherMap;
        #endregion
    }
    #endif
    #endregion

    #region WeatherMapDataState Class
    #if (!OPCUA_EXCLUDE_WeatherMapDataState)
    /// <summary>
    /// Stores an instance of the WeatherMapDataType VariableType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class WeatherMapDataState : BaseDataVariableState<WeatherData>
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public WeatherMapDataState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Quickstarts.MyOPCServer.VariableTypes.WeatherMapDataType, Quickstarts.MyOPCServer.Namespaces.MyOPCServer, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default data type node for the instance.
        /// </summary>
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Quickstarts.MyOPCServer.DataTypes.WeatherData, Quickstarts.MyOPCServer.Namespaces.MyOPCServer, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default value rank for the instance.
        /// </summary>
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAADkAAABodHRwczovL2dpdGh1Yi5jb20vZGFyaW9mdWdhbGU5NS9zZXJ2ZXItb3BjLXVhLWRvdG5l" +
           "dGNvcmX/////FWCJAgIAAAABABoAAABXZWF0aGVyTWFwRGF0YVR5cGVJbnN0YW5jZQEBuDoBAbg6uDoA" +
           "AAEBzTr/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion
}
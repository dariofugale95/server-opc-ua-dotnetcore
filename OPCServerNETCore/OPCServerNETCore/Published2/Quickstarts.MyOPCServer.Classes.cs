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
           "AAH/////AwAAABVgiQoCAAAAAQAGAAAAQXBpVVJMAQGaOgAuAESaOgAAAAz/////AQH/////AAAAABVg" +
           "iQoCAAAAAQALAAAAV2VhdGhlckRhdGEBAZs6AC8BAbE6mzoAAAEBtTr/////AQH/////AwAAADVgiQoC" +
           "AAAAAQAEAAAARGF0ZQEBnDoDAAAAABkAAABEYXRlIG9mIHdlYXRoZXIgcHJldmlzaW9uAC8AP5w6AAAA" +
           "Df////8BAf////8AAAAANWCJCgIAAAABAAsAAABUZW1wZXJhdHVyZQEBnToDAAAAAB8AAABUZW1wZXJh" +
           "dHVyZSBwcmV2aXNpb24gaW4ga2VsdmluAC8AP506AAAACv////8BAf////8AAAAANWCJCgIAAAABAAQA" +
           "AABDaXR5AQGeOgMAAAAAGQAAAENpdHkgb2Ygd2VhdGhlciBwcmV2aXNpb24ALwA/njoAAAAM/////wEB" +
           "/////wAAAAAEYYIKBAAAAAEAFAAAAE9wZW5XZWF0aGVyTWFwTWV0aG9kAQGfOgAvAQGfOp86AAABAQEA" +
           "AAABAPkLAAEBozoBAAAAF2CpCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEBoDoALgBEoDoAAJYDAAAA" +
           "AQAqAQETAAAABAAAAENpdHkADP////8AAAAAAAEAKgEBEwAAAAQAAABkYXRlAA3/////AAAAAAABACoB" +
           "ARMAAAAEAAAAVGVtcAAK/////wAAAAAAAQAoAQEAAAABAAAAAAAAAAEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public PropertyState<string> ApiURL
        {
            get
            {
                return m_apiURL;
            }

            set
            {
                if (!Object.ReferenceEquals(m_apiURL, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_apiURL = value;
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
            if (m_apiURL != null)
            {
                children.Add(m_apiURL);
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
                case Quickstarts.MyOPCServer.BrowseNames.ApiURL:
                {
                    if (createOrReplace)
                    {
                        if (ApiURL == null)
                        {
                            if (replacement == null)
                            {
                                ApiURL = new PropertyState<string>(this);
                            }
                            else
                            {
                                ApiURL = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = ApiURL;
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
        private PropertyState<string> m_apiURL;
        private WeatherMapDataState m_weatherData;
        private WeatherMethodState m_openWeatherMapMethodMethod;
        #endregion
    }
    #endif
    #endregion

    #region InputClientState Class
    #if (!OPCUA_EXCLUDE_InputClientState)
    /// <summary>
    /// Stores an instance of the InputClientType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class InputClientState : BaseObjectState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public InputClientState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Quickstarts.MyOPCServer.ObjectTypes.InputClientType, Quickstarts.MyOPCServer.Namespaces.MyOPCServer, namespaceUris);
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
           "dGNvcmX/////hGCAAgEAAAABABcAAABJbnB1dENsaWVudFR5cGVJbnN0YW5jZQEBzzoBAc86zzoAAAH/" +
           "////AQAAABVgiQoCAAAAAQAPAAAASW5wdXRDaXR5Q2xpZW50AQHQOgAvAD/QOgAAAAz/////AwP/////" +
           "AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public BaseDataVariableState<string> InputCityClient
        {
            get
            {
                return m_inputCityClient;
            }

            set
            {
                if (!Object.ReferenceEquals(m_inputCityClient, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_inputCityClient = value;
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
            if (m_inputCityClient != null)
            {
                children.Add(m_inputCityClient);
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
                case Quickstarts.MyOPCServer.BrowseNames.InputCityClient:
                {
                    if (createOrReplace)
                    {
                        if (InputCityClient == null)
                        {
                            if (replacement == null)
                            {
                                InputCityClient = new BaseDataVariableState<string>(this);
                            }
                            else
                            {
                                InputCityClient = (BaseDataVariableState<string>)replacement;
                            }
                        }
                    }

                    instance = InputCityClient;
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
        private BaseDataVariableState<string> m_inputCityClient;
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
           "dGNvcmX/////BGGCCgQAAAABABEAAABXZWF0aGVyTWV0aG9kVHlwZQEBoToALwEBoTqhOgAAAQEBAAAA" +
           "AQD5CwABAaM6AQAAABdgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAaI6AC4ARKI6AACWAwAAAAEA" +
           "KgEBEwAAAAQAAABDaXR5AAz/////AAAAAAABACoBARMAAAAEAAAAZGF0ZQAN/////wAAAAAAAQAqAQET" +
           "AAAABAAAAFRlbXAACv////8AAAAAAAEAKAEBAAAAAQAAAAAAAAABAf////8AAAAA";
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
            DateTime date = (DateTime)_inputArguments[1];
            float temp = (float)_inputArguments[2];

            if (OnCall != null)
            {
                result = OnCall(
                    _context,
                    this,
                    _objectId,
                    city,
                    date,
                    temp);
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
        DateTime date,
        float temp);
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
           "dGNvcmX/////BGCAAgEAAAABABgAAABXZWF0aGVyRXZlbnRUeXBlSW5zdGFuY2UBAaM6AQGjOqM6AAD/" +
           "////CgAAABVgiQoCAAAAAAAHAAAARXZlbnRJZAEBpDoALgBEpDoAAAAP/////wEB/////wAAAAAVYIkK" +
           "AgAAAAAACQAAAEV2ZW50VHlwZQEBpToALgBEpToAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAACgAA" +
           "AFNvdXJjZU5vZGUBAaY6AC4ARKY6AAAAEf////8BAf////8AAAAAFWCJCgIAAAAAAAoAAABTb3VyY2VO" +
           "YW1lAQGnOgAuAESnOgAAAAz/////AQH/////AAAAABVgiQoCAAAAAAAEAAAAVGltZQEBqDoALgBEqDoA" +
           "AAEAJgH/////AQH/////AAAAABVgiQoCAAAAAAALAAAAUmVjZWl2ZVRpbWUBAak6AC4ARKk6AAABACYB" +
           "/////wEB/////wAAAAAVYIkKAgAAAAAACQAAAExvY2FsVGltZQEBqjoALgBEqjoAAAEA0CL/////AQH/" +
           "////AAAAABVgiQoCAAAAAAAHAAAATWVzc2FnZQEBqzoALgBEqzoAAAAV/////wEB/////wAAAAAVYIkK" +
           "AgAAAAAACAAAAFNldmVyaXR5AQGsOgAuAESsOgAAAAX/////AQH/////AAAAABVgiQoCAAAAAQAKAAAA" +
           "V2VhdGhlck1hcAEBrToALgEBsTqtOgAAAQG1Ov////8BAf////8DAAAANWCJCgIAAAABAAQAAABEYXRl" +
           "AQGuOgMAAAAAGQAAAERhdGUgb2Ygd2VhdGhlciBwcmV2aXNpb24ALwA/rjoAAAAN/////wEB/////wAA" +
           "AAA1YIkKAgAAAAEACwAAAFRlbXBlcmF0dXJlAQGvOgMAAAAAHwAAAFRlbXBlcmF0dXJlIHByZXZpc2lv" +
           "biBpbiBrZWx2aW4ALwA/rzoAAAAK/////wEB/////wAAAAA1YIkKAgAAAAEABAAAAENpdHkBAbA6AwAA" +
           "AAAZAAAAQ2l0eSBvZiB3ZWF0aGVyIHByZXZpc2lvbgAvAD+wOgAAAAz/////AQH/////AAAAAA==";
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
           "dGNvcmX/////FWCJAgIAAAABABoAAABXZWF0aGVyTWFwRGF0YVR5cGVJbnN0YW5jZQEBsToBAbE6sToA" +
           "AAEBtTr/////AQH/////AwAAADVgiQoCAAAAAQAEAAAARGF0ZQEBsjoDAAAAABkAAABEYXRlIG9mIHdl" +
           "YXRoZXIgcHJldmlzaW9uAC8AP7I6AAAADf////8BAf////8AAAAANWCJCgIAAAABAAsAAABUZW1wZXJh" +
           "dHVyZQEBszoDAAAAAB8AAABUZW1wZXJhdHVyZSBwcmV2aXNpb24gaW4ga2VsdmluAC8AP7M6AAAACv//" +
           "//8BAf////8AAAAANWCJCgIAAAABAAQAAABDaXR5AQG0OgMAAAAAGQAAAENpdHkgb2Ygd2VhdGhlciBw" +
           "cmV2aXNpb24ALwA/tDoAAAAM/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public BaseDataVariableState<DateTime> Date
        {
            get
            {
                return m_date;
            }

            set
            {
                if (!Object.ReferenceEquals(m_date, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_date = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<float> Temperature
        {
            get
            {
                return m_temperature;
            }

            set
            {
                if (!Object.ReferenceEquals(m_temperature, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_temperature = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<string> City
        {
            get
            {
                return m_city;
            }

            set
            {
                if (!Object.ReferenceEquals(m_city, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_city = value;
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
            if (m_date != null)
            {
                children.Add(m_date);
            }

            if (m_temperature != null)
            {
                children.Add(m_temperature);
            }

            if (m_city != null)
            {
                children.Add(m_city);
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
                case Quickstarts.MyOPCServer.BrowseNames.Date:
                {
                    if (createOrReplace)
                    {
                        if (Date == null)
                        {
                            if (replacement == null)
                            {
                                Date = new BaseDataVariableState<DateTime>(this);
                            }
                            else
                            {
                                Date = (BaseDataVariableState<DateTime>)replacement;
                            }
                        }
                    }

                    instance = Date;
                    break;
                }

                case Quickstarts.MyOPCServer.BrowseNames.Temperature:
                {
                    if (createOrReplace)
                    {
                        if (Temperature == null)
                        {
                            if (replacement == null)
                            {
                                Temperature = new BaseDataVariableState<float>(this);
                            }
                            else
                            {
                                Temperature = (BaseDataVariableState<float>)replacement;
                            }
                        }
                    }

                    instance = Temperature;
                    break;
                }

                case Quickstarts.MyOPCServer.BrowseNames.City:
                {
                    if (createOrReplace)
                    {
                        if (City == null)
                        {
                            if (replacement == null)
                            {
                                City = new BaseDataVariableState<string>(this);
                            }
                            else
                            {
                                City = (BaseDataVariableState<string>)replacement;
                            }
                        }
                    }

                    instance = City;
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
        private BaseDataVariableState<DateTime> m_date;
        private BaseDataVariableState<float> m_temperature;
        private BaseDataVariableState<string> m_city;
        #endregion
    }

    #region WeatherMapDataValue Class
    /// <summary>
    /// A typed version of the _BrowseName_ variable.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public class WeatherMapDataValue : BaseVariableValue
    {
        #region Constructors
        /// <summary>
        /// Initializes the instance with its defalt attribute values.
        /// </summary>
        public WeatherMapDataValue(WeatherMapDataState variable, WeatherData value, object dataLock) : base(dataLock)
        {
            m_value = value;

            if (m_value == null)
            {
                m_value = new WeatherData();
            }

            Initialize(variable);
        }
        #endregion

        #region Public Members
        /// <summary>
        /// The variable that the value belongs to.
        /// </summary>
        public WeatherMapDataState Variable
        {
            get { return m_variable; }
        }

        /// <summary>
        /// The value of the variable.
        /// </summary>
        public WeatherData Value
        {
            get { return m_value;  }
            set { m_value = value; }
        }
        #endregion

        #region Private Methods
        /// <summary>
        /// Initializes the object.
        /// </summary>
        private void Initialize(WeatherMapDataState variable)
        {
            lock (Lock)
            {
                m_variable = variable;

                variable.Value = m_value;

                variable.OnReadValue = OnReadValue;
                variable.OnSimpleWriteValue = OnWriteValue;

                BaseVariableState instance = null;
                List<BaseInstanceState> updateList = new List<BaseInstanceState>();
                updateList.Add(variable);

                instance = m_variable.Date;
                instance.OnReadValue = OnRead_Date;
                instance.OnSimpleWriteValue = OnWrite_Date;
                updateList.Add(instance);
                instance = m_variable.Temperature;
                instance.OnReadValue = OnRead_Temperature;
                instance.OnSimpleWriteValue = OnWrite_Temperature;
                updateList.Add(instance);
                instance = m_variable.City;
                instance.OnReadValue = OnRead_City;
                instance.OnSimpleWriteValue = OnWrite_City;
                updateList.Add(instance);

                SetUpdateList(updateList);
            }
        }

        /// <summary>
        /// Reads the value of the variable.
        /// </summary>
        protected ServiceResult OnReadValue(
            ISystemContext context,
            NodeState node,
            NumericRange indexRange,
            QualifiedName dataEncoding,
            ref object value,
            ref StatusCode statusCode,
            ref DateTime timestamp)
        {
            lock (Lock)
            {
                DoBeforeReadProcessing(context, node);

                if (m_value != null)
                {
                    value = m_value;
                }

                return Read(context, node, indexRange, dataEncoding, ref value, ref statusCode, ref timestamp);
            }
        }

        /// <summary>
        /// Writes the value of the variable.
        /// </summary>
        private ServiceResult OnWriteValue(ISystemContext context, NodeState node, ref object value)
        {
            lock (Lock)
            {
                m_value = (WeatherData)Write(value);
            }

            return ServiceResult.Good;
        }

        #region Date Access Methods
        /// <summary>
        /// Reads the value of the variable child.
        /// </summary>
        private ServiceResult OnRead_Date(
            ISystemContext context,
            NodeState node,
            NumericRange indexRange,
            QualifiedName dataEncoding,
            ref object value,
            ref StatusCode statusCode,
            ref DateTime timestamp)
        {
            lock (Lock)
            {
                DoBeforeReadProcessing(context, node);

                if (m_value != null)
                {
                    value = m_value.Date;
                }

                return Read(context, node, indexRange, dataEncoding, ref value, ref statusCode, ref timestamp);
            }
        }

        /// <summary>
        /// Writes the value of the variable child.
        /// </summary>
        private ServiceResult OnWrite_Date(ISystemContext context, NodeState node, ref object value)
        {
            lock (Lock)
            {
                m_value.Date = (DateTime)Write(value);
            }

            return ServiceResult.Good;
        }
        #endregion

        #region Temperature Access Methods
        /// <summary>
        /// Reads the value of the variable child.
        /// </summary>
        private ServiceResult OnRead_Temperature(
            ISystemContext context,
            NodeState node,
            NumericRange indexRange,
            QualifiedName dataEncoding,
            ref object value,
            ref StatusCode statusCode,
            ref DateTime timestamp)
        {
            lock (Lock)
            {
                DoBeforeReadProcessing(context, node);

                if (m_value != null)
                {
                    value = m_value.Temperature;
                }

                return Read(context, node, indexRange, dataEncoding, ref value, ref statusCode, ref timestamp);
            }
        }

        /// <summary>
        /// Writes the value of the variable child.
        /// </summary>
        private ServiceResult OnWrite_Temperature(ISystemContext context, NodeState node, ref object value)
        {
            lock (Lock)
            {
                m_value.Temperature = (float)Write(value);
            }

            return ServiceResult.Good;
        }
        #endregion

        #region City Access Methods
        /// <summary>
        /// Reads the value of the variable child.
        /// </summary>
        private ServiceResult OnRead_City(
            ISystemContext context,
            NodeState node,
            NumericRange indexRange,
            QualifiedName dataEncoding,
            ref object value,
            ref StatusCode statusCode,
            ref DateTime timestamp)
        {
            lock (Lock)
            {
                DoBeforeReadProcessing(context, node);

                if (m_value != null)
                {
                    value = m_value.City;
                }

                return Read(context, node, indexRange, dataEncoding, ref value, ref statusCode, ref timestamp);
            }
        }

        /// <summary>
        /// Writes the value of the variable child.
        /// </summary>
        private ServiceResult OnWrite_City(ISystemContext context, NodeState node, ref object value)
        {
            lock (Lock)
            {
                m_value.City = (string)Write(value);
            }

            return ServiceResult.Good;
        }
        #endregion
        #endregion

        #region Private Fields
        private WeatherData m_value;
        private WeatherMapDataState m_variable;
        #endregion
    }
    #endregion
    #endif
    #endregion
}
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
           "iQoCAAAAAQALAAAAV2VhdGhlckRhdGEBAZs6AC8BAbc6mzoAAAEBvjr/////AQH/////BgAAADVgiQoC" +
           "AAAAAQAEAAAARGF0ZQEBnDoDAAAAAB0AAABEYXRldGltZSBvZiB3ZWF0aGVyIHByZXZpc2lvbgAvAD+c" +
           "OgAAAA3/////AQH/////AAAAADVgiQoCAAAAAQALAAAAVGVtcGVyYXR1cmUBAZ06AwAAAAAVAAAAVGVt" +
           "cGVyYXR1cmUgaW4gS2VsdmluAC8BARg7nToAAAEB5Dr/////AQH/////AgAAADVgiQoCAAAAAQAEAAAA" +
           "VGVtcAEB3DoDAAAAABEAAABWYWx1ZSBvZiBWYXJpYWJsZQAvAD/cOgAAAAr/////AQH/////AAAAADVg" +
           "qQoCAAAAAQAEAAAASW5mbwEB3zoDAAAAACQAAABJbmZvcm1hdGlvbiBsaWtlIHVuaXQgb2YgbWVhc3Vy" +
           "ZW1lbnQALgBE3zoAABYBAHkDAVIAAAAvAAAAaHR0cDovL3d3dy5vcGNmb3VuZGF0aW9uLm9yZy9VQS91" +
           "bml0cy91bi9jZWZhY3RMQVAAAgEAAABLAwYAAABLZWx2aW4GAAAAS2VsdmluAQB3A/////8BAf////8A" +
           "AAAANWCJCgIAAAABAA4AAABNYXhUZW1wZXJhdHVyZQEBnjoDAAAAABkAAABNYXggVGVtcGVyYXR1cmUg" +
           "aW4gS2VsdmluAC8BARg7njoAAAEB5Dr/////AQH/////AgAAADVgiQoCAAAAAQAEAAAAVGVtcAEB3ToD" +
           "AAAAABEAAABWYWx1ZSBvZiBWYXJpYWJsZQAvAD/dOgAAAAr/////AQH/////AAAAADVgqQoCAAAAAQAE" +
           "AAAASW5mbwEB9DoDAAAAACQAAABJbmZvcm1hdGlvbiBsaWtlIHVuaXQgb2YgbWVhc3VyZW1lbnQALgBE" +
           "9DoAABYBAHkDAVIAAAAvAAAAaHR0cDovL3d3dy5vcGNmb3VuZGF0aW9uLm9yZy9VQS91bml0cy91bi9j" +
           "ZWZhY3RMQVAAAgEAAABLAwYAAABLZWx2aW4GAAAAS2VsdmluAQB3A/////8BAf////8AAAAANWCJCgIA" +
           "AAABAA4AAABNaW5UZW1wZXJhdHVyZQEBnzoDAAAAABkAAABNaW4gVGVtcGVyYXR1cmUgaW4gS2Vsdmlu" +
           "AC8BARg7nzoAAAEB5Dr/////AQH/////AgAAADVgiQoCAAAAAQAEAAAAVGVtcAEBCzsDAAAAABEAAABW" +
           "YWx1ZSBvZiBWYXJpYWJsZQAvAD8LOwAAAAr/////AQH/////AAAAADVgqQoCAAAAAQAEAAAASW5mbwEB" +
           "9joDAAAAACQAAABJbmZvcm1hdGlvbiBsaWtlIHVuaXQgb2YgbWVhc3VyZW1lbnQALgBE9joAABYBAHkD" +
           "AVIAAAAvAAAAaHR0cDovL3d3dy5vcGNmb3VuZGF0aW9uLm9yZy9VQS91bml0cy91bi9jZWZhY3RMQVAA" +
           "AgEAAABLAwYAAABLZWx2aW4GAAAAS2VsdmluAQB3A/////8BAf////8AAAAANWCJCgIAAAABAAgAAABQ" +
           "cmVzc3VyZQEBoDoDAAAAABIAAABQcmVzc3VyZSBpbiBQYXNjYWwALwEBFTugOgAAAQHkOv////8BAf//" +
           "//8CAAAANWCJCgIAAAABAAgAAABQcmVzc3VyZQEBDDsDAAAAABEAAABWYWx1ZSBvZiBWYXJpYWJsZQAv" +
           "AD8MOwAAAAr/////AQH/////AAAAADVgqQoCAAAAAQAEAAAASW5mbwEB+DoDAAAAACoAAABJbmZvcm1h" +
           "dGlvbiBsaWtlIHVuaXQgb2YgbWVhc3VyZW1lbnQscmFuZ2UALgBE+DoAABYBAHkDAVMAAAAvAAAAaHR0" +
           "cDovL3d3dy5vcGNmb3VuZGF0aW9uLm9yZy9VQS91bml0cy91bi9jZWZhY3RMRUsAAgIAAABQYQMGAAAA" +
           "UGFzY2FsBgAAAFBhc2NhbAEAdwP/////AQH/////AAAAADVgiQoCAAAAAQAEAAAAQ2l0eQEBoToDAAAA" +
           "ABkAAABDaXR5IG9mIHdlYXRoZXIgcHJldmlzaW9uAC8AP6E6AAAADP////8BAf////8AAAAABGGCCgQA" +
           "AAABABQAAABPcGVuV2VhdGhlck1hcE1ldGhvZAEBojoALwEBojqiOgAAAQEBAAAAAQD5CwABAaY6AQAA" +
           "ABdgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAaM6AC4ARKM6AACWAgAAAAEAKgEBOAAAAAQAAABD" +
           "aXR5AAz/////AAAAAAMAAAAAHQAAAENpdHkgdG8gZ2V0IFdlYXRoZXIgUHJldmlzaW9uAQAqAQFJAAAA" +
           "FAAAAE1lYXN1cmVPZlRlbXBlcmF0dXJlAAz/////AAAAAAMAAAAAHgAAAEM9Q2Vsc2l1cyxLPUtlbHZp" +
           "bi4gRGVmYXVsdDogSwEAKAEBAAAAAQAAAAAAAAABAf////8AAAAA";
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
           "dGNvcmX/////BGGCCgQAAAABABEAAABXZWF0aGVyTWV0aG9kVHlwZQEBpDoALwEBpDqkOgAAAQEBAAAA" +
           "AQD5CwABAaY6AQAAABdgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAaU6AC4ARKU6AACWAgAAAAEA" +
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
           "dGNvcmX/////BGCAAgEAAAABABgAAABXZWF0aGVyRXZlbnRUeXBlSW5zdGFuY2UBAaY6AQGmOqY6AAD/" +
           "////CgAAABVgiQoCAAAAAAAHAAAARXZlbnRJZAEBpzoALgBEpzoAAAAP/////wEB/////wAAAAAVYIkK" +
           "AgAAAAAACQAAAEV2ZW50VHlwZQEBqDoALgBEqDoAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAACgAA" +
           "AFNvdXJjZU5vZGUBAak6AC4ARKk6AAAAEf////8BAf////8AAAAAFWCJCgIAAAAAAAoAAABTb3VyY2VO" +
           "YW1lAQGqOgAuAESqOgAAAAz/////AQH/////AAAAABVgiQoCAAAAAAAEAAAAVGltZQEBqzoALgBEqzoA" +
           "AAEAJgH/////AQH/////AAAAABVgiQoCAAAAAAALAAAAUmVjZWl2ZVRpbWUBAaw6AC4ARKw6AAABACYB" +
           "/////wEB/////wAAAAAVYIkKAgAAAAAACQAAAExvY2FsVGltZQEBrToALgBErToAAAEA0CL/////AQH/" +
           "////AAAAABVgiQoCAAAAAAAHAAAATWVzc2FnZQEBrjoALgBErjoAAAAV/////wEB/////wAAAAAVYIkK" +
           "AgAAAAAACAAAAFNldmVyaXR5AQGvOgAuAESvOgAAAAX/////AQH/////AAAAABVgiQoCAAAAAQAKAAAA" +
           "V2VhdGhlck1hcAEBsDoALgEBtzqwOgAAAQG+Ov////8BAf////8GAAAANWCJCgIAAAABAAQAAABEYXRl" +
           "AQGxOgMAAAAAHQAAAERhdGV0aW1lIG9mIHdlYXRoZXIgcHJldmlzaW9uAC8AP7E6AAAADf////8BAf//" +
           "//8AAAAANWCJCgIAAAABAAsAAABUZW1wZXJhdHVyZQEBsjoDAAAAABUAAABUZW1wZXJhdHVyZSBpbiBL" +
           "ZWx2aW4ALwEBGDuyOgAAAQHkOv////8BAf////8CAAAANWCJCgIAAAABAAQAAABUZW1wAQENOwMAAAAA" +
           "EQAAAFZhbHVlIG9mIFZhcmlhYmxlAC8APw07AAAACv////8BAf////8AAAAANWCpCgIAAAABAAQAAABJ" +
           "bmZvAQHhOgMAAAAAJAAAAEluZm9ybWF0aW9uIGxpa2UgdW5pdCBvZiBtZWFzdXJlbWVudAAuAEThOgAA" +
           "FgEAeQMBUgAAAC8AAABodHRwOi8vd3d3Lm9wY2ZvdW5kYXRpb24ub3JnL1VBL3VuaXRzL3VuL2NlZmFj" +
           "dExBUAACAQAAAEsDBgAAAEtlbHZpbgYAAABLZWx2aW4BAHcD/////wEB/////wAAAAA1YIkKAgAAAAEA" +
           "DgAAAE1heFRlbXBlcmF0dXJlAQGzOgMAAAAAGQAAAE1heCBUZW1wZXJhdHVyZSBpbiBLZWx2aW4ALwEB" +
           "GDuzOgAAAQHkOv////8BAf////8CAAAANWCJCgIAAAABAAQAAABUZW1wAQEOOwMAAAAAEQAAAFZhbHVl" +
           "IG9mIFZhcmlhYmxlAC8APw47AAAACv////8BAf////8AAAAANWCpCgIAAAABAAQAAABJbmZvAQH6OgMA" +
           "AAAAJAAAAEluZm9ybWF0aW9uIGxpa2UgdW5pdCBvZiBtZWFzdXJlbWVudAAuAET6OgAAFgEAeQMBUgAA" +
           "AC8AAABodHRwOi8vd3d3Lm9wY2ZvdW5kYXRpb24ub3JnL1VBL3VuaXRzL3VuL2NlZmFjdExBUAACAQAA" +
           "AEsDBgAAAEtlbHZpbgYAAABLZWx2aW4BAHcD/////wEB/////wAAAAA1YIkKAgAAAAEADgAAAE1pblRl" +
           "bXBlcmF0dXJlAQG0OgMAAAAAGQAAAE1pbiBUZW1wZXJhdHVyZSBpbiBLZWx2aW4ALwEBGDu0OgAAAQHk" +
           "Ov////8BAf////8CAAAANWCJCgIAAAABAAQAAABUZW1wAQEPOwMAAAAAEQAAAFZhbHVlIG9mIFZhcmlh" +
           "YmxlAC8APw87AAAACv////8BAf////8AAAAANWCpCgIAAAABAAQAAABJbmZvAQH8OgMAAAAAJAAAAElu" +
           "Zm9ybWF0aW9uIGxpa2UgdW5pdCBvZiBtZWFzdXJlbWVudAAuAET8OgAAFgEAeQMBUgAAAC8AAABodHRw" +
           "Oi8vd3d3Lm9wY2ZvdW5kYXRpb24ub3JnL1VBL3VuaXRzL3VuL2NlZmFjdExBUAACAQAAAEsDBgAAAEtl" +
           "bHZpbgYAAABLZWx2aW4BAHcD/////wEB/////wAAAAA1YIkKAgAAAAEACAAAAFByZXNzdXJlAQG1OgMA" +
           "AAAAEgAAAFByZXNzdXJlIGluIFBhc2NhbAAvAQEVO7U6AAABAeQ6/////wEB/////wIAAAA1YIkKAgAA" +
           "AAEACAAAAFByZXNzdXJlAQEQOwMAAAAAEQAAAFZhbHVlIG9mIFZhcmlhYmxlAC8APxA7AAAACv////8B" +
           "Af////8AAAAANWCpCgIAAAABAAQAAABJbmZvAQH+OgMAAAAAKgAAAEluZm9ybWF0aW9uIGxpa2UgdW5p" +
           "dCBvZiBtZWFzdXJlbWVudCxyYW5nZQAuAET+OgAAFgEAeQMBUwAAAC8AAABodHRwOi8vd3d3Lm9wY2Zv" +
           "dW5kYXRpb24ub3JnL1VBL3VuaXRzL3VuL2NlZmFjdExFSwACAgAAAFBhAwYAAABQYXNjYWwGAAAAUGFz" +
           "Y2FsAQB3A/////8BAf////8AAAAANWCJCgIAAAABAAQAAABDaXR5AQG2OgMAAAAAGQAAAENpdHkgb2Yg" +
           "d2VhdGhlciBwcmV2aXNpb24ALwA/tjoAAAAM/////wEB/////wAAAAA=";
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
           "dGNvcmX/////FWCJAgIAAAABABoAAABXZWF0aGVyTWFwRGF0YVR5cGVJbnN0YW5jZQEBtzoBAbc6tzoA" +
           "AAEBvjr/////AQH/////BgAAADVgiQoCAAAAAQAEAAAARGF0ZQEBuDoDAAAAAB0AAABEYXRldGltZSBv" +
           "ZiB3ZWF0aGVyIHByZXZpc2lvbgAvAD+4OgAAAA3/////AQH/////AAAAADVgiQoCAAAAAQALAAAAVGVt" +
           "cGVyYXR1cmUBAbk6AwAAAAAVAAAAVGVtcGVyYXR1cmUgaW4gS2VsdmluAC8BARg7uToAAAEB5Dr/////" +
           "AQH/////AgAAADVgiQoCAAAAAQAEAAAAVGVtcAEBETsDAAAAABEAAABWYWx1ZSBvZiBWYXJpYWJsZQAv" +
           "AD8ROwAAAAr/////AQH/////AAAAADVgqQoCAAAAAQAEAAAASW5mbwEB4zoDAAAAACQAAABJbmZvcm1h" +
           "dGlvbiBsaWtlIHVuaXQgb2YgbWVhc3VyZW1lbnQALgBE4zoAABYBAHkDAVIAAAAvAAAAaHR0cDovL3d3" +
           "dy5vcGNmb3VuZGF0aW9uLm9yZy9VQS91bml0cy91bi9jZWZhY3RMQVAAAgEAAABLAwYAAABLZWx2aW4G" +
           "AAAAS2VsdmluAQB3A/////8BAf////8AAAAANWCJCgIAAAABAA4AAABNYXhUZW1wZXJhdHVyZQEBujoD" +
           "AAAAABkAAABNYXggVGVtcGVyYXR1cmUgaW4gS2VsdmluAC8BARg7ujoAAAEB5Dr/////AQH/////AgAA" +
           "ADVgiQoCAAAAAQAEAAAAVGVtcAEBEjsDAAAAABEAAABWYWx1ZSBvZiBWYXJpYWJsZQAvAD8SOwAAAAr/" +
           "////AQH/////AAAAADVgqQoCAAAAAQAEAAAASW5mbwEBADsDAAAAACQAAABJbmZvcm1hdGlvbiBsaWtl" +
           "IHVuaXQgb2YgbWVhc3VyZW1lbnQALgBEADsAABYBAHkDAVIAAAAvAAAAaHR0cDovL3d3dy5vcGNmb3Vu" +
           "ZGF0aW9uLm9yZy9VQS91bml0cy91bi9jZWZhY3RMQVAAAgEAAABLAwYAAABLZWx2aW4GAAAAS2Vsdmlu" +
           "AQB3A/////8BAf////8AAAAANWCJCgIAAAABAA4AAABNaW5UZW1wZXJhdHVyZQEBuzoDAAAAABkAAABN" +
           "aW4gVGVtcGVyYXR1cmUgaW4gS2VsdmluAC8BARg7uzoAAAEB5Dr/////AQH/////AgAAADVgiQoCAAAA" +
           "AQAEAAAAVGVtcAEBEzsDAAAAABEAAABWYWx1ZSBvZiBWYXJpYWJsZQAvAD8TOwAAAAr/////AQH/////" +
           "AAAAADVgqQoCAAAAAQAEAAAASW5mbwEBAjsDAAAAACQAAABJbmZvcm1hdGlvbiBsaWtlIHVuaXQgb2Yg" +
           "bWVhc3VyZW1lbnQALgBEAjsAABYBAHkDAVIAAAAvAAAAaHR0cDovL3d3dy5vcGNmb3VuZGF0aW9uLm9y" +
           "Zy9VQS91bml0cy91bi9jZWZhY3RMQVAAAgEAAABLAwYAAABLZWx2aW4GAAAAS2VsdmluAQB3A/////8B" +
           "Af////8AAAAANWCJCgIAAAABAAgAAABQcmVzc3VyZQEBvDoDAAAAABIAAABQcmVzc3VyZSBpbiBQYXNj" +
           "YWwALwEBFTu8OgAAAQHkOv////8BAf////8CAAAANWCJCgIAAAABAAgAAABQcmVzc3VyZQEBFDsDAAAA" +
           "ABEAAABWYWx1ZSBvZiBWYXJpYWJsZQAvAD8UOwAAAAr/////AQH/////AAAAADVgqQoCAAAAAQAEAAAA" +
           "SW5mbwEBBDsDAAAAACoAAABJbmZvcm1hdGlvbiBsaWtlIHVuaXQgb2YgbWVhc3VyZW1lbnQscmFuZ2UA" +
           "LgBEBDsAABYBAHkDAVMAAAAvAAAAaHR0cDovL3d3dy5vcGNmb3VuZGF0aW9uLm9yZy9VQS91bml0cy91" +
           "bi9jZWZhY3RMRUsAAgIAAABQYQMGAAAAUGFzY2FsBgAAAFBhc2NhbAEAdwP/////AQH/////AAAAADVg" +
           "iQoCAAAAAQAEAAAAQ2l0eQEBvToDAAAAABkAAABDaXR5IG9mIHdlYXRoZXIgcHJldmlzaW9uAC8AP706" +
           "AAAADP////8BAf////8AAAAA";
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
        public AnalogTempDataState Temperature
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
        public AnalogTempDataState MaxTemperature
        {
            get
            {
                return m_maxTemperature;
            }

            set
            {
                if (!Object.ReferenceEquals(m_maxTemperature, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_maxTemperature = value;
            }
        }

        /// <remarks />
        public AnalogTempDataState MinTemperature
        {
            get
            {
                return m_minTemperature;
            }

            set
            {
                if (!Object.ReferenceEquals(m_minTemperature, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_minTemperature = value;
            }
        }

        /// <remarks />
        public AnalogPressDataState Pressure
        {
            get
            {
                return m_pressure;
            }

            set
            {
                if (!Object.ReferenceEquals(m_pressure, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_pressure = value;
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

            if (m_maxTemperature != null)
            {
                children.Add(m_maxTemperature);
            }

            if (m_minTemperature != null)
            {
                children.Add(m_minTemperature);
            }

            if (m_pressure != null)
            {
                children.Add(m_pressure);
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
                                Temperature = new AnalogTempDataState(this);
                            }
                            else
                            {
                                Temperature = (AnalogTempDataState)replacement;
                            }
                        }
                    }

                    instance = Temperature;
                    break;
                }

                case Quickstarts.MyOPCServer.BrowseNames.MaxTemperature:
                {
                    if (createOrReplace)
                    {
                        if (MaxTemperature == null)
                        {
                            if (replacement == null)
                            {
                                MaxTemperature = new AnalogTempDataState(this);
                            }
                            else
                            {
                                MaxTemperature = (AnalogTempDataState)replacement;
                            }
                        }
                    }

                    instance = MaxTemperature;
                    break;
                }

                case Quickstarts.MyOPCServer.BrowseNames.MinTemperature:
                {
                    if (createOrReplace)
                    {
                        if (MinTemperature == null)
                        {
                            if (replacement == null)
                            {
                                MinTemperature = new AnalogTempDataState(this);
                            }
                            else
                            {
                                MinTemperature = (AnalogTempDataState)replacement;
                            }
                        }
                    }

                    instance = MinTemperature;
                    break;
                }

                case Quickstarts.MyOPCServer.BrowseNames.Pressure:
                {
                    if (createOrReplace)
                    {
                        if (Pressure == null)
                        {
                            if (replacement == null)
                            {
                                Pressure = new AnalogPressDataState(this);
                            }
                            else
                            {
                                Pressure = (AnalogPressDataState)replacement;
                            }
                        }
                    }

                    instance = Pressure;
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
        private AnalogTempDataState m_temperature;
        private AnalogTempDataState m_maxTemperature;
        private AnalogTempDataState m_minTemperature;
        private AnalogPressDataState m_pressure;
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
                instance = m_variable.Temperature.Info;
                instance.OnReadValue = OnRead_Temperature_Info;
                instance.OnSimpleWriteValue = OnWrite_Temperature_Info;
                updateList.Add(instance);
                instance = m_variable.MaxTemperature;
                instance.OnReadValue = OnRead_MaxTemperature;
                instance.OnSimpleWriteValue = OnWrite_MaxTemperature;
                updateList.Add(instance);
                instance = m_variable.MaxTemperature.Info;
                instance.OnReadValue = OnRead_MaxTemperature_Info;
                instance.OnSimpleWriteValue = OnWrite_MaxTemperature_Info;
                updateList.Add(instance);
                instance = m_variable.MinTemperature;
                instance.OnReadValue = OnRead_MinTemperature;
                instance.OnSimpleWriteValue = OnWrite_MinTemperature;
                updateList.Add(instance);
                instance = m_variable.MinTemperature.Info;
                instance.OnReadValue = OnRead_MinTemperature_Info;
                instance.OnSimpleWriteValue = OnWrite_MinTemperature_Info;
                updateList.Add(instance);
                instance = m_variable.Pressure;
                instance.OnReadValue = OnRead_Pressure;
                instance.OnSimpleWriteValue = OnWrite_Pressure;
                updateList.Add(instance);
                instance = m_variable.Pressure.Info;
                instance.OnReadValue = OnRead_Pressure_Info;
                instance.OnSimpleWriteValue = OnWrite_Pressure_Info;
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
                m_value.Temperature = (AnalogData)Write(value);
            }

            return ServiceResult.Good;
        }
        #endregion

        #region Temperature_Info Access Methods
        /// <summary>
        /// Reads the value of the variable child.
        /// </summary>
        private ServiceResult OnRead_Temperature_Info(
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
                    value = m_value.Temperature.Info;
                }

                return Read(context, node, indexRange, dataEncoding, ref value, ref statusCode, ref timestamp);
            }
        }

        /// <summary>
        /// Writes the value of the variable child.
        /// </summary>
        private ServiceResult OnWrite_Temperature_Info(ISystemContext context, NodeState node, ref object value)
        {
            lock (Lock)
            {
                m_value.Temperature.Info = (EUInformation)Write(value);
            }

            return ServiceResult.Good;
        }
        #endregion

        #region MaxTemperature Access Methods
        /// <summary>
        /// Reads the value of the variable child.
        /// </summary>
        private ServiceResult OnRead_MaxTemperature(
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
                    value = m_value.MaxTemperature;
                }

                return Read(context, node, indexRange, dataEncoding, ref value, ref statusCode, ref timestamp);
            }
        }

        /// <summary>
        /// Writes the value of the variable child.
        /// </summary>
        private ServiceResult OnWrite_MaxTemperature(ISystemContext context, NodeState node, ref object value)
        {
            lock (Lock)
            {
                m_value.MaxTemperature = (AnalogData)Write(value);
            }

            return ServiceResult.Good;
        }
        #endregion

        #region MaxTemperature_Info Access Methods
        /// <summary>
        /// Reads the value of the variable child.
        /// </summary>
        private ServiceResult OnRead_MaxTemperature_Info(
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
                    value = m_value.MaxTemperature.Info;
                }

                return Read(context, node, indexRange, dataEncoding, ref value, ref statusCode, ref timestamp);
            }
        }

        /// <summary>
        /// Writes the value of the variable child.
        /// </summary>
        private ServiceResult OnWrite_MaxTemperature_Info(ISystemContext context, NodeState node, ref object value)
        {
            lock (Lock)
            {
                m_value.MaxTemperature.Info = (EUInformation)Write(value);
            }

            return ServiceResult.Good;
        }
        #endregion

        #region MinTemperature Access Methods
        /// <summary>
        /// Reads the value of the variable child.
        /// </summary>
        private ServiceResult OnRead_MinTemperature(
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
                    value = m_value.MinTemperature;
                }

                return Read(context, node, indexRange, dataEncoding, ref value, ref statusCode, ref timestamp);
            }
        }

        /// <summary>
        /// Writes the value of the variable child.
        /// </summary>
        private ServiceResult OnWrite_MinTemperature(ISystemContext context, NodeState node, ref object value)
        {
            lock (Lock)
            {
                m_value.MinTemperature = (AnalogData)Write(value);
            }

            return ServiceResult.Good;
        }
        #endregion

        #region MinTemperature_Info Access Methods
        /// <summary>
        /// Reads the value of the variable child.
        /// </summary>
        private ServiceResult OnRead_MinTemperature_Info(
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
                    value = m_value.MinTemperature.Info;
                }

                return Read(context, node, indexRange, dataEncoding, ref value, ref statusCode, ref timestamp);
            }
        }

        /// <summary>
        /// Writes the value of the variable child.
        /// </summary>
        private ServiceResult OnWrite_MinTemperature_Info(ISystemContext context, NodeState node, ref object value)
        {
            lock (Lock)
            {
                m_value.MinTemperature.Info = (EUInformation)Write(value);
            }

            return ServiceResult.Good;
        }
        #endregion

        #region Pressure Access Methods
        /// <summary>
        /// Reads the value of the variable child.
        /// </summary>
        private ServiceResult OnRead_Pressure(
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
                    value = m_value.Pressure;
                }

                return Read(context, node, indexRange, dataEncoding, ref value, ref statusCode, ref timestamp);
            }
        }

        /// <summary>
        /// Writes the value of the variable child.
        /// </summary>
        private ServiceResult OnWrite_Pressure(ISystemContext context, NodeState node, ref object value)
        {
            lock (Lock)
            {
                m_value.Pressure = (AnalogData)Write(value);
            }

            return ServiceResult.Good;
        }
        #endregion

        #region Pressure_Info Access Methods
        /// <summary>
        /// Reads the value of the variable child.
        /// </summary>
        private ServiceResult OnRead_Pressure_Info(
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
                    value = m_value.Pressure.Info;
                }

                return Read(context, node, indexRange, dataEncoding, ref value, ref statusCode, ref timestamp);
            }
        }

        /// <summary>
        /// Writes the value of the variable child.
        /// </summary>
        private ServiceResult OnWrite_Pressure_Info(ISystemContext context, NodeState node, ref object value)
        {
            lock (Lock)
            {
                m_value.Pressure.Info = (EUInformation)Write(value);
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

    #region AnalogTempDataState Class
    #if (!OPCUA_EXCLUDE_AnalogTempDataState)
    /// <summary>
    /// Stores an instance of the AnalogTempDataType VariableType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class AnalogTempDataState : BaseDataVariableState<AnalogData>
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public AnalogTempDataState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Quickstarts.MyOPCServer.VariableTypes.AnalogTempDataType, Quickstarts.MyOPCServer.Namespaces.MyOPCServer, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default data type node for the instance.
        /// </summary>
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Quickstarts.MyOPCServer.DataTypes.AnalogData, Quickstarts.MyOPCServer.Namespaces.MyOPCServer, namespaceUris);
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
           "dGNvcmX/////FWCJAgIAAAABABoAAABBbmFsb2dUZW1wRGF0YVR5cGVJbnN0YW5jZQEBGDsBARg7GDsA" +
           "AAEB5Dr/////AQH/////AgAAADVgiQoCAAAAAQAEAAAAVGVtcAEBGTsDAAAAABEAAABWYWx1ZSBvZiBW" +
           "YXJpYWJsZQAvAD8ZOwAAAAr/////AQH/////AAAAADVgqQoCAAAAAQAEAAAASW5mbwEBGjsDAAAAACQA" +
           "AABJbmZvcm1hdGlvbiBsaWtlIHVuaXQgb2YgbWVhc3VyZW1lbnQALgBEGjsAABYBAHkDAVIAAAAvAAAA" +
           "aHR0cDovL3d3dy5vcGNmb3VuZGF0aW9uLm9yZy9VQS91bml0cy91bi9jZWZhY3RMQVAAAgEAAABLAwYA" +
           "AABLZWx2aW4GAAAAS2VsdmluAQB3A/////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public BaseDataVariableState<float> Temp
        {
            get
            {
                return m_temp;
            }

            set
            {
                if (!Object.ReferenceEquals(m_temp, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_temp = value;
            }
        }

        /// <remarks />
        public PropertyState<EUInformation> Info
        {
            get
            {
                return m_info;
            }

            set
            {
                if (!Object.ReferenceEquals(m_info, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_info = value;
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
            if (m_temp != null)
            {
                children.Add(m_temp);
            }

            if (m_info != null)
            {
                children.Add(m_info);
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
                case Quickstarts.MyOPCServer.BrowseNames.Temp:
                {
                    if (createOrReplace)
                    {
                        if (Temp == null)
                        {
                            if (replacement == null)
                            {
                                Temp = new BaseDataVariableState<float>(this);
                            }
                            else
                            {
                                Temp = (BaseDataVariableState<float>)replacement;
                            }
                        }
                    }

                    instance = Temp;
                    break;
                }

                case Quickstarts.MyOPCServer.BrowseNames.Info:
                {
                    if (createOrReplace)
                    {
                        if (Info == null)
                        {
                            if (replacement == null)
                            {
                                Info = new PropertyState<EUInformation>(this);
                            }
                            else
                            {
                                Info = (PropertyState<EUInformation>)replacement;
                            }
                        }
                    }

                    instance = Info;
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
        private BaseDataVariableState<float> m_temp;
        private PropertyState<EUInformation> m_info;
        #endregion
    }

    #region AnalogTempDataValue Class
    /// <summary>
    /// A typed version of the _BrowseName_ variable.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public class AnalogTempDataValue : BaseVariableValue
    {
        #region Constructors
        /// <summary>
        /// Initializes the instance with its defalt attribute values.
        /// </summary>
        public AnalogTempDataValue(AnalogTempDataState variable, AnalogData value, object dataLock) : base(dataLock)
        {
            m_value = value;

            if (m_value == null)
            {
                m_value = new AnalogData();
            }

            Initialize(variable);
        }
        #endregion

        #region Public Members
        /// <summary>
        /// The variable that the value belongs to.
        /// </summary>
        public AnalogTempDataState Variable
        {
            get { return m_variable; }
        }

        /// <summary>
        /// The value of the variable.
        /// </summary>
        public AnalogData Value
        {
            get { return m_value;  }
            set { m_value = value; }
        }
        #endregion

        #region Private Methods
        /// <summary>
        /// Initializes the object.
        /// </summary>
        private void Initialize(AnalogTempDataState variable)
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

                instance = m_variable.Info;
                instance.OnReadValue = OnRead_Info;
                instance.OnSimpleWriteValue = OnWrite_Info;
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
                m_value = (AnalogData)Write(value);
            }

            return ServiceResult.Good;
        }

        #region Info Access Methods
        /// <summary>
        /// Reads the value of the variable child.
        /// </summary>
        private ServiceResult OnRead_Info(
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
                    value = m_value.Info;
                }

                return Read(context, node, indexRange, dataEncoding, ref value, ref statusCode, ref timestamp);
            }
        }

        /// <summary>
        /// Writes the value of the variable child.
        /// </summary>
        private ServiceResult OnWrite_Info(ISystemContext context, NodeState node, ref object value)
        {
            lock (Lock)
            {
                m_value.Info = (EUInformation)Write(value);
            }

            return ServiceResult.Good;
        }
        #endregion
        #endregion

        #region Private Fields
        private AnalogData m_value;
        private AnalogTempDataState m_variable;
        #endregion
    }
    #endregion
    #endif
    #endregion

    #region AnalogPressDataState Class
    #if (!OPCUA_EXCLUDE_AnalogPressDataState)
    /// <summary>
    /// Stores an instance of the AnalogPressDataType VariableType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class AnalogPressDataState : BaseDataVariableState<AnalogData>
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public AnalogPressDataState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Quickstarts.MyOPCServer.VariableTypes.AnalogPressDataType, Quickstarts.MyOPCServer.Namespaces.MyOPCServer, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default data type node for the instance.
        /// </summary>
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Quickstarts.MyOPCServer.DataTypes.AnalogData, Quickstarts.MyOPCServer.Namespaces.MyOPCServer, namespaceUris);
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
           "dGNvcmX/////FWCJAgIAAAABABsAAABBbmFsb2dQcmVzc0RhdGFUeXBlSW5zdGFuY2UBARU7AQEVOxU7" +
           "AAABAeQ6/////wEB/////wIAAAA1YIkKAgAAAAEACAAAAFByZXNzdXJlAQEWOwMAAAAAEQAAAFZhbHVl" +
           "IG9mIFZhcmlhYmxlAC8APxY7AAAACv////8BAf////8AAAAANWCpCgIAAAABAAQAAABJbmZvAQEXOwMA" +
           "AAAAKgAAAEluZm9ybWF0aW9uIGxpa2UgdW5pdCBvZiBtZWFzdXJlbWVudCxyYW5nZQAuAEQXOwAAFgEA" +
           "eQMBUwAAAC8AAABodHRwOi8vd3d3Lm9wY2ZvdW5kYXRpb24ub3JnL1VBL3VuaXRzL3VuL2NlZmFjdExF" +
           "SwACAgAAAFBhAwYAAABQYXNjYWwGAAAAUGFzY2FsAQB3A/////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public BaseDataVariableState<float> Pressure
        {
            get
            {
                return m_pressure;
            }

            set
            {
                if (!Object.ReferenceEquals(m_pressure, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_pressure = value;
            }
        }

        /// <remarks />
        public PropertyState<EUInformation> Info
        {
            get
            {
                return m_info;
            }

            set
            {
                if (!Object.ReferenceEquals(m_info, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_info = value;
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
            if (m_pressure != null)
            {
                children.Add(m_pressure);
            }

            if (m_info != null)
            {
                children.Add(m_info);
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
                case Quickstarts.MyOPCServer.BrowseNames.Pressure:
                {
                    if (createOrReplace)
                    {
                        if (Pressure == null)
                        {
                            if (replacement == null)
                            {
                                Pressure = new BaseDataVariableState<float>(this);
                            }
                            else
                            {
                                Pressure = (BaseDataVariableState<float>)replacement;
                            }
                        }
                    }

                    instance = Pressure;
                    break;
                }

                case Quickstarts.MyOPCServer.BrowseNames.Info:
                {
                    if (createOrReplace)
                    {
                        if (Info == null)
                        {
                            if (replacement == null)
                            {
                                Info = new PropertyState<EUInformation>(this);
                            }
                            else
                            {
                                Info = (PropertyState<EUInformation>)replacement;
                            }
                        }
                    }

                    instance = Info;
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
        private BaseDataVariableState<float> m_pressure;
        private PropertyState<EUInformation> m_info;
        #endregion
    }

    #region AnalogPressDataValue Class
    /// <summary>
    /// A typed version of the _BrowseName_ variable.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public class AnalogPressDataValue : BaseVariableValue
    {
        #region Constructors
        /// <summary>
        /// Initializes the instance with its defalt attribute values.
        /// </summary>
        public AnalogPressDataValue(AnalogPressDataState variable, AnalogData value, object dataLock) : base(dataLock)
        {
            m_value = value;

            if (m_value == null)
            {
                m_value = new AnalogData();
            }

            Initialize(variable);
        }
        #endregion

        #region Public Members
        /// <summary>
        /// The variable that the value belongs to.
        /// </summary>
        public AnalogPressDataState Variable
        {
            get { return m_variable; }
        }

        /// <summary>
        /// The value of the variable.
        /// </summary>
        public AnalogData Value
        {
            get { return m_value;  }
            set { m_value = value; }
        }
        #endregion

        #region Private Methods
        /// <summary>
        /// Initializes the object.
        /// </summary>
        private void Initialize(AnalogPressDataState variable)
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

                instance = m_variable.Info;
                instance.OnReadValue = OnRead_Info;
                instance.OnSimpleWriteValue = OnWrite_Info;
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
                m_value = (AnalogData)Write(value);
            }

            return ServiceResult.Good;
        }

        #region Info Access Methods
        /// <summary>
        /// Reads the value of the variable child.
        /// </summary>
        private ServiceResult OnRead_Info(
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
                    value = m_value.Info;
                }

                return Read(context, node, indexRange, dataEncoding, ref value, ref statusCode, ref timestamp);
            }
        }

        /// <summary>
        /// Writes the value of the variable child.
        /// </summary>
        private ServiceResult OnWrite_Info(ISystemContext context, NodeState node, ref object value)
        {
            lock (Lock)
            {
                m_value.Info = (EUInformation)Write(value);
            }

            return ServiceResult.Good;
        }
        #endregion
        #endregion

        #region Private Fields
        private AnalogData m_value;
        private AnalogPressDataState m_variable;
        #endregion
    }
    #endregion
    #endif
    #endregion
}
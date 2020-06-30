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
           "FWCJCgIAAAABAAsAAABXZWF0aGVyRGF0YQEBqjoALwEBzzqqOgAAAQHNOv////8BAf////8GAAAANWCJ" +
           "CgIAAAABAAQAAABEYXRlAQGsOgMAAAAAHQAAAERhdGV0aW1lIG9mIHdlYXRoZXIgcHJldmlzaW9uAC8A" +
           "P6w6AAAADf////8BAf////8AAAAANWCJCgIAAAABAAsAAABUZW1wZXJhdHVyZQEBrToDAAAAABUAAABU" +
           "ZW1wZXJhdHVyZSBpbiBLZWx2aW4ALwEB+TqtOgAAAQHOOv////8BAf////8CAAAANWCJCgIAAAABAAQA" +
           "AABEYXRhAQG4OgMAAAAAEQAAAFZhbHVlIG9mIFZhcmlhYmxlAC8AP7g6AAAACv////8BAf////8AAAAA" +
           "NWCJCgIAAAABAAQAAABJbmZvAQGzOgMAAAAAJAAAAEluZm9ybWF0aW9uIGxpa2UgdW5pdCBvZiBtZWFz" +
           "dXJlbWVudAAuAESzOgAAAQB3A/////8BAf////8AAAAANWCJCgIAAAABAA4AAABNYXhUZW1wZXJhdHVy" +
           "ZQEBtDoDAAAAABkAAABNYXggVGVtcGVyYXR1cmUgaW4gS2VsdmluAC8BAfk6tDoAAAEBzjr/////AQH/" +
           "////AgAAADVgiQoCAAAAAQAEAAAARGF0YQEBCjsDAAAAABEAAABWYWx1ZSBvZiBWYXJpYWJsZQAvAD8K" +
           "OwAAAAr/////AQH/////AAAAADVgiQoCAAAAAQAEAAAASW5mbwEBtjoDAAAAACQAAABJbmZvcm1hdGlv" +
           "biBsaWtlIHVuaXQgb2YgbWVhc3VyZW1lbnQALgBEtjoAAAEAdwP/////AQH/////AAAAADVgiQoCAAAA" +
           "AQAOAAAATWluVGVtcGVyYXR1cmUBAbc6AwAAAAAZAAAATWluIFRlbXBlcmF0dXJlIGluIEtlbHZpbgAv" +
           "AQH5Orc6AAABAc46/////wEB/////wIAAAA1YIkKAgAAAAEABAAAAERhdGEBAQs7AwAAAAARAAAAVmFs" +
           "dWUgb2YgVmFyaWFibGUALwA/CzsAAAAK/////wEB/////wAAAAA1YIkKAgAAAAEABAAAAEluZm8BAbo6" +
           "AwAAAAAkAAAASW5mb3JtYXRpb24gbGlrZSB1bml0IG9mIG1lYXN1cmVtZW50AC4ARLo6AAABAHcD////" +
           "/wEB/////wAAAAA1YIkKAgAAAAEACAAAAFByZXNzdXJlAQG7OgMAAAAAEgAAAFByZXNzdXJlIGluIFBh" +
           "c2NhbAAvAQH5Ors6AAABAc46/////wEB/////wIAAAA1YIkKAgAAAAEABAAAAERhdGEBAQw7AwAAAAAR" +
           "AAAAVmFsdWUgb2YgVmFyaWFibGUALwA/DDsAAAAK/////wEB/////wAAAAA1YIkKAgAAAAEABAAAAElu" +
           "Zm8BAb06AwAAAAAkAAAASW5mb3JtYXRpb24gbGlrZSB1bml0IG9mIG1lYXN1cmVtZW50AC4ARL06AAAB" +
           "AHcD/////wEB/////wAAAAA1YIkKAgAAAAEABAAAAENpdHkBAb46AwAAAAAZAAAAQ2l0eSBvZiB3ZWF0" +
           "aGVyIHByZXZpc2lvbgAvAD++OgAAAAz/////AQH/////AAAAAARhggoEAAAAAQAUAAAAT3BlbldlYXRo" +
           "ZXJNYXBNZXRob2QBAZs6AC8BAZs6mzoAAAEBAQAAAAEA+QsAAQGfOgEAAAAXYKkKAgAAAAAADgAAAElu" +
           "cHV0QXJndW1lbnRzAQGcOgAuAEScOgAAlgIAAAABACoBATgAAAAEAAAAQ2l0eQAM/////wAAAAADAAAA" +
           "AB0AAABDaXR5IHRvIGdldCBXZWF0aGVyIFByZXZpc2lvbgEAKgEBSQAAABQAAABNZWFzdXJlT2ZUZW1w" +
           "ZXJhdHVyZQAM/////wAAAAADAAAAAB4AAABDPUNlbHNpdXMsSz1LZWx2aW4uIERlZmF1bHQ6IEsBACgB" +
           "AQAAAAEAAAAAAAAAAQH/////AAAAAA==";
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
        public WeatherMapVariableState WeatherData
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
                                WeatherData = new WeatherMapVariableState(this);
                            }
                            else
                            {
                                WeatherData = (WeatherMapVariableState)replacement;
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
        private WeatherMapVariableState m_weatherData;
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
           "V2VhdGhlck1hcAEBqToALgEBzzqpOgAAAQHNOv////8BAf////8GAAAANWCJCgIAAAABAAQAAABEYXRl" +
           "AQG/OgMAAAAAHQAAAERhdGV0aW1lIG9mIHdlYXRoZXIgcHJldmlzaW9uAC8AP786AAAADf////8BAf//" +
           "//8AAAAANWCJCgIAAAABAAsAAABUZW1wZXJhdHVyZQEBwDoDAAAAABUAAABUZW1wZXJhdHVyZSBpbiBL" +
           "ZWx2aW4ALwEB+TrAOgAAAQHOOv////8BAf////8CAAAANWCJCgIAAAABAAQAAABEYXRhAQENOwMAAAAA" +
           "EQAAAFZhbHVlIG9mIFZhcmlhYmxlAC8APw07AAAACv////8BAf////8AAAAANWCJCgIAAAABAAQAAABJ" +
           "bmZvAQHCOgMAAAAAJAAAAEluZm9ybWF0aW9uIGxpa2UgdW5pdCBvZiBtZWFzdXJlbWVudAAuAETCOgAA" +
           "AQB3A/////8BAf////8AAAAANWCJCgIAAAABAA4AAABNYXhUZW1wZXJhdHVyZQEBwzoDAAAAABkAAABN" +
           "YXggVGVtcGVyYXR1cmUgaW4gS2VsdmluAC8BAfk6wzoAAAEBzjr/////AQH/////AgAAADVgiQoCAAAA" +
           "AQAEAAAARGF0YQEBDjsDAAAAABEAAABWYWx1ZSBvZiBWYXJpYWJsZQAvAD8OOwAAAAr/////AQH/////" +
           "AAAAADVgiQoCAAAAAQAEAAAASW5mbwEBxToDAAAAACQAAABJbmZvcm1hdGlvbiBsaWtlIHVuaXQgb2Yg" +
           "bWVhc3VyZW1lbnQALgBExToAAAEAdwP/////AQH/////AAAAADVgiQoCAAAAAQAOAAAATWluVGVtcGVy" +
           "YXR1cmUBAcY6AwAAAAAZAAAATWluIFRlbXBlcmF0dXJlIGluIEtlbHZpbgAvAQH5OsY6AAABAc46////" +
           "/wEB/////wIAAAA1YIkKAgAAAAEABAAAAERhdGEBAQ87AwAAAAARAAAAVmFsdWUgb2YgVmFyaWFibGUA" +
           "LwA/DzsAAAAK/////wEB/////wAAAAA1YIkKAgAAAAEABAAAAEluZm8BAcg6AwAAAAAkAAAASW5mb3Jt" +
           "YXRpb24gbGlrZSB1bml0IG9mIG1lYXN1cmVtZW50AC4ARMg6AAABAHcD/////wEB/////wAAAAA1YIkK" +
           "AgAAAAEACAAAAFByZXNzdXJlAQHJOgMAAAAAEgAAAFByZXNzdXJlIGluIFBhc2NhbAAvAQH5Osk6AAAB" +
           "Ac46/////wEB/////wIAAAA1YIkKAgAAAAEABAAAAERhdGEBARA7AwAAAAARAAAAVmFsdWUgb2YgVmFy" +
           "aWFibGUALwA/EDsAAAAK/////wEB/////wAAAAA1YIkKAgAAAAEABAAAAEluZm8BAcs6AwAAAAAkAAAA" +
           "SW5mb3JtYXRpb24gbGlrZSB1bml0IG9mIG1lYXN1cmVtZW50AC4ARMs6AAABAHcD/////wEB/////wAA" +
           "AAA1YIkKAgAAAAEABAAAAENpdHkBAcw6AwAAAAAZAAAAQ2l0eSBvZiB3ZWF0aGVyIHByZXZpc2lvbgAv" +
           "AD/MOgAAAAz/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public WeatherMapVariableState WeatherMap
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
                                WeatherMap = new WeatherMapVariableState(this);
                            }
                            else
                            {
                                WeatherMap = (WeatherMapVariableState)replacement;
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
        private WeatherMapVariableState m_weatherMap;
        #endregion
    }
    #endif
    #endregion

    #region WeatherMapVariableState Class
    #if (!OPCUA_EXCLUDE_WeatherMapVariableState)
    /// <summary>
    /// Stores an instance of the WeatherMapVariableType VariableType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class WeatherMapVariableState : BaseDataVariableState<WeatherData>
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public WeatherMapVariableState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Quickstarts.MyOPCServer.VariableTypes.WeatherMapVariableType, Quickstarts.MyOPCServer.Namespaces.MyOPCServer, namespaceUris);
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
           "dGNvcmX/////FWCJAgIAAAABAB4AAABXZWF0aGVyTWFwVmFyaWFibGVUeXBlSW5zdGFuY2UBAc86AQHP" +
           "Os86AAABAc06/////wEB/////wYAAAA1YIkKAgAAAAEABAAAAERhdGUBAdA6AwAAAAAdAAAARGF0ZXRp" +
           "bWUgb2Ygd2VhdGhlciBwcmV2aXNpb24ALwA/0DoAAAAN/////wEB/////wAAAAA1YIkKAgAAAAEACwAA" +
           "AFRlbXBlcmF0dXJlAQHROgMAAAAAFQAAAFRlbXBlcmF0dXJlIGluIEtlbHZpbgAvAQH5OtE6AAABAc46" +
           "/////wEB/////wIAAAA1YIkKAgAAAAEABAAAAERhdGEBARE7AwAAAAARAAAAVmFsdWUgb2YgVmFyaWFi" +
           "bGUALwA/ETsAAAAK/////wEB/////wAAAAA1YIkKAgAAAAEABAAAAEluZm8BAdM6AwAAAAAkAAAASW5m" +
           "b3JtYXRpb24gbGlrZSB1bml0IG9mIG1lYXN1cmVtZW50AC4ARNM6AAABAHcD/////wEB/////wAAAAA1" +
           "YIkKAgAAAAEADgAAAE1heFRlbXBlcmF0dXJlAQHvOgMAAAAAGQAAAE1heCBUZW1wZXJhdHVyZSBpbiBL" +
           "ZWx2aW4ALwEB+TrvOgAAAQHOOv////8BAf////8CAAAANWCJCgIAAAABAAQAAABEYXRhAQESOwMAAAAA" +
           "EQAAAFZhbHVlIG9mIFZhcmlhYmxlAC8APxI7AAAACv////8BAf////8AAAAANWCJCgIAAAABAAQAAABJ" +
           "bmZvAQHxOgMAAAAAJAAAAEluZm9ybWF0aW9uIGxpa2UgdW5pdCBvZiBtZWFzdXJlbWVudAAuAETxOgAA" +
           "AQB3A/////8BAf////8AAAAANWCJCgIAAAABAA4AAABNaW5UZW1wZXJhdHVyZQEB8joDAAAAABkAAABN" +
           "aW4gVGVtcGVyYXR1cmUgaW4gS2VsdmluAC8BAfk68joAAAEBzjr/////AQH/////AgAAADVgiQoCAAAA" +
           "AQAEAAAARGF0YQEBEzsDAAAAABEAAABWYWx1ZSBvZiBWYXJpYWJsZQAvAD8TOwAAAAr/////AQH/////" +
           "AAAAADVgiQoCAAAAAQAEAAAASW5mbwEB9DoDAAAAACQAAABJbmZvcm1hdGlvbiBsaWtlIHVuaXQgb2Yg" +
           "bWVhc3VyZW1lbnQALgBE9DoAAAEAdwP/////AQH/////AAAAADVgiQoCAAAAAQAIAAAAUHJlc3N1cmUB" +
           "AfU6AwAAAAASAAAAUHJlc3N1cmUgaW4gUGFzY2FsAC8BAfk69ToAAAEBzjr/////AQH/////AgAAADVg" +
           "iQoCAAAAAQAEAAAARGF0YQEBFDsDAAAAABEAAABWYWx1ZSBvZiBWYXJpYWJsZQAvAD8UOwAAAAr/////" +
           "AQH/////AAAAADVgiQoCAAAAAQAEAAAASW5mbwEB9zoDAAAAACQAAABJbmZvcm1hdGlvbiBsaWtlIHVu" +
           "aXQgb2YgbWVhc3VyZW1lbnQALgBE9zoAAAEAdwP/////AQH/////AAAAADVgiQoCAAAAAQAEAAAAQ2l0" +
           "eQEB+DoDAAAAABkAAABDaXR5IG9mIHdlYXRoZXIgcHJldmlzaW9uAC8AP/g6AAAADP////8BAf////8A" +
           "AAAA";
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
        public AnalogVariableState Temperature
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
        public AnalogVariableState MaxTemperature
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
        public AnalogVariableState MinTemperature
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
        public AnalogVariableState Pressure
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
                                Temperature = new AnalogVariableState(this);
                            }
                            else
                            {
                                Temperature = (AnalogVariableState)replacement;
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
                                MaxTemperature = new AnalogVariableState(this);
                            }
                            else
                            {
                                MaxTemperature = (AnalogVariableState)replacement;
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
                                MinTemperature = new AnalogVariableState(this);
                            }
                            else
                            {
                                MinTemperature = (AnalogVariableState)replacement;
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
                                Pressure = new AnalogVariableState(this);
                            }
                            else
                            {
                                Pressure = (AnalogVariableState)replacement;
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
        private AnalogVariableState m_temperature;
        private AnalogVariableState m_maxTemperature;
        private AnalogVariableState m_minTemperature;
        private AnalogVariableState m_pressure;
        private BaseDataVariableState<string> m_city;
        #endregion
    }

    #region WeatherMapVariableValue Class
    /// <summary>
    /// A typed version of the _BrowseName_ variable.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public class WeatherMapVariableValue : BaseVariableValue
    {
        #region Constructors
        /// <summary>
        /// Initializes the instance with its defalt attribute values.
        /// </summary>
        public WeatherMapVariableValue(WeatherMapVariableState variable, WeatherData value, object dataLock) : base(dataLock)
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
        public WeatherMapVariableState Variable
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
        private void Initialize(WeatherMapVariableState variable)
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

                instance = m_variable.Temperature;
                instance.OnReadValue = OnRead_Temperature;
                instance.OnSimpleWriteValue = OnWrite_Temperature;
                updateList.Add(instance);
                instance = m_variable.Temperature.Data;
                instance.OnReadValue = OnRead_Temperature_Data;
                instance.OnSimpleWriteValue = OnWrite_Temperature_Data;
                updateList.Add(instance);
                instance = m_variable.Temperature.Info;
                instance.OnReadValue = OnRead_Temperature_Info;
                instance.OnSimpleWriteValue = OnWrite_Temperature_Info;
                updateList.Add(instance);
                instance = m_variable.MaxTemperature;
                instance.OnReadValue = OnRead_MaxTemperature;
                instance.OnSimpleWriteValue = OnWrite_MaxTemperature;
                updateList.Add(instance);
                instance = m_variable.MaxTemperature.Data;
                instance.OnReadValue = OnRead_MaxTemperature_Data;
                instance.OnSimpleWriteValue = OnWrite_MaxTemperature_Data;
                updateList.Add(instance);
                instance = m_variable.MaxTemperature.Info;
                instance.OnReadValue = OnRead_MaxTemperature_Info;
                instance.OnSimpleWriteValue = OnWrite_MaxTemperature_Info;
                updateList.Add(instance);
                instance = m_variable.MinTemperature;
                instance.OnReadValue = OnRead_MinTemperature;
                instance.OnSimpleWriteValue = OnWrite_MinTemperature;
                updateList.Add(instance);
                instance = m_variable.MinTemperature.Data;
                instance.OnReadValue = OnRead_MinTemperature_Data;
                instance.OnSimpleWriteValue = OnWrite_MinTemperature_Data;
                updateList.Add(instance);
                instance = m_variable.MinTemperature.Info;
                instance.OnReadValue = OnRead_MinTemperature_Info;
                instance.OnSimpleWriteValue = OnWrite_MinTemperature_Info;
                updateList.Add(instance);
                instance = m_variable.Pressure;
                instance.OnReadValue = OnRead_Pressure;
                instance.OnSimpleWriteValue = OnWrite_Pressure;
                updateList.Add(instance);
                instance = m_variable.Pressure.Data;
                instance.OnReadValue = OnRead_Pressure_Data;
                instance.OnSimpleWriteValue = OnWrite_Pressure_Data;
                updateList.Add(instance);
                instance = m_variable.Pressure.Info;
                instance.OnReadValue = OnRead_Pressure_Info;
                instance.OnSimpleWriteValue = OnWrite_Pressure_Info;
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

        #region Temperature_Data Access Methods
        /// <summary>
        /// Reads the value of the variable child.
        /// </summary>
        private ServiceResult OnRead_Temperature_Data(
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
                    value = m_value.Temperature.Data;
                }

                return Read(context, node, indexRange, dataEncoding, ref value, ref statusCode, ref timestamp);
            }
        }

        /// <summary>
        /// Writes the value of the variable child.
        /// </summary>
        private ServiceResult OnWrite_Temperature_Data(ISystemContext context, NodeState node, ref object value)
        {
            lock (Lock)
            {
                m_value.Temperature.Data = (float)Write(value);
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

        #region MaxTemperature_Data Access Methods
        /// <summary>
        /// Reads the value of the variable child.
        /// </summary>
        private ServiceResult OnRead_MaxTemperature_Data(
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
                    value = m_value.MaxTemperature.Data;
                }

                return Read(context, node, indexRange, dataEncoding, ref value, ref statusCode, ref timestamp);
            }
        }

        /// <summary>
        /// Writes the value of the variable child.
        /// </summary>
        private ServiceResult OnWrite_MaxTemperature_Data(ISystemContext context, NodeState node, ref object value)
        {
            lock (Lock)
            {
                m_value.MaxTemperature.Data = (float)Write(value);
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

        #region MinTemperature_Data Access Methods
        /// <summary>
        /// Reads the value of the variable child.
        /// </summary>
        private ServiceResult OnRead_MinTemperature_Data(
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
                    value = m_value.MinTemperature.Data;
                }

                return Read(context, node, indexRange, dataEncoding, ref value, ref statusCode, ref timestamp);
            }
        }

        /// <summary>
        /// Writes the value of the variable child.
        /// </summary>
        private ServiceResult OnWrite_MinTemperature_Data(ISystemContext context, NodeState node, ref object value)
        {
            lock (Lock)
            {
                m_value.MinTemperature.Data = (float)Write(value);
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

        #region Pressure_Data Access Methods
        /// <summary>
        /// Reads the value of the variable child.
        /// </summary>
        private ServiceResult OnRead_Pressure_Data(
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
                    value = m_value.Pressure.Data;
                }

                return Read(context, node, indexRange, dataEncoding, ref value, ref statusCode, ref timestamp);
            }
        }

        /// <summary>
        /// Writes the value of the variable child.
        /// </summary>
        private ServiceResult OnWrite_Pressure_Data(ISystemContext context, NodeState node, ref object value)
        {
            lock (Lock)
            {
                m_value.Pressure.Data = (float)Write(value);
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
        #endregion

        #region Private Fields
        private WeatherData m_value;
        private WeatherMapVariableState m_variable;
        #endregion
    }
    #endregion
    #endif
    #endregion

    #region AnalogVariableState Class
    #if (!OPCUA_EXCLUDE_AnalogVariableState)
    /// <summary>
    /// Stores an instance of the AnalogVariableType VariableType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class AnalogVariableState : BaseDataVariableState<AnalogData>
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public AnalogVariableState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Quickstarts.MyOPCServer.VariableTypes.AnalogVariableType, Quickstarts.MyOPCServer.Namespaces.MyOPCServer, namespaceUris);
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
           "dGNvcmX/////FWCJAgIAAAABABoAAABBbmFsb2dWYXJpYWJsZVR5cGVJbnN0YW5jZQEB+ToBAfk6+ToA" +
           "AAEBzjr/////AQH/////AgAAADVgiQoCAAAAAQAEAAAARGF0YQEBFTsDAAAAABEAAABWYWx1ZSBvZiBW" +
           "YXJpYWJsZQAvAD8VOwAAAAr/////AQH/////AAAAADVgiQoCAAAAAQAEAAAASW5mbwEB+zoDAAAAACQA" +
           "AABJbmZvcm1hdGlvbiBsaWtlIHVuaXQgb2YgbWVhc3VyZW1lbnQALgBE+zoAAAEAdwP/////AQH/////" +
           "AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public BaseDataVariableState<float> Data
        {
            get
            {
                return m_data;
            }

            set
            {
                if (!Object.ReferenceEquals(m_data, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_data = value;
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
            if (m_data != null)
            {
                children.Add(m_data);
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
                case Quickstarts.MyOPCServer.BrowseNames.Data:
                {
                    if (createOrReplace)
                    {
                        if (Data == null)
                        {
                            if (replacement == null)
                            {
                                Data = new BaseDataVariableState<float>(this);
                            }
                            else
                            {
                                Data = (BaseDataVariableState<float>)replacement;
                            }
                        }
                    }

                    instance = Data;
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
        private BaseDataVariableState<float> m_data;
        private PropertyState<EUInformation> m_info;
        #endregion
    }

    #region AnalogVariableValue Class
    /// <summary>
    /// A typed version of the _BrowseName_ variable.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public class AnalogVariableValue : BaseVariableValue
    {
        #region Constructors
        /// <summary>
        /// Initializes the instance with its defalt attribute values.
        /// </summary>
        public AnalogVariableValue(AnalogVariableState variable, AnalogData value, object dataLock) : base(dataLock)
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
        public AnalogVariableState Variable
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
        private void Initialize(AnalogVariableState variable)
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

                instance = m_variable.Data;
                instance.OnReadValue = OnRead_Data;
                instance.OnSimpleWriteValue = OnWrite_Data;
                updateList.Add(instance);
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

        #region Data Access Methods
        /// <summary>
        /// Reads the value of the variable child.
        /// </summary>
        private ServiceResult OnRead_Data(
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
                    value = m_value.Data;
                }

                return Read(context, node, indexRange, dataEncoding, ref value, ref statusCode, ref timestamp);
            }
        }

        /// <summary>
        /// Writes the value of the variable child.
        /// </summary>
        private ServiceResult OnWrite_Data(ISystemContext context, NodeState node, ref object value)
        {
            lock (Lock)
            {
                m_value.Data = (float)Write(value);
            }

            return ServiceResult.Good;
        }
        #endregion

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
        private AnalogVariableState m_variable;
        #endregion
    }
    #endregion
    #endif
    #endregion
}
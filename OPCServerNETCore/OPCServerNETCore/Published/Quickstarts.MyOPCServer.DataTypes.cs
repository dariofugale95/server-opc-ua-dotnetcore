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
    #region WeatherData Class
    #if (!OPCUA_EXCLUDE_WeatherData)
    /// <summary>
    /// Information about waether in a specific city
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = Quickstarts.MyOPCServer.Namespaces.MyOPCServer)]
    public partial class WeatherData : IEncodeable
    {
        #region Constructors
        /// <summary>
        /// The default constructor.
        /// </summary>
        public WeatherData()
        {
            Initialize();
        }

        /// <summary>
        /// Called by the .NET framework during deserialization.
        /// </summary>
        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }

        /// <summary>
        /// Sets private members to default values.
        /// </summary>
        private void Initialize()
        {
            m_temperature = new AnalogData();
            m_maxTemperature = new AnalogData();
            m_minTemperature = new AnalogData();
            m_pressure = new AnalogData();
            m_cityName = null;
        }
        #endregion

        #region Public Properties
        /// <summary>
        /// 
        /// </summary>
        [DataMember(Name = "Temperature", IsRequired = false, Order = 1)]
        public AnalogData Temperature
        {
            get
            {
                return m_temperature;
            }

            set
            {
                m_temperature = value;

                if (value == null)
                {
                    m_temperature = new AnalogData();
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [DataMember(Name = "MaxTemperature", IsRequired = false, Order = 2)]
        public AnalogData MaxTemperature
        {
            get
            {
                return m_maxTemperature;
            }

            set
            {
                m_maxTemperature = value;

                if (value == null)
                {
                    m_maxTemperature = new AnalogData();
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [DataMember(Name = "MinTemperature", IsRequired = false, Order = 3)]
        public AnalogData MinTemperature
        {
            get
            {
                return m_minTemperature;
            }

            set
            {
                m_minTemperature = value;

                if (value == null)
                {
                    m_minTemperature = new AnalogData();
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [DataMember(Name = "Pressure", IsRequired = false, Order = 4)]
        public AnalogData Pressure
        {
            get
            {
                return m_pressure;
            }

            set
            {
                m_pressure = value;

                if (value == null)
                {
                    m_pressure = new AnalogData();
                }
            }
        }

        /// <remarks />
        [DataMember(Name = "CityName", IsRequired = false, Order = 5)]
        public string CityName
        {
            get { return m_cityName;  }
            set { m_cityName = value; }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public virtual ExpandedNodeId TypeId
        {
            get { return DataTypeIds.WeatherData; }
        }

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public virtual ExpandedNodeId BinaryEncodingId
        {
            get { return ObjectIds.WeatherData_Encoding_DefaultBinary; }
        }

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public virtual ExpandedNodeId XmlEncodingId
        {
            get { return ObjectIds.WeatherData_Encoding_DefaultXml; }
        }

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public virtual void Encode(IEncoder encoder)
        {
            encoder.PushNamespace(Quickstarts.MyOPCServer.Namespaces.MyOPCServer);

            encoder.WriteEncodeable("Temperature", Temperature, typeof(AnalogData));
            encoder.WriteEncodeable("MaxTemperature", MaxTemperature, typeof(AnalogData));
            encoder.WriteEncodeable("MinTemperature", MinTemperature, typeof(AnalogData));
            encoder.WriteEncodeable("Pressure", Pressure, typeof(AnalogData));
            encoder.WriteString("CityName", CityName);

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public virtual void Decode(IDecoder decoder)
        {
            decoder.PushNamespace(Quickstarts.MyOPCServer.Namespaces.MyOPCServer);

            Temperature = (AnalogData)decoder.ReadEncodeable("Temperature", typeof(AnalogData));
            MaxTemperature = (AnalogData)decoder.ReadEncodeable("MaxTemperature", typeof(AnalogData));
            MinTemperature = (AnalogData)decoder.ReadEncodeable("MinTemperature", typeof(AnalogData));
            Pressure = (AnalogData)decoder.ReadEncodeable("Pressure", typeof(AnalogData));
            CityName = decoder.ReadString("CityName");

            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public virtual bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            WeatherData value = encodeable as WeatherData;

            if (value == null)
            {
                return false;
            }

            if (!Utils.IsEqual(m_temperature, value.m_temperature)) return false;
            if (!Utils.IsEqual(m_maxTemperature, value.m_maxTemperature)) return false;
            if (!Utils.IsEqual(m_minTemperature, value.m_minTemperature)) return false;
            if (!Utils.IsEqual(m_pressure, value.m_pressure)) return false;
            if (!Utils.IsEqual(m_cityName, value.m_cityName)) return false;

            return true;
        }

        #if !NET_STANDARD
        /// <summary cref="ICloneable.Clone" />
        public virtual object Clone()
        {
            return (WeatherData)this.MemberwiseClone();
        }
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            WeatherData clone = (WeatherData)base.MemberwiseClone();

            clone.m_temperature = (AnalogData)Utils.Clone(this.m_temperature);
            clone.m_maxTemperature = (AnalogData)Utils.Clone(this.m_maxTemperature);
            clone.m_minTemperature = (AnalogData)Utils.Clone(this.m_minTemperature);
            clone.m_pressure = (AnalogData)Utils.Clone(this.m_pressure);
            clone.m_cityName = (string)Utils.Clone(this.m_cityName);

            return clone;
        }
        #endregion

        #region Private Fields
        private AnalogData m_temperature;
        private AnalogData m_maxTemperature;
        private AnalogData m_minTemperature;
        private AnalogData m_pressure;
        private string m_cityName;
        #endregion
    }

    #region WeatherDataCollection Class
    /// <summary>
    /// A collection of WeatherData objects.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfWeatherData", Namespace = Quickstarts.MyOPCServer.Namespaces.MyOPCServer, ItemName = "WeatherData")]
    #if !NET_STANDARD
    public partial class WeatherDataCollection : List<WeatherData>, ICloneable
    #else
    public partial class WeatherDataCollection : List<WeatherData>
    #endif
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public WeatherDataCollection() {}

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public WeatherDataCollection(int capacity) : base(capacity) {}

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public WeatherDataCollection(IEnumerable<WeatherData> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator WeatherDataCollection(WeatherData[] values)
        {
            if (values != null)
            {
                return new WeatherDataCollection(values);
            }

            return new WeatherDataCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator WeatherData[](WeatherDataCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <summary>
        /// Creates a deep copy of the collection.
        /// </summary>
        public object Clone()
        {
            return (WeatherDataCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            WeatherDataCollection clone = new WeatherDataCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((WeatherData)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region AnalogData Class
    #if (!OPCUA_EXCLUDE_AnalogData)
    /// <summary>
    /// Data type for Analogic Data
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = Quickstarts.MyOPCServer.Namespaces.MyOPCServer)]
    public partial class AnalogData : IEncodeable
    {
        #region Constructors
        /// <summary>
        /// The default constructor.
        /// </summary>
        public AnalogData()
        {
            Initialize();
        }

        /// <summary>
        /// Called by the .NET framework during deserialization.
        /// </summary>
        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }

        /// <summary>
        /// Sets private members to default values.
        /// </summary>
        private void Initialize()
        {
            m_data = (float)0;
            m_info = new EUInformation();
        }
        #endregion

        #region Public Properties
        /// <remarks />
        [DataMember(Name = "Data", IsRequired = false, Order = 1)]
        public float Data
        {
            get { return m_data;  }
            set { m_data = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        [DataMember(Name = "Info", IsRequired = false, Order = 2)]
        public EUInformation Info
        {
            get
            {
                return m_info;
            }

            set
            {
                m_info = value;

                if (value == null)
                {
                    m_info = new EUInformation();
                }
            }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public virtual ExpandedNodeId TypeId
        {
            get { return DataTypeIds.AnalogData; }
        }

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public virtual ExpandedNodeId BinaryEncodingId
        {
            get { return ObjectIds.AnalogData_Encoding_DefaultBinary; }
        }

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public virtual ExpandedNodeId XmlEncodingId
        {
            get { return ObjectIds.AnalogData_Encoding_DefaultXml; }
        }

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public virtual void Encode(IEncoder encoder)
        {
            encoder.PushNamespace(Quickstarts.MyOPCServer.Namespaces.MyOPCServer);

            encoder.WriteFloat("Data", Data);
            encoder.WriteEncodeable("Info", Info, typeof(EUInformation));

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public virtual void Decode(IDecoder decoder)
        {
            decoder.PushNamespace(Quickstarts.MyOPCServer.Namespaces.MyOPCServer);

            Data = decoder.ReadFloat("Data");
            Info = (EUInformation)decoder.ReadEncodeable("Info", typeof(EUInformation));

            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public virtual bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            AnalogData value = encodeable as AnalogData;

            if (value == null)
            {
                return false;
            }

            if (!Utils.IsEqual(m_data, value.m_data)) return false;
            if (!Utils.IsEqual(m_info, value.m_info)) return false;

            return true;
        }

        #if !NET_STANDARD
        /// <summary cref="ICloneable.Clone" />
        public virtual object Clone()
        {
            return (AnalogData)this.MemberwiseClone();
        }
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            AnalogData clone = (AnalogData)base.MemberwiseClone();

            clone.m_data = (float)Utils.Clone(this.m_data);
            clone.m_info = (EUInformation)Utils.Clone(this.m_info);

            return clone;
        }
        #endregion

        #region Private Fields
        private float m_data;
        private EUInformation m_info;
        #endregion
    }

    #region AnalogDataCollection Class
    /// <summary>
    /// A collection of AnalogData objects.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfAnalogData", Namespace = Quickstarts.MyOPCServer.Namespaces.MyOPCServer, ItemName = "AnalogData")]
    #if !NET_STANDARD
    public partial class AnalogDataCollection : List<AnalogData>, ICloneable
    #else
    public partial class AnalogDataCollection : List<AnalogData>
    #endif
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public AnalogDataCollection() {}

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public AnalogDataCollection(int capacity) : base(capacity) {}

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public AnalogDataCollection(IEnumerable<AnalogData> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator AnalogDataCollection(AnalogData[] values)
        {
            if (values != null)
            {
                return new AnalogDataCollection(values);
            }

            return new AnalogDataCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator AnalogData[](AnalogDataCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <summary>
        /// Creates a deep copy of the collection.
        /// </summary>
        public object Clone()
        {
            return (AnalogDataCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            AnalogDataCollection clone = new AnalogDataCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((AnalogData)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion
}
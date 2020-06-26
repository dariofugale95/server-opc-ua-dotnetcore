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
            m_date = DateTime.MinValue;
            m_temperature = (float)0;
            m_maxTemperature = (float)0;
            m_minTemperature = (float)0;
            m_pressure = (float)0;
            m_city = null;
        }
        #endregion

        #region Public Properties
        /// <remarks />
        [DataMember(Name = "Date", IsRequired = false, Order = 1)]
        public DateTime Date
        {
            get { return m_date;  }
            set { m_date = value; }
        }

        /// <remarks />
        [DataMember(Name = "Temperature", IsRequired = false, Order = 2)]
        public float Temperature
        {
            get { return m_temperature;  }
            set { m_temperature = value; }
        }

        /// <remarks />
        [DataMember(Name = "MaxTemperature", IsRequired = false, Order = 3)]
        public float MaxTemperature
        {
            get { return m_maxTemperature;  }
            set { m_maxTemperature = value; }
        }

        /// <remarks />
        [DataMember(Name = "MinTemperature", IsRequired = false, Order = 4)]
        public float MinTemperature
        {
            get { return m_minTemperature;  }
            set { m_minTemperature = value; }
        }

        /// <remarks />
        [DataMember(Name = "Pressure", IsRequired = false, Order = 5)]
        public float Pressure
        {
            get { return m_pressure;  }
            set { m_pressure = value; }
        }

        /// <remarks />
        [DataMember(Name = "City", IsRequired = false, Order = 6)]
        public string City
        {
            get { return m_city;  }
            set { m_city = value; }
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

            encoder.WriteDateTime("Date", Date);
            encoder.WriteFloat("Temperature", Temperature);
            encoder.WriteFloat("MaxTemperature", MaxTemperature);
            encoder.WriteFloat("MinTemperature", MinTemperature);
            encoder.WriteFloat("Pressure", Pressure);
            encoder.WriteString("City", City);

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public virtual void Decode(IDecoder decoder)
        {
            decoder.PushNamespace(Quickstarts.MyOPCServer.Namespaces.MyOPCServer);

            Date = decoder.ReadDateTime("Date");
            Temperature = decoder.ReadFloat("Temperature");
            MaxTemperature = decoder.ReadFloat("MaxTemperature");
            MinTemperature = decoder.ReadFloat("MinTemperature");
            Pressure = decoder.ReadFloat("Pressure");
            City = decoder.ReadString("City");

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

            if (!Utils.IsEqual(m_date, value.m_date)) return false;
            if (!Utils.IsEqual(m_temperature, value.m_temperature)) return false;
            if (!Utils.IsEqual(m_maxTemperature, value.m_maxTemperature)) return false;
            if (!Utils.IsEqual(m_minTemperature, value.m_minTemperature)) return false;
            if (!Utils.IsEqual(m_pressure, value.m_pressure)) return false;
            if (!Utils.IsEqual(m_city, value.m_city)) return false;

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

            clone.m_date = (DateTime)Utils.Clone(this.m_date);
            clone.m_temperature = (float)Utils.Clone(this.m_temperature);
            clone.m_maxTemperature = (float)Utils.Clone(this.m_maxTemperature);
            clone.m_minTemperature = (float)Utils.Clone(this.m_minTemperature);
            clone.m_pressure = (float)Utils.Clone(this.m_pressure);
            clone.m_city = (string)Utils.Clone(this.m_city);

            return clone;
        }
        #endregion

        #region Private Fields
        private DateTime m_date;
        private float m_temperature;
        private float m_maxTemperature;
        private float m_minTemperature;
        private float m_pressure;
        private string m_city;
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
}
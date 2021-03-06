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
using System.Reflection;
using System.Xml;
using System.Runtime.Serialization;
using Opc.Ua;

namespace Quickstarts.MyOPCServer
{
    #region DataType Identifiers
    /// <summary>
    /// A class that declares constants for all DataTypes in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class DataTypes
    {
        /// <summary>
        /// The identifier for the WeatherData DataType.
        /// </summary>
        public const uint WeatherData = 15053;

        /// <summary>
        /// The identifier for the AnalogData DataType.
        /// </summary>
        public const uint AnalogData = 15054;
    }
    #endregion

    #region Method Identifiers
    /// <summary>
    /// A class that declares constants for all Methods in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Methods
    {
        /// <summary>
        /// The identifier for the OpenWeatherMapType_OpenWeatherMapMethod Method.
        /// </summary>
        public const uint OpenWeatherMapType_OpenWeatherMapMethod = 15003;

        /// <summary>
        /// The identifier for the OpenWeatherMap_OpenWeatherMapMethod Method.
        /// </summary>
        public const uint OpenWeatherMap_OpenWeatherMapMethod = 15024;
    }
    #endregion

    #region Object Identifiers
    /// <summary>
    /// A class that declares constants for all Objects in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Objects
    {
        /// <summary>
        /// The identifier for the WeatherAPISet Object.
        /// </summary>
        public const uint WeatherAPISet = 15002;

        /// <summary>
        /// The identifier for the OpenWeatherMap Object.
        /// </summary>
        public const uint OpenWeatherMap = 15022;

        /// <summary>
        /// The identifier for the WeatherData_Encoding_DefaultBinary Object.
        /// </summary>
        public const uint WeatherData_Encoding_DefaultBinary = 15060;

        /// <summary>
        /// The identifier for the AnalogData_Encoding_DefaultBinary Object.
        /// </summary>
        public const uint AnalogData_Encoding_DefaultBinary = 15061;

        /// <summary>
        /// The identifier for the WeatherData_Encoding_DefaultXml Object.
        /// </summary>
        public const uint WeatherData_Encoding_DefaultXml = 15072;

        /// <summary>
        /// The identifier for the AnalogData_Encoding_DefaultXml Object.
        /// </summary>
        public const uint AnalogData_Encoding_DefaultXml = 15073;

        /// <summary>
        /// The identifier for the WeatherData_Encoding_DefaultJson Object.
        /// </summary>
        public const uint WeatherData_Encoding_DefaultJson = 15084;

        /// <summary>
        /// The identifier for the AnalogData_Encoding_DefaultJson Object.
        /// </summary>
        public const uint AnalogData_Encoding_DefaultJson = 15085;
    }
    #endregion

    #region ObjectType Identifiers
    /// <summary>
    /// A class that declares constants for all ObjectTypes in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectTypes
    {
        /// <summary>
        /// The identifier for the OpenWeatherMapType ObjectType.
        /// </summary>
        public const uint OpenWeatherMapType = 15001;

        /// <summary>
        /// The identifier for the WeatherEventType ObjectType.
        /// </summary>
        public const uint WeatherEventType = 15007;
    }
    #endregion

    #region Variable Identifiers
    /// <summary>
    /// A class that declares constants for all Variables in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Variables
    {
        /// <summary>
        /// The identifier for the OpenWeatherMapType_CityName Variable.
        /// </summary>
        public const uint OpenWeatherMapType_CityName = 15086;

        /// <summary>
        /// The identifier for the OpenWeatherMapType_WeatherData Variable.
        /// </summary>
        public const uint OpenWeatherMapType_WeatherData = 15018;

        /// <summary>
        /// The identifier for the OpenWeatherMapType_WeatherData_Temperature Variable.
        /// </summary>
        public const uint OpenWeatherMapType_WeatherData_Temperature = 15020;

        /// <summary>
        /// The identifier for the OpenWeatherMapType_WeatherData_Temperature_Data Variable.
        /// </summary>
        public const uint OpenWeatherMapType_WeatherData_Temperature_Data = 15021;

        /// <summary>
        /// The identifier for the OpenWeatherMapType_WeatherData_Temperature_Info Variable.
        /// </summary>
        public const uint OpenWeatherMapType_WeatherData_Temperature_Info = 15026;

        /// <summary>
        /// The identifier for the OpenWeatherMapType_WeatherData_MaxTemperature Variable.
        /// </summary>
        public const uint OpenWeatherMapType_WeatherData_MaxTemperature = 15027;

        /// <summary>
        /// The identifier for the OpenWeatherMapType_WeatherData_MaxTemperature_Data Variable.
        /// </summary>
        public const uint OpenWeatherMapType_WeatherData_MaxTemperature_Data = 15028;

        /// <summary>
        /// The identifier for the OpenWeatherMapType_WeatherData_MaxTemperature_Info Variable.
        /// </summary>
        public const uint OpenWeatherMapType_WeatherData_MaxTemperature_Info = 15029;

        /// <summary>
        /// The identifier for the OpenWeatherMapType_WeatherData_MinTemperature Variable.
        /// </summary>
        public const uint OpenWeatherMapType_WeatherData_MinTemperature = 15030;

        /// <summary>
        /// The identifier for the OpenWeatherMapType_WeatherData_MinTemperature_Data Variable.
        /// </summary>
        public const uint OpenWeatherMapType_WeatherData_MinTemperature_Data = 15031;

        /// <summary>
        /// The identifier for the OpenWeatherMapType_WeatherData_MinTemperature_Info Variable.
        /// </summary>
        public const uint OpenWeatherMapType_WeatherData_MinTemperature_Info = 15032;

        /// <summary>
        /// The identifier for the OpenWeatherMapType_WeatherData_Pressure Variable.
        /// </summary>
        public const uint OpenWeatherMapType_WeatherData_Pressure = 15033;

        /// <summary>
        /// The identifier for the OpenWeatherMapType_WeatherData_Pressure_Data Variable.
        /// </summary>
        public const uint OpenWeatherMapType_WeatherData_Pressure_Data = 15034;

        /// <summary>
        /// The identifier for the OpenWeatherMapType_WeatherData_Pressure_Info Variable.
        /// </summary>
        public const uint OpenWeatherMapType_WeatherData_Pressure_Info = 15035;

        /// <summary>
        /// The identifier for the OpenWeatherMapType_WeatherData_City Variable.
        /// </summary>
        public const uint OpenWeatherMapType_WeatherData_City = 15038;

        /// <summary>
        /// The identifier for the OpenWeatherMapType_OpenWeatherMapMethod_InputArguments Variable.
        /// </summary>
        public const uint OpenWeatherMapType_OpenWeatherMapMethod_InputArguments = 15004;

        /// <summary>
        /// The identifier for the WeatherEventType_WeatherMap Variable.
        /// </summary>
        public const uint WeatherEventType_WeatherMap = 15017;

        /// <summary>
        /// The identifier for the WeatherEventType_WeatherMap_Temperature Variable.
        /// </summary>
        public const uint WeatherEventType_WeatherMap_Temperature = 15036;

        /// <summary>
        /// The identifier for the WeatherEventType_WeatherMap_Temperature_Data Variable.
        /// </summary>
        public const uint WeatherEventType_WeatherMap_Temperature_Data = 15037;

        /// <summary>
        /// The identifier for the WeatherEventType_WeatherMap_Temperature_Info Variable.
        /// </summary>
        public const uint WeatherEventType_WeatherMap_Temperature_Info = 15039;

        /// <summary>
        /// The identifier for the WeatherEventType_WeatherMap_MaxTemperature Variable.
        /// </summary>
        public const uint WeatherEventType_WeatherMap_MaxTemperature = 15040;

        /// <summary>
        /// The identifier for the WeatherEventType_WeatherMap_MaxTemperature_Data Variable.
        /// </summary>
        public const uint WeatherEventType_WeatherMap_MaxTemperature_Data = 15041;

        /// <summary>
        /// The identifier for the WeatherEventType_WeatherMap_MaxTemperature_Info Variable.
        /// </summary>
        public const uint WeatherEventType_WeatherMap_MaxTemperature_Info = 15042;

        /// <summary>
        /// The identifier for the WeatherEventType_WeatherMap_MinTemperature Variable.
        /// </summary>
        public const uint WeatherEventType_WeatherMap_MinTemperature = 15043;

        /// <summary>
        /// The identifier for the WeatherEventType_WeatherMap_MinTemperature_Data Variable.
        /// </summary>
        public const uint WeatherEventType_WeatherMap_MinTemperature_Data = 15044;

        /// <summary>
        /// The identifier for the WeatherEventType_WeatherMap_MinTemperature_Info Variable.
        /// </summary>
        public const uint WeatherEventType_WeatherMap_MinTemperature_Info = 15045;

        /// <summary>
        /// The identifier for the WeatherEventType_WeatherMap_Pressure Variable.
        /// </summary>
        public const uint WeatherEventType_WeatherMap_Pressure = 15046;

        /// <summary>
        /// The identifier for the WeatherEventType_WeatherMap_Pressure_Data Variable.
        /// </summary>
        public const uint WeatherEventType_WeatherMap_Pressure_Data = 15047;

        /// <summary>
        /// The identifier for the WeatherEventType_WeatherMap_Pressure_Info Variable.
        /// </summary>
        public const uint WeatherEventType_WeatherMap_Pressure_Info = 15048;

        /// <summary>
        /// The identifier for the WeatherEventType_WeatherMap_City Variable.
        /// </summary>
        public const uint WeatherEventType_WeatherMap_City = 15052;

        /// <summary>
        /// The identifier for the WeatherMapVariableType_Temperature Variable.
        /// </summary>
        public const uint WeatherMapVariableType_Temperature = 15049;

        /// <summary>
        /// The identifier for the WeatherMapVariableType_Temperature_Data Variable.
        /// </summary>
        public const uint WeatherMapVariableType_Temperature_Data = 15050;

        /// <summary>
        /// The identifier for the WeatherMapVariableType_Temperature_Info Variable.
        /// </summary>
        public const uint WeatherMapVariableType_Temperature_Info = 15051;

        /// <summary>
        /// The identifier for the WeatherMapVariableType_MaxTemperature Variable.
        /// </summary>
        public const uint WeatherMapVariableType_MaxTemperature = 15056;

        /// <summary>
        /// The identifier for the WeatherMapVariableType_MaxTemperature_Data Variable.
        /// </summary>
        public const uint WeatherMapVariableType_MaxTemperature_Data = 15057;

        /// <summary>
        /// The identifier for the WeatherMapVariableType_MaxTemperature_Info Variable.
        /// </summary>
        public const uint WeatherMapVariableType_MaxTemperature_Info = 15058;

        /// <summary>
        /// The identifier for the WeatherMapVariableType_MinTemperature Variable.
        /// </summary>
        public const uint WeatherMapVariableType_MinTemperature = 15059;

        /// <summary>
        /// The identifier for the WeatherMapVariableType_MinTemperature_Data Variable.
        /// </summary>
        public const uint WeatherMapVariableType_MinTemperature_Data = 15087;

        /// <summary>
        /// The identifier for the WeatherMapVariableType_MinTemperature_Info Variable.
        /// </summary>
        public const uint WeatherMapVariableType_MinTemperature_Info = 15088;

        /// <summary>
        /// The identifier for the WeatherMapVariableType_Pressure Variable.
        /// </summary>
        public const uint WeatherMapVariableType_Pressure = 15089;

        /// <summary>
        /// The identifier for the WeatherMapVariableType_Pressure_Data Variable.
        /// </summary>
        public const uint WeatherMapVariableType_Pressure_Data = 15090;

        /// <summary>
        /// The identifier for the WeatherMapVariableType_Pressure_Info Variable.
        /// </summary>
        public const uint WeatherMapVariableType_Pressure_Info = 15091;

        /// <summary>
        /// The identifier for the WeatherMapVariableType_City Variable.
        /// </summary>
        public const uint WeatherMapVariableType_City = 15096;

        /// <summary>
        /// The identifier for the AnalogVariableType_Data Variable.
        /// </summary>
        public const uint AnalogVariableType_Data = 15125;

        /// <summary>
        /// The identifier for the AnalogVariableType_Info Variable.
        /// </summary>
        public const uint AnalogVariableType_Info = 15099;

        /// <summary>
        /// The identifier for the OpenWeatherMap_CityName Variable.
        /// </summary>
        public const uint OpenWeatherMap_CityName = 15023;

        /// <summary>
        /// The identifier for the OpenWeatherMap_WeatherData Variable.
        /// </summary>
        public const uint OpenWeatherMap_WeatherData = 15019;

        /// <summary>
        /// The identifier for the OpenWeatherMap_WeatherData_Temperature Variable.
        /// </summary>
        public const uint OpenWeatherMap_WeatherData_Temperature = 15092;

        /// <summary>
        /// The identifier for the OpenWeatherMap_WeatherData_Temperature_Data Variable.
        /// </summary>
        public const uint OpenWeatherMap_WeatherData_Temperature_Data = 15093;

        /// <summary>
        /// The identifier for the OpenWeatherMap_WeatherData_Temperature_Info Variable.
        /// </summary>
        public const uint OpenWeatherMap_WeatherData_Temperature_Info = 15094;

        /// <summary>
        /// The identifier for the OpenWeatherMap_WeatherData_MaxTemperature Variable.
        /// </summary>
        public const uint OpenWeatherMap_WeatherData_MaxTemperature = 15095;

        /// <summary>
        /// The identifier for the OpenWeatherMap_WeatherData_MaxTemperature_Data Variable.
        /// </summary>
        public const uint OpenWeatherMap_WeatherData_MaxTemperature_Data = 15098;

        /// <summary>
        /// The identifier for the OpenWeatherMap_WeatherData_MaxTemperature_Info Variable.
        /// </summary>
        public const uint OpenWeatherMap_WeatherData_MaxTemperature_Info = 15100;

        /// <summary>
        /// The identifier for the OpenWeatherMap_WeatherData_MinTemperature Variable.
        /// </summary>
        public const uint OpenWeatherMap_WeatherData_MinTemperature = 15101;

        /// <summary>
        /// The identifier for the OpenWeatherMap_WeatherData_MinTemperature_Data Variable.
        /// </summary>
        public const uint OpenWeatherMap_WeatherData_MinTemperature_Data = 15102;

        /// <summary>
        /// The identifier for the OpenWeatherMap_WeatherData_MinTemperature_Info Variable.
        /// </summary>
        public const uint OpenWeatherMap_WeatherData_MinTemperature_Info = 15103;

        /// <summary>
        /// The identifier for the OpenWeatherMap_WeatherData_Pressure Variable.
        /// </summary>
        public const uint OpenWeatherMap_WeatherData_Pressure = 15104;

        /// <summary>
        /// The identifier for the OpenWeatherMap_WeatherData_Pressure_Data Variable.
        /// </summary>
        public const uint OpenWeatherMap_WeatherData_Pressure_Data = 15105;

        /// <summary>
        /// The identifier for the OpenWeatherMap_WeatherData_Pressure_Info Variable.
        /// </summary>
        public const uint OpenWeatherMap_WeatherData_Pressure_Info = 15106;

        /// <summary>
        /// The identifier for the OpenWeatherMap_WeatherData_City Variable.
        /// </summary>
        public const uint OpenWeatherMap_WeatherData_City = 15113;

        /// <summary>
        /// The identifier for the OpenWeatherMap_OpenWeatherMapMethod_InputArguments Variable.
        /// </summary>
        public const uint OpenWeatherMap_OpenWeatherMapMethod_InputArguments = 15025;

        /// <summary>
        /// The identifier for the MyOPCServer_BinarySchema Variable.
        /// </summary>
        public const uint MyOPCServer_BinarySchema = 15062;

        /// <summary>
        /// The identifier for the MyOPCServer_BinarySchema_NamespaceUri Variable.
        /// </summary>
        public const uint MyOPCServer_BinarySchema_NamespaceUri = 15064;

        /// <summary>
        /// The identifier for the MyOPCServer_BinarySchema_Deprecated Variable.
        /// </summary>
        public const uint MyOPCServer_BinarySchema_Deprecated = 15065;

        /// <summary>
        /// The identifier for the MyOPCServer_BinarySchema_WeatherData Variable.
        /// </summary>
        public const uint MyOPCServer_BinarySchema_WeatherData = 15066;

        /// <summary>
        /// The identifier for the MyOPCServer_BinarySchema_AnalogData Variable.
        /// </summary>
        public const uint MyOPCServer_BinarySchema_AnalogData = 15069;

        /// <summary>
        /// The identifier for the MyOPCServer_XmlSchema Variable.
        /// </summary>
        public const uint MyOPCServer_XmlSchema = 15074;

        /// <summary>
        /// The identifier for the MyOPCServer_XmlSchema_NamespaceUri Variable.
        /// </summary>
        public const uint MyOPCServer_XmlSchema_NamespaceUri = 15076;

        /// <summary>
        /// The identifier for the MyOPCServer_XmlSchema_Deprecated Variable.
        /// </summary>
        public const uint MyOPCServer_XmlSchema_Deprecated = 15077;

        /// <summary>
        /// The identifier for the MyOPCServer_XmlSchema_WeatherData Variable.
        /// </summary>
        public const uint MyOPCServer_XmlSchema_WeatherData = 15078;

        /// <summary>
        /// The identifier for the MyOPCServer_XmlSchema_AnalogData Variable.
        /// </summary>
        public const uint MyOPCServer_XmlSchema_AnalogData = 15081;
    }
    #endregion

    #region VariableType Identifiers
    /// <summary>
    /// A class that declares constants for all VariableTypes in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class VariableTypes
    {
        /// <summary>
        /// The identifier for the WeatherMapVariableType VariableType.
        /// </summary>
        public const uint WeatherMapVariableType = 15055;

        /// <summary>
        /// The identifier for the AnalogVariableType VariableType.
        /// </summary>
        public const uint AnalogVariableType = 15097;
    }
    #endregion

    #region DataType Node Identifiers
    /// <summary>
    /// A class that declares constants for all DataTypes in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class DataTypeIds
    {
        /// <summary>
        /// The identifier for the WeatherData DataType.
        /// </summary>
        public static readonly ExpandedNodeId WeatherData = new ExpandedNodeId(Quickstarts.MyOPCServer.DataTypes.WeatherData, Quickstarts.MyOPCServer.Namespaces.MyOPCServer);

        /// <summary>
        /// The identifier for the AnalogData DataType.
        /// </summary>
        public static readonly ExpandedNodeId AnalogData = new ExpandedNodeId(Quickstarts.MyOPCServer.DataTypes.AnalogData, Quickstarts.MyOPCServer.Namespaces.MyOPCServer);
    }
    #endregion

    #region Method Node Identifiers
    /// <summary>
    /// A class that declares constants for all Methods in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class MethodIds
    {
        /// <summary>
        /// The identifier for the OpenWeatherMapType_OpenWeatherMapMethod Method.
        /// </summary>
        public static readonly ExpandedNodeId OpenWeatherMapType_OpenWeatherMapMethod = new ExpandedNodeId(Quickstarts.MyOPCServer.Methods.OpenWeatherMapType_OpenWeatherMapMethod, Quickstarts.MyOPCServer.Namespaces.MyOPCServer);

        /// <summary>
        /// The identifier for the OpenWeatherMap_OpenWeatherMapMethod Method.
        /// </summary>
        public static readonly ExpandedNodeId OpenWeatherMap_OpenWeatherMapMethod = new ExpandedNodeId(Quickstarts.MyOPCServer.Methods.OpenWeatherMap_OpenWeatherMapMethod, Quickstarts.MyOPCServer.Namespaces.MyOPCServer);
    }
    #endregion

    #region Object Node Identifiers
    /// <summary>
    /// A class that declares constants for all Objects in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectIds
    {
        /// <summary>
        /// The identifier for the WeatherAPISet Object.
        /// </summary>
        public static readonly ExpandedNodeId WeatherAPISet = new ExpandedNodeId(Quickstarts.MyOPCServer.Objects.WeatherAPISet, Quickstarts.MyOPCServer.Namespaces.MyOPCServer);

        /// <summary>
        /// The identifier for the OpenWeatherMap Object.
        /// </summary>
        public static readonly ExpandedNodeId OpenWeatherMap = new ExpandedNodeId(Quickstarts.MyOPCServer.Objects.OpenWeatherMap, Quickstarts.MyOPCServer.Namespaces.MyOPCServer);

        /// <summary>
        /// The identifier for the WeatherData_Encoding_DefaultBinary Object.
        /// </summary>
        public static readonly ExpandedNodeId WeatherData_Encoding_DefaultBinary = new ExpandedNodeId(Quickstarts.MyOPCServer.Objects.WeatherData_Encoding_DefaultBinary, Quickstarts.MyOPCServer.Namespaces.MyOPCServer);

        /// <summary>
        /// The identifier for the AnalogData_Encoding_DefaultBinary Object.
        /// </summary>
        public static readonly ExpandedNodeId AnalogData_Encoding_DefaultBinary = new ExpandedNodeId(Quickstarts.MyOPCServer.Objects.AnalogData_Encoding_DefaultBinary, Quickstarts.MyOPCServer.Namespaces.MyOPCServer);

        /// <summary>
        /// The identifier for the WeatherData_Encoding_DefaultXml Object.
        /// </summary>
        public static readonly ExpandedNodeId WeatherData_Encoding_DefaultXml = new ExpandedNodeId(Quickstarts.MyOPCServer.Objects.WeatherData_Encoding_DefaultXml, Quickstarts.MyOPCServer.Namespaces.MyOPCServer);

        /// <summary>
        /// The identifier for the AnalogData_Encoding_DefaultXml Object.
        /// </summary>
        public static readonly ExpandedNodeId AnalogData_Encoding_DefaultXml = new ExpandedNodeId(Quickstarts.MyOPCServer.Objects.AnalogData_Encoding_DefaultXml, Quickstarts.MyOPCServer.Namespaces.MyOPCServer);

        /// <summary>
        /// The identifier for the WeatherData_Encoding_DefaultJson Object.
        /// </summary>
        public static readonly ExpandedNodeId WeatherData_Encoding_DefaultJson = new ExpandedNodeId(Quickstarts.MyOPCServer.Objects.WeatherData_Encoding_DefaultJson, Quickstarts.MyOPCServer.Namespaces.MyOPCServer);

        /// <summary>
        /// The identifier for the AnalogData_Encoding_DefaultJson Object.
        /// </summary>
        public static readonly ExpandedNodeId AnalogData_Encoding_DefaultJson = new ExpandedNodeId(Quickstarts.MyOPCServer.Objects.AnalogData_Encoding_DefaultJson, Quickstarts.MyOPCServer.Namespaces.MyOPCServer);
    }
    #endregion

    #region ObjectType Node Identifiers
    /// <summary>
    /// A class that declares constants for all ObjectTypes in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectTypeIds
    {
        /// <summary>
        /// The identifier for the OpenWeatherMapType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId OpenWeatherMapType = new ExpandedNodeId(Quickstarts.MyOPCServer.ObjectTypes.OpenWeatherMapType, Quickstarts.MyOPCServer.Namespaces.MyOPCServer);

        /// <summary>
        /// The identifier for the WeatherEventType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId WeatherEventType = new ExpandedNodeId(Quickstarts.MyOPCServer.ObjectTypes.WeatherEventType, Quickstarts.MyOPCServer.Namespaces.MyOPCServer);
    }
    #endregion

    #region Variable Node Identifiers
    /// <summary>
    /// A class that declares constants for all Variables in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class VariableIds
    {
        /// <summary>
        /// The identifier for the OpenWeatherMapType_CityName Variable.
        /// </summary>
        public static readonly ExpandedNodeId OpenWeatherMapType_CityName = new ExpandedNodeId(Quickstarts.MyOPCServer.Variables.OpenWeatherMapType_CityName, Quickstarts.MyOPCServer.Namespaces.MyOPCServer);

        /// <summary>
        /// The identifier for the OpenWeatherMapType_WeatherData Variable.
        /// </summary>
        public static readonly ExpandedNodeId OpenWeatherMapType_WeatherData = new ExpandedNodeId(Quickstarts.MyOPCServer.Variables.OpenWeatherMapType_WeatherData, Quickstarts.MyOPCServer.Namespaces.MyOPCServer);

        /// <summary>
        /// The identifier for the OpenWeatherMapType_WeatherData_Temperature Variable.
        /// </summary>
        public static readonly ExpandedNodeId OpenWeatherMapType_WeatherData_Temperature = new ExpandedNodeId(Quickstarts.MyOPCServer.Variables.OpenWeatherMapType_WeatherData_Temperature, Quickstarts.MyOPCServer.Namespaces.MyOPCServer);

        /// <summary>
        /// The identifier for the OpenWeatherMapType_WeatherData_Temperature_Data Variable.
        /// </summary>
        public static readonly ExpandedNodeId OpenWeatherMapType_WeatherData_Temperature_Data = new ExpandedNodeId(Quickstarts.MyOPCServer.Variables.OpenWeatherMapType_WeatherData_Temperature_Data, Quickstarts.MyOPCServer.Namespaces.MyOPCServer);

        /// <summary>
        /// The identifier for the OpenWeatherMapType_WeatherData_Temperature_Info Variable.
        /// </summary>
        public static readonly ExpandedNodeId OpenWeatherMapType_WeatherData_Temperature_Info = new ExpandedNodeId(Quickstarts.MyOPCServer.Variables.OpenWeatherMapType_WeatherData_Temperature_Info, Quickstarts.MyOPCServer.Namespaces.MyOPCServer);

        /// <summary>
        /// The identifier for the OpenWeatherMapType_WeatherData_MaxTemperature Variable.
        /// </summary>
        public static readonly ExpandedNodeId OpenWeatherMapType_WeatherData_MaxTemperature = new ExpandedNodeId(Quickstarts.MyOPCServer.Variables.OpenWeatherMapType_WeatherData_MaxTemperature, Quickstarts.MyOPCServer.Namespaces.MyOPCServer);

        /// <summary>
        /// The identifier for the OpenWeatherMapType_WeatherData_MaxTemperature_Data Variable.
        /// </summary>
        public static readonly ExpandedNodeId OpenWeatherMapType_WeatherData_MaxTemperature_Data = new ExpandedNodeId(Quickstarts.MyOPCServer.Variables.OpenWeatherMapType_WeatherData_MaxTemperature_Data, Quickstarts.MyOPCServer.Namespaces.MyOPCServer);

        /// <summary>
        /// The identifier for the OpenWeatherMapType_WeatherData_MaxTemperature_Info Variable.
        /// </summary>
        public static readonly ExpandedNodeId OpenWeatherMapType_WeatherData_MaxTemperature_Info = new ExpandedNodeId(Quickstarts.MyOPCServer.Variables.OpenWeatherMapType_WeatherData_MaxTemperature_Info, Quickstarts.MyOPCServer.Namespaces.MyOPCServer);

        /// <summary>
        /// The identifier for the OpenWeatherMapType_WeatherData_MinTemperature Variable.
        /// </summary>
        public static readonly ExpandedNodeId OpenWeatherMapType_WeatherData_MinTemperature = new ExpandedNodeId(Quickstarts.MyOPCServer.Variables.OpenWeatherMapType_WeatherData_MinTemperature, Quickstarts.MyOPCServer.Namespaces.MyOPCServer);

        /// <summary>
        /// The identifier for the OpenWeatherMapType_WeatherData_MinTemperature_Data Variable.
        /// </summary>
        public static readonly ExpandedNodeId OpenWeatherMapType_WeatherData_MinTemperature_Data = new ExpandedNodeId(Quickstarts.MyOPCServer.Variables.OpenWeatherMapType_WeatherData_MinTemperature_Data, Quickstarts.MyOPCServer.Namespaces.MyOPCServer);

        /// <summary>
        /// The identifier for the OpenWeatherMapType_WeatherData_MinTemperature_Info Variable.
        /// </summary>
        public static readonly ExpandedNodeId OpenWeatherMapType_WeatherData_MinTemperature_Info = new ExpandedNodeId(Quickstarts.MyOPCServer.Variables.OpenWeatherMapType_WeatherData_MinTemperature_Info, Quickstarts.MyOPCServer.Namespaces.MyOPCServer);

        /// <summary>
        /// The identifier for the OpenWeatherMapType_WeatherData_Pressure Variable.
        /// </summary>
        public static readonly ExpandedNodeId OpenWeatherMapType_WeatherData_Pressure = new ExpandedNodeId(Quickstarts.MyOPCServer.Variables.OpenWeatherMapType_WeatherData_Pressure, Quickstarts.MyOPCServer.Namespaces.MyOPCServer);

        /// <summary>
        /// The identifier for the OpenWeatherMapType_WeatherData_Pressure_Data Variable.
        /// </summary>
        public static readonly ExpandedNodeId OpenWeatherMapType_WeatherData_Pressure_Data = new ExpandedNodeId(Quickstarts.MyOPCServer.Variables.OpenWeatherMapType_WeatherData_Pressure_Data, Quickstarts.MyOPCServer.Namespaces.MyOPCServer);

        /// <summary>
        /// The identifier for the OpenWeatherMapType_WeatherData_Pressure_Info Variable.
        /// </summary>
        public static readonly ExpandedNodeId OpenWeatherMapType_WeatherData_Pressure_Info = new ExpandedNodeId(Quickstarts.MyOPCServer.Variables.OpenWeatherMapType_WeatherData_Pressure_Info, Quickstarts.MyOPCServer.Namespaces.MyOPCServer);

        /// <summary>
        /// The identifier for the OpenWeatherMapType_WeatherData_City Variable.
        /// </summary>
        public static readonly ExpandedNodeId OpenWeatherMapType_WeatherData_City = new ExpandedNodeId(Quickstarts.MyOPCServer.Variables.OpenWeatherMapType_WeatherData_City, Quickstarts.MyOPCServer.Namespaces.MyOPCServer);

        /// <summary>
        /// The identifier for the OpenWeatherMapType_OpenWeatherMapMethod_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId OpenWeatherMapType_OpenWeatherMapMethod_InputArguments = new ExpandedNodeId(Quickstarts.MyOPCServer.Variables.OpenWeatherMapType_OpenWeatherMapMethod_InputArguments, Quickstarts.MyOPCServer.Namespaces.MyOPCServer);

        /// <summary>
        /// The identifier for the WeatherEventType_WeatherMap Variable.
        /// </summary>
        public static readonly ExpandedNodeId WeatherEventType_WeatherMap = new ExpandedNodeId(Quickstarts.MyOPCServer.Variables.WeatherEventType_WeatherMap, Quickstarts.MyOPCServer.Namespaces.MyOPCServer);

        /// <summary>
        /// The identifier for the WeatherEventType_WeatherMap_Temperature Variable.
        /// </summary>
        public static readonly ExpandedNodeId WeatherEventType_WeatherMap_Temperature = new ExpandedNodeId(Quickstarts.MyOPCServer.Variables.WeatherEventType_WeatherMap_Temperature, Quickstarts.MyOPCServer.Namespaces.MyOPCServer);

        /// <summary>
        /// The identifier for the WeatherEventType_WeatherMap_Temperature_Data Variable.
        /// </summary>
        public static readonly ExpandedNodeId WeatherEventType_WeatherMap_Temperature_Data = new ExpandedNodeId(Quickstarts.MyOPCServer.Variables.WeatherEventType_WeatherMap_Temperature_Data, Quickstarts.MyOPCServer.Namespaces.MyOPCServer);

        /// <summary>
        /// The identifier for the WeatherEventType_WeatherMap_Temperature_Info Variable.
        /// </summary>
        public static readonly ExpandedNodeId WeatherEventType_WeatherMap_Temperature_Info = new ExpandedNodeId(Quickstarts.MyOPCServer.Variables.WeatherEventType_WeatherMap_Temperature_Info, Quickstarts.MyOPCServer.Namespaces.MyOPCServer);

        /// <summary>
        /// The identifier for the WeatherEventType_WeatherMap_MaxTemperature Variable.
        /// </summary>
        public static readonly ExpandedNodeId WeatherEventType_WeatherMap_MaxTemperature = new ExpandedNodeId(Quickstarts.MyOPCServer.Variables.WeatherEventType_WeatherMap_MaxTemperature, Quickstarts.MyOPCServer.Namespaces.MyOPCServer);

        /// <summary>
        /// The identifier for the WeatherEventType_WeatherMap_MaxTemperature_Data Variable.
        /// </summary>
        public static readonly ExpandedNodeId WeatherEventType_WeatherMap_MaxTemperature_Data = new ExpandedNodeId(Quickstarts.MyOPCServer.Variables.WeatherEventType_WeatherMap_MaxTemperature_Data, Quickstarts.MyOPCServer.Namespaces.MyOPCServer);

        /// <summary>
        /// The identifier for the WeatherEventType_WeatherMap_MaxTemperature_Info Variable.
        /// </summary>
        public static readonly ExpandedNodeId WeatherEventType_WeatherMap_MaxTemperature_Info = new ExpandedNodeId(Quickstarts.MyOPCServer.Variables.WeatherEventType_WeatherMap_MaxTemperature_Info, Quickstarts.MyOPCServer.Namespaces.MyOPCServer);

        /// <summary>
        /// The identifier for the WeatherEventType_WeatherMap_MinTemperature Variable.
        /// </summary>
        public static readonly ExpandedNodeId WeatherEventType_WeatherMap_MinTemperature = new ExpandedNodeId(Quickstarts.MyOPCServer.Variables.WeatherEventType_WeatherMap_MinTemperature, Quickstarts.MyOPCServer.Namespaces.MyOPCServer);

        /// <summary>
        /// The identifier for the WeatherEventType_WeatherMap_MinTemperature_Data Variable.
        /// </summary>
        public static readonly ExpandedNodeId WeatherEventType_WeatherMap_MinTemperature_Data = new ExpandedNodeId(Quickstarts.MyOPCServer.Variables.WeatherEventType_WeatherMap_MinTemperature_Data, Quickstarts.MyOPCServer.Namespaces.MyOPCServer);

        /// <summary>
        /// The identifier for the WeatherEventType_WeatherMap_MinTemperature_Info Variable.
        /// </summary>
        public static readonly ExpandedNodeId WeatherEventType_WeatherMap_MinTemperature_Info = new ExpandedNodeId(Quickstarts.MyOPCServer.Variables.WeatherEventType_WeatherMap_MinTemperature_Info, Quickstarts.MyOPCServer.Namespaces.MyOPCServer);

        /// <summary>
        /// The identifier for the WeatherEventType_WeatherMap_Pressure Variable.
        /// </summary>
        public static readonly ExpandedNodeId WeatherEventType_WeatherMap_Pressure = new ExpandedNodeId(Quickstarts.MyOPCServer.Variables.WeatherEventType_WeatherMap_Pressure, Quickstarts.MyOPCServer.Namespaces.MyOPCServer);

        /// <summary>
        /// The identifier for the WeatherEventType_WeatherMap_Pressure_Data Variable.
        /// </summary>
        public static readonly ExpandedNodeId WeatherEventType_WeatherMap_Pressure_Data = new ExpandedNodeId(Quickstarts.MyOPCServer.Variables.WeatherEventType_WeatherMap_Pressure_Data, Quickstarts.MyOPCServer.Namespaces.MyOPCServer);

        /// <summary>
        /// The identifier for the WeatherEventType_WeatherMap_Pressure_Info Variable.
        /// </summary>
        public static readonly ExpandedNodeId WeatherEventType_WeatherMap_Pressure_Info = new ExpandedNodeId(Quickstarts.MyOPCServer.Variables.WeatherEventType_WeatherMap_Pressure_Info, Quickstarts.MyOPCServer.Namespaces.MyOPCServer);

        /// <summary>
        /// The identifier for the WeatherEventType_WeatherMap_City Variable.
        /// </summary>
        public static readonly ExpandedNodeId WeatherEventType_WeatherMap_City = new ExpandedNodeId(Quickstarts.MyOPCServer.Variables.WeatherEventType_WeatherMap_City, Quickstarts.MyOPCServer.Namespaces.MyOPCServer);

        /// <summary>
        /// The identifier for the WeatherMapVariableType_Temperature Variable.
        /// </summary>
        public static readonly ExpandedNodeId WeatherMapVariableType_Temperature = new ExpandedNodeId(Quickstarts.MyOPCServer.Variables.WeatherMapVariableType_Temperature, Quickstarts.MyOPCServer.Namespaces.MyOPCServer);

        /// <summary>
        /// The identifier for the WeatherMapVariableType_Temperature_Data Variable.
        /// </summary>
        public static readonly ExpandedNodeId WeatherMapVariableType_Temperature_Data = new ExpandedNodeId(Quickstarts.MyOPCServer.Variables.WeatherMapVariableType_Temperature_Data, Quickstarts.MyOPCServer.Namespaces.MyOPCServer);

        /// <summary>
        /// The identifier for the WeatherMapVariableType_Temperature_Info Variable.
        /// </summary>
        public static readonly ExpandedNodeId WeatherMapVariableType_Temperature_Info = new ExpandedNodeId(Quickstarts.MyOPCServer.Variables.WeatherMapVariableType_Temperature_Info, Quickstarts.MyOPCServer.Namespaces.MyOPCServer);

        /// <summary>
        /// The identifier for the WeatherMapVariableType_MaxTemperature Variable.
        /// </summary>
        public static readonly ExpandedNodeId WeatherMapVariableType_MaxTemperature = new ExpandedNodeId(Quickstarts.MyOPCServer.Variables.WeatherMapVariableType_MaxTemperature, Quickstarts.MyOPCServer.Namespaces.MyOPCServer);

        /// <summary>
        /// The identifier for the WeatherMapVariableType_MaxTemperature_Data Variable.
        /// </summary>
        public static readonly ExpandedNodeId WeatherMapVariableType_MaxTemperature_Data = new ExpandedNodeId(Quickstarts.MyOPCServer.Variables.WeatherMapVariableType_MaxTemperature_Data, Quickstarts.MyOPCServer.Namespaces.MyOPCServer);

        /// <summary>
        /// The identifier for the WeatherMapVariableType_MaxTemperature_Info Variable.
        /// </summary>
        public static readonly ExpandedNodeId WeatherMapVariableType_MaxTemperature_Info = new ExpandedNodeId(Quickstarts.MyOPCServer.Variables.WeatherMapVariableType_MaxTemperature_Info, Quickstarts.MyOPCServer.Namespaces.MyOPCServer);

        /// <summary>
        /// The identifier for the WeatherMapVariableType_MinTemperature Variable.
        /// </summary>
        public static readonly ExpandedNodeId WeatherMapVariableType_MinTemperature = new ExpandedNodeId(Quickstarts.MyOPCServer.Variables.WeatherMapVariableType_MinTemperature, Quickstarts.MyOPCServer.Namespaces.MyOPCServer);

        /// <summary>
        /// The identifier for the WeatherMapVariableType_MinTemperature_Data Variable.
        /// </summary>
        public static readonly ExpandedNodeId WeatherMapVariableType_MinTemperature_Data = new ExpandedNodeId(Quickstarts.MyOPCServer.Variables.WeatherMapVariableType_MinTemperature_Data, Quickstarts.MyOPCServer.Namespaces.MyOPCServer);

        /// <summary>
        /// The identifier for the WeatherMapVariableType_MinTemperature_Info Variable.
        /// </summary>
        public static readonly ExpandedNodeId WeatherMapVariableType_MinTemperature_Info = new ExpandedNodeId(Quickstarts.MyOPCServer.Variables.WeatherMapVariableType_MinTemperature_Info, Quickstarts.MyOPCServer.Namespaces.MyOPCServer);

        /// <summary>
        /// The identifier for the WeatherMapVariableType_Pressure Variable.
        /// </summary>
        public static readonly ExpandedNodeId WeatherMapVariableType_Pressure = new ExpandedNodeId(Quickstarts.MyOPCServer.Variables.WeatherMapVariableType_Pressure, Quickstarts.MyOPCServer.Namespaces.MyOPCServer);

        /// <summary>
        /// The identifier for the WeatherMapVariableType_Pressure_Data Variable.
        /// </summary>
        public static readonly ExpandedNodeId WeatherMapVariableType_Pressure_Data = new ExpandedNodeId(Quickstarts.MyOPCServer.Variables.WeatherMapVariableType_Pressure_Data, Quickstarts.MyOPCServer.Namespaces.MyOPCServer);

        /// <summary>
        /// The identifier for the WeatherMapVariableType_Pressure_Info Variable.
        /// </summary>
        public static readonly ExpandedNodeId WeatherMapVariableType_Pressure_Info = new ExpandedNodeId(Quickstarts.MyOPCServer.Variables.WeatherMapVariableType_Pressure_Info, Quickstarts.MyOPCServer.Namespaces.MyOPCServer);

        /// <summary>
        /// The identifier for the WeatherMapVariableType_City Variable.
        /// </summary>
        public static readonly ExpandedNodeId WeatherMapVariableType_City = new ExpandedNodeId(Quickstarts.MyOPCServer.Variables.WeatherMapVariableType_City, Quickstarts.MyOPCServer.Namespaces.MyOPCServer);

        /// <summary>
        /// The identifier for the AnalogVariableType_Data Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogVariableType_Data = new ExpandedNodeId(Quickstarts.MyOPCServer.Variables.AnalogVariableType_Data, Quickstarts.MyOPCServer.Namespaces.MyOPCServer);

        /// <summary>
        /// The identifier for the AnalogVariableType_Info Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogVariableType_Info = new ExpandedNodeId(Quickstarts.MyOPCServer.Variables.AnalogVariableType_Info, Quickstarts.MyOPCServer.Namespaces.MyOPCServer);

        /// <summary>
        /// The identifier for the OpenWeatherMap_CityName Variable.
        /// </summary>
        public static readonly ExpandedNodeId OpenWeatherMap_CityName = new ExpandedNodeId(Quickstarts.MyOPCServer.Variables.OpenWeatherMap_CityName, Quickstarts.MyOPCServer.Namespaces.MyOPCServer);

        /// <summary>
        /// The identifier for the OpenWeatherMap_WeatherData Variable.
        /// </summary>
        public static readonly ExpandedNodeId OpenWeatherMap_WeatherData = new ExpandedNodeId(Quickstarts.MyOPCServer.Variables.OpenWeatherMap_WeatherData, Quickstarts.MyOPCServer.Namespaces.MyOPCServer);

        /// <summary>
        /// The identifier for the OpenWeatherMap_WeatherData_Temperature Variable.
        /// </summary>
        public static readonly ExpandedNodeId OpenWeatherMap_WeatherData_Temperature = new ExpandedNodeId(Quickstarts.MyOPCServer.Variables.OpenWeatherMap_WeatherData_Temperature, Quickstarts.MyOPCServer.Namespaces.MyOPCServer);

        /// <summary>
        /// The identifier for the OpenWeatherMap_WeatherData_Temperature_Data Variable.
        /// </summary>
        public static readonly ExpandedNodeId OpenWeatherMap_WeatherData_Temperature_Data = new ExpandedNodeId(Quickstarts.MyOPCServer.Variables.OpenWeatherMap_WeatherData_Temperature_Data, Quickstarts.MyOPCServer.Namespaces.MyOPCServer);

        /// <summary>
        /// The identifier for the OpenWeatherMap_WeatherData_Temperature_Info Variable.
        /// </summary>
        public static readonly ExpandedNodeId OpenWeatherMap_WeatherData_Temperature_Info = new ExpandedNodeId(Quickstarts.MyOPCServer.Variables.OpenWeatherMap_WeatherData_Temperature_Info, Quickstarts.MyOPCServer.Namespaces.MyOPCServer);

        /// <summary>
        /// The identifier for the OpenWeatherMap_WeatherData_MaxTemperature Variable.
        /// </summary>
        public static readonly ExpandedNodeId OpenWeatherMap_WeatherData_MaxTemperature = new ExpandedNodeId(Quickstarts.MyOPCServer.Variables.OpenWeatherMap_WeatherData_MaxTemperature, Quickstarts.MyOPCServer.Namespaces.MyOPCServer);

        /// <summary>
        /// The identifier for the OpenWeatherMap_WeatherData_MaxTemperature_Data Variable.
        /// </summary>
        public static readonly ExpandedNodeId OpenWeatherMap_WeatherData_MaxTemperature_Data = new ExpandedNodeId(Quickstarts.MyOPCServer.Variables.OpenWeatherMap_WeatherData_MaxTemperature_Data, Quickstarts.MyOPCServer.Namespaces.MyOPCServer);

        /// <summary>
        /// The identifier for the OpenWeatherMap_WeatherData_MaxTemperature_Info Variable.
        /// </summary>
        public static readonly ExpandedNodeId OpenWeatherMap_WeatherData_MaxTemperature_Info = new ExpandedNodeId(Quickstarts.MyOPCServer.Variables.OpenWeatherMap_WeatherData_MaxTemperature_Info, Quickstarts.MyOPCServer.Namespaces.MyOPCServer);

        /// <summary>
        /// The identifier for the OpenWeatherMap_WeatherData_MinTemperature Variable.
        /// </summary>
        public static readonly ExpandedNodeId OpenWeatherMap_WeatherData_MinTemperature = new ExpandedNodeId(Quickstarts.MyOPCServer.Variables.OpenWeatherMap_WeatherData_MinTemperature, Quickstarts.MyOPCServer.Namespaces.MyOPCServer);

        /// <summary>
        /// The identifier for the OpenWeatherMap_WeatherData_MinTemperature_Data Variable.
        /// </summary>
        public static readonly ExpandedNodeId OpenWeatherMap_WeatherData_MinTemperature_Data = new ExpandedNodeId(Quickstarts.MyOPCServer.Variables.OpenWeatherMap_WeatherData_MinTemperature_Data, Quickstarts.MyOPCServer.Namespaces.MyOPCServer);

        /// <summary>
        /// The identifier for the OpenWeatherMap_WeatherData_MinTemperature_Info Variable.
        /// </summary>
        public static readonly ExpandedNodeId OpenWeatherMap_WeatherData_MinTemperature_Info = new ExpandedNodeId(Quickstarts.MyOPCServer.Variables.OpenWeatherMap_WeatherData_MinTemperature_Info, Quickstarts.MyOPCServer.Namespaces.MyOPCServer);

        /// <summary>
        /// The identifier for the OpenWeatherMap_WeatherData_Pressure Variable.
        /// </summary>
        public static readonly ExpandedNodeId OpenWeatherMap_WeatherData_Pressure = new ExpandedNodeId(Quickstarts.MyOPCServer.Variables.OpenWeatherMap_WeatherData_Pressure, Quickstarts.MyOPCServer.Namespaces.MyOPCServer);

        /// <summary>
        /// The identifier for the OpenWeatherMap_WeatherData_Pressure_Data Variable.
        /// </summary>
        public static readonly ExpandedNodeId OpenWeatherMap_WeatherData_Pressure_Data = new ExpandedNodeId(Quickstarts.MyOPCServer.Variables.OpenWeatherMap_WeatherData_Pressure_Data, Quickstarts.MyOPCServer.Namespaces.MyOPCServer);

        /// <summary>
        /// The identifier for the OpenWeatherMap_WeatherData_Pressure_Info Variable.
        /// </summary>
        public static readonly ExpandedNodeId OpenWeatherMap_WeatherData_Pressure_Info = new ExpandedNodeId(Quickstarts.MyOPCServer.Variables.OpenWeatherMap_WeatherData_Pressure_Info, Quickstarts.MyOPCServer.Namespaces.MyOPCServer);

        /// <summary>
        /// The identifier for the OpenWeatherMap_WeatherData_City Variable.
        /// </summary>
        public static readonly ExpandedNodeId OpenWeatherMap_WeatherData_City = new ExpandedNodeId(Quickstarts.MyOPCServer.Variables.OpenWeatherMap_WeatherData_City, Quickstarts.MyOPCServer.Namespaces.MyOPCServer);

        /// <summary>
        /// The identifier for the OpenWeatherMap_OpenWeatherMapMethod_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId OpenWeatherMap_OpenWeatherMapMethod_InputArguments = new ExpandedNodeId(Quickstarts.MyOPCServer.Variables.OpenWeatherMap_OpenWeatherMapMethod_InputArguments, Quickstarts.MyOPCServer.Namespaces.MyOPCServer);

        /// <summary>
        /// The identifier for the MyOPCServer_BinarySchema Variable.
        /// </summary>
        public static readonly ExpandedNodeId MyOPCServer_BinarySchema = new ExpandedNodeId(Quickstarts.MyOPCServer.Variables.MyOPCServer_BinarySchema, Quickstarts.MyOPCServer.Namespaces.MyOPCServer);

        /// <summary>
        /// The identifier for the MyOPCServer_BinarySchema_NamespaceUri Variable.
        /// </summary>
        public static readonly ExpandedNodeId MyOPCServer_BinarySchema_NamespaceUri = new ExpandedNodeId(Quickstarts.MyOPCServer.Variables.MyOPCServer_BinarySchema_NamespaceUri, Quickstarts.MyOPCServer.Namespaces.MyOPCServer);

        /// <summary>
        /// The identifier for the MyOPCServer_BinarySchema_Deprecated Variable.
        /// </summary>
        public static readonly ExpandedNodeId MyOPCServer_BinarySchema_Deprecated = new ExpandedNodeId(Quickstarts.MyOPCServer.Variables.MyOPCServer_BinarySchema_Deprecated, Quickstarts.MyOPCServer.Namespaces.MyOPCServer);

        /// <summary>
        /// The identifier for the MyOPCServer_BinarySchema_WeatherData Variable.
        /// </summary>
        public static readonly ExpandedNodeId MyOPCServer_BinarySchema_WeatherData = new ExpandedNodeId(Quickstarts.MyOPCServer.Variables.MyOPCServer_BinarySchema_WeatherData, Quickstarts.MyOPCServer.Namespaces.MyOPCServer);

        /// <summary>
        /// The identifier for the MyOPCServer_BinarySchema_AnalogData Variable.
        /// </summary>
        public static readonly ExpandedNodeId MyOPCServer_BinarySchema_AnalogData = new ExpandedNodeId(Quickstarts.MyOPCServer.Variables.MyOPCServer_BinarySchema_AnalogData, Quickstarts.MyOPCServer.Namespaces.MyOPCServer);

        /// <summary>
        /// The identifier for the MyOPCServer_XmlSchema Variable.
        /// </summary>
        public static readonly ExpandedNodeId MyOPCServer_XmlSchema = new ExpandedNodeId(Quickstarts.MyOPCServer.Variables.MyOPCServer_XmlSchema, Quickstarts.MyOPCServer.Namespaces.MyOPCServer);

        /// <summary>
        /// The identifier for the MyOPCServer_XmlSchema_NamespaceUri Variable.
        /// </summary>
        public static readonly ExpandedNodeId MyOPCServer_XmlSchema_NamespaceUri = new ExpandedNodeId(Quickstarts.MyOPCServer.Variables.MyOPCServer_XmlSchema_NamespaceUri, Quickstarts.MyOPCServer.Namespaces.MyOPCServer);

        /// <summary>
        /// The identifier for the MyOPCServer_XmlSchema_Deprecated Variable.
        /// </summary>
        public static readonly ExpandedNodeId MyOPCServer_XmlSchema_Deprecated = new ExpandedNodeId(Quickstarts.MyOPCServer.Variables.MyOPCServer_XmlSchema_Deprecated, Quickstarts.MyOPCServer.Namespaces.MyOPCServer);

        /// <summary>
        /// The identifier for the MyOPCServer_XmlSchema_WeatherData Variable.
        /// </summary>
        public static readonly ExpandedNodeId MyOPCServer_XmlSchema_WeatherData = new ExpandedNodeId(Quickstarts.MyOPCServer.Variables.MyOPCServer_XmlSchema_WeatherData, Quickstarts.MyOPCServer.Namespaces.MyOPCServer);

        /// <summary>
        /// The identifier for the MyOPCServer_XmlSchema_AnalogData Variable.
        /// </summary>
        public static readonly ExpandedNodeId MyOPCServer_XmlSchema_AnalogData = new ExpandedNodeId(Quickstarts.MyOPCServer.Variables.MyOPCServer_XmlSchema_AnalogData, Quickstarts.MyOPCServer.Namespaces.MyOPCServer);
    }
    #endregion

    #region VariableType Node Identifiers
    /// <summary>
    /// A class that declares constants for all VariableTypes in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class VariableTypeIds
    {
        /// <summary>
        /// The identifier for the WeatherMapVariableType VariableType.
        /// </summary>
        public static readonly ExpandedNodeId WeatherMapVariableType = new ExpandedNodeId(Quickstarts.MyOPCServer.VariableTypes.WeatherMapVariableType, Quickstarts.MyOPCServer.Namespaces.MyOPCServer);

        /// <summary>
        /// The identifier for the AnalogVariableType VariableType.
        /// </summary>
        public static readonly ExpandedNodeId AnalogVariableType = new ExpandedNodeId(Quickstarts.MyOPCServer.VariableTypes.AnalogVariableType, Quickstarts.MyOPCServer.Namespaces.MyOPCServer);
    }
    #endregion

    #region BrowseName Declarations
    /// <summary>
    /// Declares all of the BrowseNames used in the Model Design.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class BrowseNames
    {
        /// <summary>
        /// The BrowseName for the AnalogData component.
        /// </summary>
        public const string AnalogData = "AnalogData";

        /// <summary>
        /// The BrowseName for the AnalogVariableType component.
        /// </summary>
        public const string AnalogVariableType = "AnalogVariableType";

        /// <summary>
        /// The BrowseName for the City component.
        /// </summary>
        public const string City = "City";

        /// <summary>
        /// The BrowseName for the CityName component.
        /// </summary>
        public const string CityName = "CityName";

        /// <summary>
        /// The BrowseName for the Data component.
        /// </summary>
        public const string Data = "Data";

        /// <summary>
        /// The BrowseName for the Info component.
        /// </summary>
        public const string Info = "Info";

        /// <summary>
        /// The BrowseName for the MaxTemperature component.
        /// </summary>
        public const string MaxTemperature = "MaxTemperature";

        /// <summary>
        /// The BrowseName for the MinTemperature component.
        /// </summary>
        public const string MinTemperature = "MinTemperature";

        /// <summary>
        /// The BrowseName for the MyOPCServer_BinarySchema component.
        /// </summary>
        public const string MyOPCServer_BinarySchema = "Quickstarts.MyOPCServer";

        /// <summary>
        /// The BrowseName for the MyOPCServer_XmlSchema component.
        /// </summary>
        public const string MyOPCServer_XmlSchema = "Quickstarts.MyOPCServer";

        /// <summary>
        /// The BrowseName for the OpenWeatherMap component.
        /// </summary>
        public const string OpenWeatherMap = "OpenWeatherMap";

        /// <summary>
        /// The BrowseName for the OpenWeatherMapMethod component.
        /// </summary>
        public const string OpenWeatherMapMethod = "OpenWeatherMapMethod";

        /// <summary>
        /// The BrowseName for the OpenWeatherMapType component.
        /// </summary>
        public const string OpenWeatherMapType = "OpenWeatherMapType";

        /// <summary>
        /// The BrowseName for the Pressure component.
        /// </summary>
        public const string Pressure = "Pressure";

        /// <summary>
        /// The BrowseName for the Temperature component.
        /// </summary>
        public const string Temperature = "Temperature";

        /// <summary>
        /// The BrowseName for the WeatherAPISet component.
        /// </summary>
        public const string WeatherAPISet = "WeatherAPISet";

        /// <summary>
        /// The BrowseName for the WeatherData component.
        /// </summary>
        public const string WeatherData = "WeatherData";

        /// <summary>
        /// The BrowseName for the WeatherEventType component.
        /// </summary>
        public const string WeatherEventType = "WeatherEventType";

        /// <summary>
        /// The BrowseName for the WeatherMap component.
        /// </summary>
        public const string WeatherMap = "WeatherMap";

        /// <summary>
        /// The BrowseName for the WeatherMapVariableType component.
        /// </summary>
        public const string WeatherMapVariableType = "WeatherMapVariableType";
    }
    #endregion

    #region Namespace Declarations
    /// <summary>
    /// Defines constants for all namespaces referenced by the model design.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Namespaces
    {
        /// <summary>
        /// The URI for the OpcUa namespace (.NET code namespace is 'Opc.Ua').
        /// </summary>
        public const string OpcUa = "http://opcfoundation.org/UA/";

        /// <summary>
        /// The URI for the OpcUaXsd namespace (.NET code namespace is 'Opc.Ua').
        /// </summary>
        public const string OpcUaXsd = "http://opcfoundation.org/UA/2008/02/Types.xsd";

        /// <summary>
        /// The URI for the MyOPCServer namespace (.NET code namespace is 'Quickstarts.MyOPCServer').
        /// </summary>
        public const string MyOPCServer = "https://github.com/dariofugale95/server-opc-ua-dotnetcore";
    }
    #endregion
}
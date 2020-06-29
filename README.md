# server-opc-ua-dotnetcore
Server OPC UA in .net Core

This repository contains Server OPC UA developed in  .Net Core, the stack used is OPC Foundation UA-.NETStandard: https://github.com/OPCFoundation/UA-.NETStandard
This Server acquires data relating to the weather of a given city (chosen by the client) using the following API: https://openweathermap.org/. 
The Weather Data are exposed in nodes readable by the client. 
In this server are used Datatype custom, the model data is defined with .xml file and it's compiled, to get the binary with nodes, with OPC-UA Model Compiler: https://github.com/OPCFoundation/UA-ModelCompiler. 





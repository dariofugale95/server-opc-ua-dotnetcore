# server-opc-ua-dotnetcore
Server OPC UA in .Net Core

This repository contains Server OPC UA developed in  .Net Core, the stack used is OPC Foundation UA-.NETStandard: https://github.com/OPCFoundation/UA-.NETStandard

This Server acquires data relating to the weather of a given city (chosen by the client) using the following API: 
https://openweathermap.org/. 

The Weather Data are exposed in nodes readable by the client.  In this server are used custom datatypes, the model data is defined with .xml file and it's compiled, to get the binary with nodes, with OPC-UA Model Compiler: 
https://github.com/OPCFoundation/UA-ModelCompiler. 

The Server has been tested with UA Sample Client developed by OPC Foundation: http://opcfoundation.github.io/UA-.NETStandard/help/ua_sample_client.htm. 
To test the server with Sample Client it is possible to use, as authentication policy, only basic256 and Basic128Rsa15, because Sample Client does not support basic256sha256, even if the server has this security policy. 

Run MyOPCServer 

> cd OPCServerNETCore\OPCServerNETCore\bin\Debug\netcoreapp3.1\

> Quickstarts.MyOPCServer.exe

Or

Open OPCServerNETCore\OPCServerNETCore.sln on Visual Studio 





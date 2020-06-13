using Opc.Ua;
using Opc.Ua.Server;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace OPCServerNETCore.OPCServer
{
    class MyOPCServer : StandardServer
    {
        #region Constructors
        public MyOPCServer()
        {
        }


        #endregion

        #region Overridden Methods
        protected override MasterNodeManager CreateMasterNodeManager(IServerInternal server, ApplicationConfiguration configuration)
        {
            List<INodeManager> managers = new List<INodeManager>();

            managers.Add(new MyOPCServerNodeManager(server, configuration));

            return new MasterNodeManager(server, configuration, null, managers.ToArray());
        }
        protected override ServerProperties LoadServerProperties()
        {
            var thisAssembly = GetType().Assembly;
            ServerProperties properties = new ServerProperties();

            properties.ManufacturerName = "castagnolofugale";
            properties.ProductName = "MyOPCServer";
            properties.ProductUri = "https://github.com/dariofugale95/server-opc-ua-dotnetcore";
            properties.SoftwareVersion = thisAssembly.GetCustomAttribute<AssemblyInformationalVersionAttribute>().InformationalVersion;
            properties.BuildNumber = thisAssembly.GetCustomAttribute<AssemblyFileVersionAttribute>().Version;
            properties.BuildDate = File.GetLastWriteTimeUtc(thisAssembly.Location);

            return properties;
        }

        protected override void OnServerStarted(IServerInternal server)
        {
            base.OnServerStarted(server);

            // request notifications when the user identity is changed. all valid users are accepted by default.
            // server.SessionManager.ImpersonateUser += new ImpersonateEventHandler(SessionManager_ImpersonateUser);
        }

        protected override void OnServerStarting(ApplicationConfiguration configuration)
        {
            base.OnServerStarting(configuration);
        }

        #endregion
    }
}

using Opc.Ua;
using Opc.Ua.Configuration;
using OPCServerNETCore.OPCServer;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OPCServerNETCore
{
    public class ServerLauncher
    {
        #region Private Fields
        MyOPCServer server;
        #endregion

        #region Constructors
        public ServerLauncher() { }
        #endregion

        #region Methods
        public void Run()
        {
            StartOPCServer().Wait();
        }

        private async Task StartOPCServer()
        {
            ApplicationInstance applicationInstance = new ApplicationInstance();

            applicationInstance.ApplicationName = "MyOPCServer";
            applicationInstance.ApplicationType = Opc.Ua.ApplicationType.Server;
            applicationInstance.ConfigSectionName = "MyOPCServerConfig";

            ApplicationConfiguration applicationConfiguration = await applicationInstance.LoadApplicationConfiguration(false);

            server = new MyOPCServer();
            await applicationInstance.Start(server);
        }
        #endregion
    }
}

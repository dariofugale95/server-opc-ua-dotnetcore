using Opc.Ua;
using Opc.Ua.Server;
using System;
using System.Collections.Generic;
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
        protected override void OnNodeManagerStarted(IServerInternal server)
        {
            base.OnNodeManagerStarted(server);
        }

        protected override void OnServerStarted(IServerInternal server)
        {
            base.OnServerStarted(server);
        }

        protected override void OnServerStarting(ApplicationConfiguration configuration)
        {
            base.OnServerStarting(configuration);
        }

        protected override void OnServerStopping()
        {
            base.OnServerStopping();
        }
        #endregion
    }
}

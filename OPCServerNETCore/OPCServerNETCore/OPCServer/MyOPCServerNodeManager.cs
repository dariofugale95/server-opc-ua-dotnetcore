using Opc.Ua;
using Opc.Ua.Server;
using System;
using System.Collections.Generic;
using System.Text;

namespace OPCServerNETCore.OPCServer
{
    class MyOPCServerNodeManager : CustomNodeManager2
    {
        #region Private Fields
        MyOPCServerConfiguration serverConfiguration;
        #endregion

        #region Constructors
        /// <summary>
        /// Initializes the node manager.
        /// </summary>
        public MyOPCServerNodeManager(IServerInternal server, ApplicationConfiguration configuration)
            : base(server, configuration, Namespaces.MyOPCServer)
        {
            SystemContext.NodeIdFactory = this;

            // get the configuration for the node manager.
            serverConfiguration = configuration.ParseExtension<MyOPCServerConfiguration>();

            // use suitable defaults if no configuration exists.
            if (serverConfiguration == null)
            {
                serverConfiguration = new MyOPCServerConfiguration();
            }
        }
        #endregion
    }
}

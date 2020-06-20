﻿/* ========================================================================
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

using Opc.Ua;
using Opc.Ua.Server;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Quickstarts.MyOPCServer
{
    class MyOPCServer : StandardServer
    {
        #region Constructors
        public MyOPCServer()
        {
        }
        #endregion

        #region Overridden Methods

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
            server.SessionManager.ImpersonateUser += new ImpersonateEventHandler(SessionManager_ImpersonateUser);

            try
            {
                // allow a faster sampling interval for CurrentTime node.
                server.Status.Variable.CurrentTime.MinimumSamplingInterval = 250;
            }
            catch
            { }

        }

        protected override void OnServerStarting(ApplicationConfiguration configuration)
        {
            Utils.Trace("The server is starting");
            base.OnServerStarting(configuration);
            CreateUserIdentityValidators(configuration);
        }

        //create MasterNodeManager
        protected override MasterNodeManager CreateMasterNodeManager(IServerInternal server, ApplicationConfiguration configuration)
        {
            Utils.Trace("Creating the Node Managers.");

            List<INodeManager> nodeManagers = new List<INodeManager>();

            // creazione di un node manager
            nodeManagers.Add(new MyOPCServerNodeManager(server, configuration));

            // creazione master node manager
            return new MasterNodeManager(server, configuration, null, nodeManagers.ToArray());
        }

        #endregion


        #region User Validation

        private void CreateUserIdentityValidators(ApplicationConfiguration configuration)
        {
            for (int ii = 0; ii < configuration.ServerConfiguration.UserTokenPolicies.Count; ii++)
            {
                UserTokenPolicy policy = configuration.ServerConfiguration.UserTokenPolicies[ii];

                // creare un validator per token policy
                if (policy.TokenType == UserTokenType.Certificate)
                {
                    //se il certificato dell'utente è nella lista degli utenti affidabili 
                    // nella configurazione potrebbe essere specificata la lista dei certificati di fiducia quindi effettuiamo un controllo. Nel caso in cui questo dovesse essere vero 
                    //dopo aver creato il validatore di certficati settiamo le il certificaValidator con quanto presente nella configurazione. 
                    if (configuration.SecurityConfiguration.TrustedUserCertificates != null &&
                        configuration.SecurityConfiguration.UserIssuerCertificates != null)
                    {
                        CertificateValidator certificateValidator = new CertificateValidator();
                        certificateValidator.Update(configuration.SecurityConfiguration).Wait();
                        certificateValidator.Update(configuration.SecurityConfiguration.UserIssuerCertificates,
                            configuration.SecurityConfiguration.TrustedUserCertificates,
                            configuration.SecurityConfiguration.RejectedCertificateStore);

                        // specifichiamo un validatore dei certificati
                        m_userCertificateValidator = (CertificateValidator)certificateValidator.GetChannelValidator();
                    }
                }
            }
        }
        //un client potrebbe cambiare la sua user identity, questo metodo serve a gestire la cosa
        private void SessionManager_ImpersonateUser(Session session, ImpersonateEventArgs args)
        {

            UserNameIdentityToken userNameToken = args.NewIdentity as UserNameIdentityToken;
            //controlliamo che lo username token sia valido
            if (userNameToken != null)
            {
                //il metodo verifypassword verifica che la password sia valida per lo usertoken corrente
                args.Identity = VerifyPassword(userNameToken);

                // set AuthenticatedUser role for accepted user/password authentication
                args.Identity.GrantedRoleIds.Add(ObjectIds.WellKnownRole_AuthenticatedUser);
                //se l'identità dell'utente è di tipo SystemConfigurationIdentity allora l'utente ha il permesso di configurare il server
                if (args.Identity is SystemConfigurationIdentity)
                {

                    args.Identity.GrantedRoleIds.Add(ObjectIds.WellKnownRole_ConfigureAdmin);
                    args.Identity.GrantedRoleIds.Add(ObjectIds.WellKnownRole_SecurityAdmin);
                }

                return;
            }

            // carichiamo il token
            X509IdentityToken x509Token = args.NewIdentity as X509IdentityToken;

            if (x509Token != null)
            {
                VerifyUserTokenCertificate(x509Token.Certificate);
                args.Identity = new UserIdentity(x509Token);
                Utils.Trace("X509 Token Accepted: {0}", args.Identity.DisplayName);

                // set AuthenticatedUser role for accepted certificate authentication
                args.Identity.GrantedRoleIds.Add(ObjectIds.WellKnownRole_AuthenticatedUser);

                return;
            }

            // se il token è nullo allora come identità si setta quella anonima 
            args.Identity = new UserIdentity();
            args.Identity.GrantedRoleIds.Add(ObjectIds.WellKnownRole_Anonymous);
        }


        private void VerifyUserTokenCertificate(X509Certificate2 certificate)
        {
            //verifichiamo se un certificato è affidabile
            try
            {

                if (m_userCertificateValidator != null)
                {
                    m_userCertificateValidator.Validate(certificate);
                }
                else
                {
                    CertificateValidator.Validate(certificate);
                }



            }
            catch (Exception e)
            {
                TranslationInfo info;
                StatusCode result = StatusCodes.BadIdentityTokenRejected;
                ServiceResultException se = e as ServiceResultException;
                if (se != null && se.StatusCode == StatusCodes.BadCertificateUseNotAllowed)
                {
                    info = new TranslationInfo(
                        "InvalidCertificate",
                        "en-US",
                        "'{0}' is an invalid user certificate.",
                        certificate.Subject);

                    result = StatusCodes.BadIdentityTokenInvalid;
                }
                else
                {
                    // construct translation object with default text.
                    info = new TranslationInfo(
                        "UntrustedCertificate",
                        "en-US",
                        "'{0}' is not a trusted user certificate.",
                        certificate.Subject);
                }

                // create an exception with a vendor defined sub-code.
                throw new ServiceResultException(new ServiceResult(
                    result,
                    info.Key,
                    LoadServerProperties().ProductUri,
                    new LocalizedText(info)));
            }
        }

        private IUserIdentity VerifyPassword(UserNameIdentityToken userNameToken)
        {
            //carichiamo le credenziali 
            var password = userNameToken.Password.ToString();
            var user = userNameToken.UserName;
            if (String.IsNullOrEmpty(user))
            {
                //se lo user è nullo dobbiamo lanciare un'eccezione poichè questo campo non può essere vuoto
                throw ServiceResultException.Create(StatusCodes.BadIdentityTokenInvalid,
                   "Security token is not a valid username token. An empty username is not accepted.");
            }

            if (String.IsNullOrEmpty(password))
            {
                //se la password è nulla dobbiamo lanciare un'eccezione poichè questo campo non può essere vuoto
                throw ServiceResultException.Create(StatusCodes.BadIdentityTokenInvalid,
                   "Security token is not a valid username token. An empty password is not accepted.");
            }
            if (String.IsNullOrEmpty(password))
            {
                // an empty password is not accepted.
                throw ServiceResultException.Create(StatusCodes.BadIdentityTokenRejected,
                    "Security token is not a valid username token. An empty password is not accepted.");
            }

            // User with permission to configure server
            if (user == "sysadmin" && password == "demo")
            {
                return new SystemConfigurationIdentity(new UserIdentity(userNameToken));
            }

            // standard users for CTT verification
            if (!((user == "user1" && password == "password") ||
                (user == "user2" && password == "password1")))

            {
                TranslationInfo info;
                // construct translation object with default text.
                info = new TranslationInfo(
                    "InvalidPassword",
                    "en-US",
                    "Invalid username or password.",
                    user);

                // create an exception with a vendor defined sub-code.
                throw new ServiceResultException(new ServiceResult(
                    StatusCodes.BadUserAccessDenied,
                    "InvalidPassword",
                    LoadServerProperties().ProductUri,
                    new LocalizedText(info)));
            }

            return new UserIdentity(userNameToken);
        }

        #endregion

        #region Private Fields
        private CertificateValidator m_userCertificateValidator;
        #endregion

    }
}
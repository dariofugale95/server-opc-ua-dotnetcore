﻿// this file is based on 
// https://github.com/OPCFoundation/UA-.NETStandard/blob/be65403945d4f0bf366f3299222fcb6cb08d6cb5/SampleApplications/Samples/NetCoreConsoleServer/Program.cs

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

using Opc.Ua;
using Opc.Ua.Configuration;
using Opc.Ua.Server;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Quickstarts.MyOPCServer
{
    public class ServerLauncher
    {
        MyOPCServer server;
        Task status;
        DateTime lastEventTime;
        int serverRunTime = Timeout.Infinite;
        static bool autoAccept = false;
        static ExitCode exitCode;

        OpenWeatherMapDataClass openWeatherData;
        OpenWeatherMapApiRequests openWeatherApiRequest;
        
        public ServerLauncher(bool _autoAccept, int _stopTimeout)
        {
            autoAccept = _autoAccept;
            serverRunTime = _stopTimeout == 0 ? Timeout.Infinite : _stopTimeout * 1000;
        }

        public void Run()
        {
            try
            {
                exitCode = ExitCode.ErrorServerNotStarted;
                ConsoleSampleServer().Wait();
                openWeatherApiRequest = new OpenWeatherMapApiRequests();
                openWeatherData = openWeatherApiRequest.GetWeatherDataByCity("Catania");
                Console.WriteLine("MyOPCServer: I'm trying to connect with OpenWeatherDataMap API");
                if (openWeatherData != null)
                {
                  
                    Console.WriteLine("     OpenweatherApi Response Cod: " + openWeatherData.Cod.ToString());
                    Console.WriteLine("     OpenweatherApi Response Latitude: "+ openWeatherData.Coord.Latitude);
                    Console.WriteLine("     OpenweatherApi Response Longitude: " + openWeatherData.Coord.Longitude);
                    
                    Console.WriteLine("     OpenweatherApi Response Temperature: "+ openWeatherData.Main.Temp);
                    Console.WriteLine("     OpenweatherApi Response MaxTemperature: " + openWeatherData.Main.TempMax);
                    Console.WriteLine("     OpenweatherApi Response MinTemperature: " + openWeatherData.Main.TempMin);
                    Console.WriteLine("     OpenweatherApi Response Pressure: " + openWeatherData.Main.Pressure);
                    Console.WriteLine("     OpenweatherApi Response Humidity: " + openWeatherData.Main.Humidity);
                    Console.WriteLine("     OpenweatherApi Response ID: "+ openWeatherData.Id);
                    Console.WriteLine("     OpenweatherApi Response City: " + openWeatherData.Name);
                    Console.WriteLine("     OpenweatherApi Response Country: "+ openWeatherData.Sys.Country);
                    Console.WriteLine("     OpenweatherApi Response Timezone: "+ openWeatherData.Timezone);
                    
               
                Console.WriteLine("***MyOPCServer: I'm READY*** ");
                }
                

                Console.WriteLine("Server started. Press Ctrl-C to exit...");
                exitCode = ExitCode.ErrorServerRunning;
            }
            catch (Exception ex)
            {
                Utils.Trace("ServiceResultException:" + ex.Message);
                Console.WriteLine("Exception: {0}", ex.Message);
                exitCode = ExitCode.ErrorServerException;
                return;
            }

            ManualResetEvent quitEvent = new ManualResetEvent(false);
            try
            {
                Console.CancelKeyPress += (sender, eArgs) =>
                {
                    quitEvent.Set();
                    eArgs.Cancel = true;
                };
            }
            catch
            {
            }

            // wait for timeout or Ctrl-C
            quitEvent.WaitOne(serverRunTime);

            if (server != null)
            {
                Console.WriteLine("Server stopped. Waiting for exit...");

                using (MyOPCServer _server = server)
                {
                    // Stop status thread
                    server = null;
                    status.Wait();
                    // Stop server and dispose
                    _server.Stop();
                }
            }

            exitCode = ExitCode.Ok;
        }

        public static ExitCode ExitCode { get => exitCode; }

        private static void CertificateValidator_CertificateValidation(CertificateValidator validator, CertificateValidationEventArgs e)
        {
            if (e.Error.StatusCode == StatusCodes.BadCertificateUntrusted)
            {
                e.Accept = autoAccept;
                if (autoAccept)
                {
                    Console.WriteLine("Accepted Certificate: {0}", e.Certificate.Subject);
                }
                else
                {
                    Console.WriteLine("Rejected Certificate: {0}", e.Certificate.Subject);
                }
            }
        }

        private async Task ConsoleSampleServer()
        {
            ApplicationInstance application = new ApplicationInstance();

            application.ApplicationName = "QuickstartsMyOPCServer";
            application.ApplicationType = ApplicationType.Server;
            application.ConfigSectionName = "QuickstartsMyOPCServer";

            // load the application configuration.
            ApplicationConfiguration config = await application.LoadApplicationConfiguration("C:/Users/giuli/Documents/GitHub/server-opc-ua-dotnetcore/OPCServerNETCore/OPCServerNETCore/Quickstarts.MyOPCServer.Config.xml", false);

            // check the application certificate and create if not available.
            bool haveAppCertificate = await application.CheckApplicationInstanceCertificate(false, 0, ushort.MaxValue); // almost unlimited
            if (!haveAppCertificate)
            {
                throw new Exception("Application instance certificate invalid!");
            }

            if (!config.SecurityConfiguration.AutoAcceptUntrustedCertificates)
            {
                config.CertificateValidator.CertificateValidation += new CertificateValidationEventHandler(CertificateValidator_CertificateValidation);
            }

            // start the server.
            server = new MyOPCServer();
            await application.Start(server);

            // start the status thread
            status = Task.Run(new Action(StatusThread));

            // print notification on session events
            server.CurrentInstance.SessionManager.SessionActivated += EventStatus;
            server.CurrentInstance.SessionManager.SessionClosing += EventStatus;
            server.CurrentInstance.SessionManager.SessionCreated += EventStatus;

        }

        private void EventStatus(Session session, SessionEventReason reason)
        {
            lastEventTime = DateTime.UtcNow;
            PrintSessionStatus(session, reason.ToString());
        }

        void PrintSessionStatus(Session session, string reason, bool lastContact = false)
        {
            lock (session.DiagnosticsLock)
            {
                string item = String.Format("{0,9}:{1,20}:", reason, session.SessionDiagnostics.SessionName);
                if (lastContact)
                {
                    item += String.Format("Last Event:{0:HH:mm:ss}", session.SessionDiagnostics.ClientLastContactTime.ToLocalTime());
                }
                else
                {
                    if (session.Identity != null)
                    {
                        item += String.Format(":{0,20}", session.Identity.DisplayName);
                    }
                    item += String.Format(":{0}", session.Id);
                }
                Console.WriteLine(item);
            }
        }

        private async void StatusThread()
        {
            while (server != null)
            {
                if (DateTime.UtcNow - lastEventTime > TimeSpan.FromMilliseconds(6000))
                {
                    IList<Session> sessions = server.CurrentInstance.SessionManager.GetSessions();
                    for (int ii = 0; ii < sessions.Count; ii++)
                    {
                        Session session = sessions[ii];
                        PrintSessionStatus(session, "-Status-", true);
                    }
                    lastEventTime = DateTime.UtcNow;
                }
                await Task.Delay(1000);
            }
        }
    }
}
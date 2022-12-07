﻿using HandmadeHTTPServer.Server.Contracts;
using HandmadeHTTPServer.Server.Routing;
using HandmadeHTTPServer.Server.Routing.Contracts;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace HandmadeHTTPServer.Server
{
    public class WebServer : IRunnable
    {
        private const string localHostIpAddress = "127.0.0.1";
        private readonly int port;
        private readonly IServerRouteConfig serverRouteConfig;
        private readonly TcpListener listener;
        private bool isRunning;

        public WebServer(int port, IAppRouteConfig appRouteConfig)
        {
            this.port = port;

            this.listener = new TcpListener(IPAddress.Parse(localHostIpAddress), port);

            this.serverRouteConfig = new ServerRouteConfig(appRouteConfig);
        }

        public void Run()
        {
            this.listener.Start();
            this.isRunning = true;

            Console.WriteLine($"Server is running on {localHostIpAddress}:{this.port}");

            Task.Run(this.ListenLoop).Wait();
        }

        private async Task ListenLoop()
        {
            while (this.isRunning)
            {
                var client = await this.listener.AcceptSocketAsync();
                var connectionHandler = new ConnectionHandler(client, this.serverRouteConfig);

                await connectionHandler.ProcessRequestAsync();
            }
        }
    }
}
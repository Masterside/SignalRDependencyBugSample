using Microsoft.AspNetCore.Http.Connections;
using Microsoft.AspNetCore.SignalR.Client;
using System;

namespace Client
{
    public class Connector
    {
        public Connector()
        {

        }

        public async void ConnectToServer(string serveruri)
        {
            var connection = new HubConnectionBuilder()
                                .WithUrl(serveruri, options =>
                                {
                                    options.Transports = HttpTransportType.WebSockets;
                                })
                                .Build();

            Console.WriteLine($"Connecting to {serveruri}");
            await connection.StartAsync();
        }
    }
}

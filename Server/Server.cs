using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace Server
{
    public class Server
    {
        private readonly Socket socket;
        private readonly List<ClientHandler> clients = new List<ClientHandler>();

        public Server()
        {
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        }

        public bool Start()
        {
            try
            {
                var endpoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9999);
                socket.Bind(endpoint);
                socket.Listen(5);
                return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(">>>>>" + ex.Message);
                return false;
            }
            
        }

        public void Listen()
        {
            try
            {
                while (true)
                {
                    var klijentskiSocket = socket.Accept();
                    var client = new ClientHandler(klijentskiSocket);
                    clients.Add(client);
                    client.OdjavljenKlijent += Handler_OdjavljenKlijent;
                    var nitKlijenta = new Thread(client.HandleRequests);
                    nitKlijenta.IsBackground = true;
                    nitKlijenta.Start();
                }
            }
            catch (SocketException ex)
            {
                Debug.WriteLine(">>>>>" + ex.Message);               
            }
            
        }

        private void Handler_OdjavljenKlijent(object sender, EventArgs args)
        {
            clients.Remove((ClientHandler)sender);
        }

        public void Stop()
        {
            socket.Close();

            foreach(ClientHandler client in clients.ToList())
            {
                client.CloseSocket();
            }
            clients.Clear();
        }

    }
}

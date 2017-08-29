using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Server
{
    class Server
    {
        Dictionary<string, Client> ClientDictionary = new Dictionary<string, Client>();
        public static Client client;
        TcpListener server;
        public Server()
        {
            server = new TcpListener(IPAddress.Parse("192.168.1.180"), 9999);
            server.Start();
        }
        public void Run()
        {            
            Thread AcceptingNewClients = new Thread(AcceptClient);
            AcceptingNewClients.Start();           
        }
        private void AcceptClient()
        {
            while (true)
            {
                TcpClient clientSocket = default(TcpClient);
                clientSocket = server.AcceptTcpClient();
                Console.WriteLine("Connected");
                NetworkStream stream = clientSocket.GetStream();
                Thread ClientThread = new Thread(CreateClient);
                client = new Client(stream, clientSocket);
                ClientThread.Start();
                //create thread for client
            }
        }

        private void CreateClient()
        {
            client.UserId = client.RecieveUserName();
            Console.WriteLine("Your user name is " + client.UserId);            
            ClientDictionary.Add(client.UserId, client);
            client.SendAndReciveThread.Start();
        }
        private void Respond(string body)
        {
             client.Send(body);
        }
    }
}

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
        public static Client client;
        TcpListener server;
        public Server()
        {
            server = new TcpListener(IPAddress.Parse("192.168.0.136"), 9999);
            server.Start();
        }
        public void Run()
        {
            //parralell with recieve messages thread
            //Thread AcceptingNewClients = new Thread(AcceptClient);
            //AcceptingNewClients.Start();
            //
            Parallel.Invoke(AcceptClient, client.SendAndRecive);
            //wont use here
            //Thread RecievingMessages = new Thread(SecondRun);
            //RecievingMessages.Start();
            //                   
        }
        //public void SecondRun()
        //{
        //    //fix
        //    bool thing = true;
        //    while (thing == true)
        //    {
        //        try
        //        {
        //            string message = client.Recieve();
        //            Respond(message);
        //        }
        //        catch (NullReferenceException)
        //        {
        //            SecondRun();
        //        }
        //    }    
        //}
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
            client.UserId = client.Recieve();
            Dictionary<string, Client> ClientDictionary = new Dictionary<string, Client>();
            ClientDictionary.Add(client.UserId, client);
            //add a thread to client for recieving messages and sending his own??
        }
        private void Respond(string body)
        {
             client.Send(body);
        }
    }
}

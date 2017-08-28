using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace Server
{
    class Client
    {
        NetworkStream stream;
        TcpClient client;
        public string UserId;
        public Thread SendAndReciveThread;
        public Client(NetworkStream Stream, TcpClient Client)
        {
            stream = Stream;
            client = Client;
            UserId = "";
            SendAndReciveThread = new Thread(SendAndRecive);
        }
        public void Send(string Message)
        {
            byte[] message = Encoding.ASCII.GetBytes(Message);
            stream.Write(message, 0, message.Count());
        }
        public string Recieve()
        {
            byte[] recievedMessage = new byte[256];
            stream.Read(recievedMessage, 0, recievedMessage.Length);
            string recievedMessageString = Encoding.ASCII.GetString(recievedMessage);
            Queue<string> MessageQueue = new Queue<string>();
            MessageQueue.Enqueue(recievedMessageString);
            if(MessageQueue.Count > 100)
            {
                MessageQueue.Dequeue();
            }
            Console.WriteLine(recievedMessageString);
            return recievedMessageString;
        }
        public string RecieveUserName()
        {
            byte[] recievedMessage = new byte[256];
            stream.Read(recievedMessage, 0, recievedMessage.Length);
            string recievedMessageString = Encoding.ASCII.GetString(recievedMessage);
            return recievedMessageString;
        }
        public void SendAndRecive()
        {
            //fix
            while (true)
            {
                //try
                //{
                string message = Recieve();
                Send(message);
                //}
                //catch (NullReferenceException)
                //{                                      
                //}
            }
        }
        //public void SendAndRecive()
        //{
        //    while (true)
        //    {
        //        try
        //        {
        //            string message = Recieve();
        //            Send(message);
        //        }
        //        catch (NullReferenceException)
        //        {
        //            SendAndRecive();
        //        }
        //    }
        //}
    }
}

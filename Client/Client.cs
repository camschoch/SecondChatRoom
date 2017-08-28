using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
namespace Client
{
    public class Client
    {
        public ChatRoomGUI chatRoomGUI;
        TcpClient clientSocket;
        NetworkStream stream;
        public Client(string IP, int port)
        {
            this.chatRoomGUI = new ChatRoomGUI(this);
            clientSocket = new TcpClient();
            clientSocket.Connect(IPAddress.Parse(IP), port);
            stream = clientSocket.GetStream();
            Send();
        }
        public void Send()
        {
            while (true)
            {
                string messageString = UI.GetInput();
                byte[] message = Encoding.ASCII.GetBytes(messageString);
                stream.Write(message, 0, message.Count());
            }
        }
        public void Recieve()
        {
            while (true)
            {
                byte[] recievedMessage = new byte[256];
                stream.Read(recievedMessage, 0, recievedMessage.Length);
                UI.DisplayMessage(Encoding.ASCII.GetString(recievedMessage));
            }
        }
        public string UserName()
        {
            Console.WriteLine("UserName");
            string getUserName = Console.ReadLine();
            return getUserName;
        }
        public void ExitKey()
        {

        }

    }
}

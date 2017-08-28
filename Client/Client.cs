using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace Client
{
    public class Client
    {
        
        public bool thing = false;
        public string listBox;
        public string textwords;
        public ChatRoomGUI chatRoomGUI;
        TcpClient clientSocket;
        NetworkStream stream;
        public Client(string IP, int port)
        {
            this.chatRoomGUI = new ChatRoomGUI(this);
            clientSocket = new TcpClient();
            clientSocket.Connect(IPAddress.Parse(IP), port);
            stream = clientSocket.GetStream();
            
        }
        public void Send()
        {
           
            string messageString = textwords;
            byte[] message = Encoding.ASCII.GetBytes(messageString);
            stream.Write(message, 0, message.Count());
            //chatRoomGUI.textBox.Text = null;



        }

        public void Recieve()
        {
            //while (true)
            //{
            byte[] recievedMessage = new byte[256];
            stream.Read(recievedMessage, 0, recievedMessage.Length);
            string message = UI.DisplayMessage(Encoding.ASCII.GetString(recievedMessage));
            chatRoomGUI.thingy = message;
            try
            {
                chatRoomGUI.chatBox.Text += chatRoomGUI.thingy;
            }
            catch (InvalidOperationException)
            {
                chatRoomGUI.RecievingMessages.Join();
                Recieve();
            }
   
            //}
        }
        //public string UserName()
        //{
        //    Console.WriteLine("UserName");
        //    string getUserName = Console.ReadLine();
        //    return getUserName;
        //}
        

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
           
           
                Client client = new Client("192.168.0.156", 9999);
            Application.Run(client.chatRoomGUI);

                client.Send();
                client.Recieve();
                
            
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {            
            Server test = new Server();
            System.Threading.Thread AcceptingNewClients = new System.Threading.Thread(test.Run);
            AcceptingNewClients.IsBackground = true;
            AcceptingNewClients.Start();
            System.Threading.Thread RecievingMessages = new System.Threading.Thread(test.SecondRun);
            RecievingMessages.IsBackground = true;
            RecievingMessages.Start();
            Thread.Sleep(900000);
           
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {
            bool thing = true;
            Server test = new Server();
            System.Threading.Thread AcceptingNewClients = new System.Threading.Thread(test.Run);
            AcceptingNewClients.Start();
            while(thing == true)
            {
                test.SecondRun();
            }
            Console.ReadLine();
        }
    }
}

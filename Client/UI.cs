﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    public static class UI
    {
        public static string DisplayMessage(string message)
        {
            return message;
        }
        public static string GetInput()
        {
            return Console.ReadLine();
        }
    }
}

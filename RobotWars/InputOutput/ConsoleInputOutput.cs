﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotWars.InputOutput
{
    public class ConsoleInputOutput : IInputOutput
    {
        public string ReadInput()
        {
            return Console.ReadLine();
        }

        public void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}

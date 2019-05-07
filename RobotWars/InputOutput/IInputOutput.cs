using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotWars.InputOutput
{
    public interface IInputOutput
    {
        string ReadInput();

        void PrintMessage(string message);
    }
}

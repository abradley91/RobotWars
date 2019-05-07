using RobotWars.Commands;
using RobotWars.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotWars.Interfaces
{
    public interface IRobot
    {
        int X { get; set; }
        int Y { get; set; }
        Direction Direction { get; set; }

        void Move();
        void TurnLeft();
        void TurnRight();

        string ToString();
    }
}

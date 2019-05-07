using RobotWars.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotWars.Controller
{
    public class RobotController : IRobotController
    {
        private IRobot _robot;

        public RobotController(IRobot robot)
        {
            _robot = robot;
        }

        public void SendRobotCommands(string commands)
        {
            foreach (char c in commands.ToUpper())
            {
                switch (c)
                {
                    case 'M': _robot.Move();
                        break;
                    case 'R': _robot.TurnRight();
                        break;
                    case 'L': _robot.TurnLeft();
                        break;
                    default:
                        break;
                }
            }
        }
    }
}

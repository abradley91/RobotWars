using RobotWars.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotWars.Commands
{
    public abstract class RobotCommand : IRobotCommand
    {
        protected IRobot _robot;
        public RobotCommand(IRobot robot)
        {
            _robot = robot;
        }

        public abstract void Execute();
    }
}

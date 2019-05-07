using RobotWars.Enums;
using RobotWars.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotWars.Commands
{
    public class TurnRightCommand : RobotCommand
    {
        public TurnRightCommand(IRobot robot) : base(robot) { }

        public override void Execute()
        {
            if (_robot.Direction == Direction.W)
            {
                _robot.Direction = Direction.N;
            }
            else
            {
                _robot.Direction++;
            }
        }
    }
}

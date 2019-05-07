using RobotWars.Enums;
using RobotWars.Interfaces;

namespace RobotWars.Commands
{
    public class TurnLeftCommand : RobotCommand
    {
        public TurnLeftCommand(IRobot robot) : base(robot) { }

        public override void Execute()
        {
            if (_robot.Direction == Direction.N)
            {
                _robot.Direction = Direction.W;
            }
            else
            {
                _robot.Direction--;
            }
        }
    }
}

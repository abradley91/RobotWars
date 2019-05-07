using RobotWars.Enums;
using RobotWars.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotWars.Commands
{
    public class MoveCommand : RobotCommand
    {
        private IArena _arena;
        public MoveCommand(IRobot robot, IArena arena) : base(robot)
        {
            _arena = arena;
        }

        public override void Execute()
        {
            switch (_robot.Direction)
            {
                case Direction.N:
                    if (_robot.Y < _arena.Height) _robot.Y++;
                    break;
                case Direction.E:
                    if (_robot.X < _arena.Width) _robot.X++;
                    break;
                case Direction.S:
                    if (_robot.Y > 0) _robot.Y--;
                    break;
                case Direction.W:
                    if (_robot.X > 0) _robot.X--;
                    break;
                default:
                    break;
            }
        }
    }
}

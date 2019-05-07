using RobotWars.Commands;
using RobotWars.Enums;
using RobotWars.Interfaces;
using System;

namespace RobotWars
{
    public class Robot : IRobot
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Direction Direction { get; set; }
        
        private IRobotCommand _moveCommand;
        private IRobotCommand _turnLeftCommand;
        private IRobotCommand _turnRightCommand;

        public Robot(int x, int y, Direction direction, IArena arena)
        {
            if(!arena.IsInsideArenaBounds(x, y))
            {
                throw new Exception("Robot outside arena bounds.");
            }

            X = x;
            Y = y;
            Direction = direction;

            _moveCommand = new MoveCommand(this, arena);
            _turnLeftCommand = new TurnLeftCommand(this);
            _turnRightCommand = new TurnRightCommand(this);
        }

        public void Move()
        {
            _moveCommand.Execute();
        }

        public void TurnLeft()
        {
            _turnLeftCommand.Execute();
        }

        public void TurnRight()
        {
            _turnRightCommand.Execute();
        }

        public override string ToString()
        {
            return $"{X} {Y} {Direction}";
        }
    }
}

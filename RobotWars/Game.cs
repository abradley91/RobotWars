using RobotWars.Enums;
using RobotWars.InputOutput;
using RobotWars.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotWars
{
    public class Game
    {
        private IInputOutput _inputOutput;

        public Game(IInputOutput inputOutput)
        {
            _inputOutput = inputOutput;
        }

        public Arena SetupArena()
        {
            string[] arenaValues = new string[0];

            while(arenaValues.Length != 2)
            {
                _inputOutput.PrintMessage("Enter arena dimensions:");

                string arenaString = _inputOutput.ReadInput();

                arenaValues = arenaString.Split(' ');
            }

            int x, y;
            if(Int32.TryParse(arenaValues[0], out x) && Int32.TryParse(arenaValues[1], out y))
            {
                return new Arena(Int32.Parse(arenaValues[0]), Int32.Parse(arenaValues[1]));
            }

            return null;
        }

        public Robot SetupRobot(Arena arena)
        {
            string[] robotValues = new string[0];

            while (robotValues.Length != 3)
            {
                _inputOutput.PrintMessage("Enter robot start position (e.g. 1 2 N):");

                string robotString = _inputOutput.ReadInput();

                robotValues = robotString.Split(' ');
            }

            if (Int32.TryParse(robotValues[0], out int x) && Int32.TryParse(robotValues[1], out int y) && Enum.TryParse(robotValues[2], out Direction direction))
            {
                return new Robot(x, y, direction, arena);
            }

            return null;
        }

        public string GetRobotMoves()
        {
            _inputOutput.PrintMessage("Enter robot movements:");
            return _inputOutput.ReadInput();
        }

        public void PrintRobotLocation(IRobot robot)
        {
            _inputOutput.PrintMessage(robot.ToString());
        }
    }
}

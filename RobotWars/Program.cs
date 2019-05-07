using RobotWars.InputOutput;
using RobotWars.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotWars
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game(new ConsoleInputOutput());

            Arena arena = game.SetupArena();

            for(int i = 0; i < 2; i++)
            {
                Robot robot = game.SetupRobot(arena);

                IRobotController controller = new RobotController(robot);
                controller.SendRobotCommands(game.GetRobotMoves());

                game.PrintRobotLocation(robot);
            }
            
            Console.ReadLine();
        }
    }
}

using NUnit.Framework;
using RobotWars.Enums;
using System;

namespace RobotWars.Tests
{
    [TestFixture]
    public class RobotTurnTests
    {
        private Arena _arena;

        [SetUp]
        public void Setup()
        {
            _arena = new Arena(5, 5);
        }
        
        [Test]
        public void IfRobotNorth_WhenTurnRight_RobotShouldFaceEast()
        {
            Robot robot = new Robot(0, 0, Direction.N, _arena);

            robot.TurnRight();

            Assert.AreEqual(Direction.E, robot.Direction);
        }

        [Test]
        public void IfRobotWest_WhenTurnRight_RobotShouldFaceNorth()
        {
            Robot robot = new Robot(0, 0, Direction.W, _arena);

            robot.TurnRight();

            Assert.AreEqual(Direction.N, robot.Direction);
        }

        [Test]
        public void IfRobotSouth_WhenTurnLeft_RobotShouldFaceEast()
        {
            Robot robot = new Robot(0, 0, Direction.S, _arena);

            robot.TurnLeft();

            Assert.AreEqual(Direction.E, robot.Direction);
        }

        [Test]
        public void IfRobotNorth_WhenTurnLeft_RobotShouldFaceWest()
        {
            Robot robot = new Robot(0, 0, Direction.N, _arena);

            robot.TurnLeft();

            Assert.AreEqual(Direction.W, robot.Direction);
        }
    }
}

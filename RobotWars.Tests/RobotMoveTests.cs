using NUnit.Framework;
using RobotWars.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotWars.Tests
{
    [TestFixture]
    public class RobotMoveTests
    {
        private Arena _arena;

        [SetUp]
        public void Setup()
        {
            _arena = new Arena(5, 5);
        }

        [Test]
        public void WhenRobotMovesNorth_ThenYShouldIncrease()
        {
            int x = 0;
            int y = 0;

            Robot robot = new Robot(x, y, Direction.N, _arena);

            robot.Move();

            Assert.AreEqual(y + 1, robot.Y);
            Assert.AreEqual(x, robot.X);
        }

        [Test]
        public void WhenRobotMovesSouth_ThenYShouldDecrease()
        {
            int x = 2;
            int y = 2;
            Robot robot = new Robot(x, y, Direction.S, _arena);

            robot.Move();

            Assert.AreEqual(y - 1, robot.Y);
            Assert.AreEqual(x, robot.X);
        }

        [Test]
        public void WhenRobotMovesEast_ThenXShouldIncrease()
        {
            int x = 0;
            int y = 0;
            Robot robot = new Robot(x, y, Direction.E, _arena);

            robot.Move();

            Assert.AreEqual(x + 1, robot.X);
            Assert.AreEqual(y, robot.Y);
        }

        [Test]
        public void WhenRobotMovesWest_ThenXShouldDecrease()
        {
            int x = 2;
            int y = 2;
            Robot robot = new Robot(x, y, Direction.W, _arena);

            robot.Move();

            Assert.AreEqual(x - 1, robot.X);
            Assert.AreEqual(y, robot.Y);
        }

        [Test]
        public void IfRobotYIs0_WhenMoveSouth_ShouldNotMove()
        {
            int x = 0;
            int y = 0;
            Robot robot = new Robot(x, y, Direction.S, _arena);

            robot.Move();

            Assert.AreEqual(x, robot.X);
            Assert.AreEqual(y, robot.Y);
        }

        [Test]
        public void IfRobotYIsAtArenaYLimit_WhenMoveNorth_ShouldNotMove()
        {
            int x = 0;
            int y = _arena.Height;
            Robot robot = new Robot(x, y, Direction.N, _arena);

            robot.Move();

            Assert.AreEqual(x, robot.X);
            Assert.AreEqual(y, robot.Y);
        }

        [Test]
        public void IfRobotXIsAt0_WhenMoveWest_ShouldNotMove()
        {
            int x = 0;
            int y = 0;
            Robot robot = new Robot(x, y, Direction.W, _arena);

            robot.Move();

            Assert.AreEqual(x, robot.X);
            Assert.AreEqual(y, robot.Y);
        }

        [Test]
        public void IfRobotXIsAtArenaXLimit_WhenMoveEast_ShouldNotMove()
        {
            int x = _arena.Width;
            int y = 0;
            Robot robot = new Robot(x, y, Direction.E, _arena);

            robot.Move();

            Assert.AreEqual(x, robot.X);
            Assert.AreEqual(y, robot.Y);
        }
    }
}

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
    public class RobotTests
    {
        private Arena _arena;

        [SetUp]
        public void Setup()
        {
            _arena = new Arena(5, 5);
        }

        [Test]
        public void WhenRobotCreated_IfRobotCoordsAreInsideArena_CreateRobot()
        {
            Robot robot = new Robot(0,0,Direction.N, _arena);

            Assert.IsNotNull(robot);
        }

        [Test]
        public void WhenRobotCreated_IfRobotCoordsAreOutsideArena_ThrowException()
        {
            var exception = Assert.Throws<Exception>(() => new Robot(-1, -1, Direction.N, _arena));

            Assert.That(exception.Message, Is.EqualTo("Robot outside arena bounds."));
        }

        [Test]
        public void IfRobot11N_WhenToString_ThenReturnShouldBe11N()
        {
            string expectedString = "1 1 N";
            Robot robot = new Robot(1, 1, Direction.N, _arena);

            var result = robot.ToString();

            Assert.AreEqual(expectedString, result);
        }
    }
}

using Moq;
using NUnit.Framework;
using RobotWars.Controller;
using RobotWars.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotWars.Tests
{
    [TestFixture]
    public class RobotContollerTests
    {
        RobotController _robotController;
        Mock<IRobot> _mockRobot;

        [SetUp]
        public void Setup()
        {
            _mockRobot = new Mock<IRobot>();
            _robotController = new RobotController(_mockRobot.Object);
        }

        [Test]
        public void IfSendCommands_WhenCommandIsM_RobotMoveShouldBeCalled()
        {
            _robotController.SendRobotCommands("M");

            _mockRobot.Verify(x => x.Move());
        }

        [Test]
        public void IfSendCommands_WhenCommandIsL_RobotTurnLeftShouldBeCalled()
        {
            _robotController.SendRobotCommands("L");

            _mockRobot.Verify(x => x.TurnLeft());
        }

        [Test]
        public void IfSendCommands_WhenCommandIsR_RobotTurnRightShouldBeCalled()
        {
            _robotController.SendRobotCommands("R");

            _mockRobot.Verify(x => x.TurnRight());
        }

        [Test]
        public void IfSendCommands_WhenCommandIsMRL_CorrectRobotActionsShouldBeCalled()
        {
            _robotController.SendRobotCommands("MRL");

            _mockRobot.Verify(x => x.Move());
            _mockRobot.Verify(x => x.TurnRight());
            _mockRobot.Verify(x => x.TurnLeft());
        }
    }
}

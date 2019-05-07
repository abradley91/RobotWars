using System;
using NUnit.Framework;

namespace RobotWars.Tests
{
    [TestFixture]
    public class ArenaTests
    {
        [TestCase(1, 1)]
        [TestCase(5, 10)]
        [TestCase(10, 5)]
        public void WhenArenaCreated_ShouldReturnCorrectDimensions(int x, int y)
        {
            Arena arena = new Arena(x, y);

            Assert.AreEqual(x, arena.Width);
            Assert.AreEqual(y, arena.Height);
        }

        [Test]
        public void WhenArenaCreatedWithInvalidValues_ShouldThrowException()
        {
            var exception = Assert.Throws<Exception>(() => new Arena(-1, -1));

            Assert.That(exception.Message, Is.EqualTo("Arena inputs are invalid."));
        }

        [TestCase(0, 0)]
        [TestCase(1, 3)]
        [TestCase(5, 0)]
        [TestCase(0, 5)]
        [TestCase(5, 5)]
        public void IfIsInsideArenaBounds_WhenInputsAreWithinBounds_ShouldReturnTrue(int x, int y)
        {
            Arena arena = new Arena(5, 5);

            var result = arena.IsInsideArenaBounds(x, y);

            Assert.IsTrue(result);
        }

        [TestCase(-1, -1)]
        [TestCase(0, -1)]
        [TestCase(-1, 0)]
        [TestCase(6, 5)]
        [TestCase(5, 6)]
        [TestCase(6, 6)]
        public void IfIsInsideArenaBounds_WhenInputsAreOutsideBounds_ShouldReturnFalse(int x, int y)
        {
            Arena arena = new Arena(5, 5);

            var result = arena.IsInsideArenaBounds(x, y);

            Assert.IsFalse(result);
        }
    }
}

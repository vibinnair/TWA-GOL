using NUnit.Framework;

namespace TW.Assignment.GameOfLife.Tests
{
    [TestFixture]
    public class GameOfLifeTests
    {
        private Universe universe;

        [SetUp]
        public void Init()
        {
            
        }

        [Test]
        public void TestBlockPattern()
        {
            universe = new Universe(2);

            universe.addCell(0, 0, CellState.ALIVE);
            universe.addCell(0, 1, CellState.ALIVE);
            universe.addCell(1, 0, CellState.ALIVE);
            universe.addCell(1, 1, CellState.ALIVE);

            universe.tick();

            Assert.AreEqual(universe.getCellState(0, 0), CellState.ALIVE);
            Assert.AreEqual(universe.getCellState(0, 1), CellState.ALIVE);
            Assert.AreEqual(universe.getCellState(1, 0), CellState.ALIVE);
            Assert.AreEqual(universe.getCellState(1, 1), CellState.ALIVE);
        }


        [Test]
        public void TestAnotherPattern()
        {
            universe = new Universe(2);

            universe.addCell(0, 0, CellState.ALIVE);
            universe.addCell(0, 1, CellState.DEAD);
            universe.addCell(1, 0, CellState.ALIVE);
            universe.addCell(1, 1, CellState.ALIVE);

            universe.tick();

            Assert.AreEqual(universe.getCellState(0, 0), CellState.ALIVE);
            Assert.AreEqual(universe.getCellState(0, 1), CellState.ALIVE);
            Assert.AreEqual(universe.getCellState(1, 0), CellState.ALIVE);
            Assert.AreEqual(universe.getCellState(1, 1), CellState.ALIVE);
        }


        [Test]
        public void OneMoreAnotherPattern()
        {
            universe = new Universe(2);

            universe.addCell(0, 0, CellState.DEAD);
            universe.addCell(0, 1, CellState.ALIVE);
            universe.addCell(1, 0, CellState.ALIVE);
            universe.addCell(1, 1, CellState.DEAD);

            universe.tick();

            Assert.AreEqual(universe.getCellState(0, 0), CellState.DEAD);
            Assert.AreEqual(universe.getCellState(0, 1), CellState.DEAD);
            Assert.AreEqual(universe.getCellState(1, 0), CellState.DEAD);
            Assert.AreEqual(universe.getCellState(1, 1), CellState.DEAD);
        }
    }   
}

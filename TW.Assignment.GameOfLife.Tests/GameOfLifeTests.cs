using NUnit.Framework;

namespace TW.Assignment.GameOfLife.Tests
{
    [TestFixture]
    public class GameOfLifeTests
    {
        private Universe universe;       

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
        public void TestBloatPattern()
        {
            universe = new Universe(3);

            universe.addCell(0, 0, CellState.ALIVE);
            universe.addCell(0, 1, CellState.ALIVE);
            universe.addCell(0, 2, CellState.DEAD);
            universe.addCell(1, 0, CellState.ALIVE);
            universe.addCell(1, 1, CellState.DEAD);
            universe.addCell(1, 2, CellState.ALIVE);
            universe.addCell(2, 0, CellState.DEAD);
            universe.addCell(2, 1, CellState.ALIVE);
            universe.addCell(2, 2, CellState.DEAD);

            universe.tick();

            Assert.AreEqual(universe.getCellState(0, 0), CellState.ALIVE);
            Assert.AreEqual(universe.getCellState(0, 1), CellState.ALIVE);
            Assert.AreEqual(universe.getCellState(0, 2), CellState.DEAD);
            Assert.AreEqual(universe.getCellState(1, 0), CellState.ALIVE);
            Assert.AreEqual(universe.getCellState(1, 1), CellState.DEAD);
            Assert.AreEqual(universe.getCellState(1, 2), CellState.ALIVE);
            Assert.AreEqual(universe.getCellState(2, 0), CellState.DEAD);
            Assert.AreEqual(universe.getCellState(2, 1), CellState.ALIVE);
            Assert.AreEqual(universe.getCellState(2, 2), CellState.DEAD);
        }


        [Test]
        public void TestBlinkerPattern()
        {
            universe = new Universe(3);

            universe.addCell(0, 0, CellState.DEAD);
            universe.addCell(0, 1, CellState.ALIVE);
            universe.addCell(0, 2, CellState.DEAD);
            universe.addCell(1, 0, CellState.DEAD);
            universe.addCell(1, 1, CellState.ALIVE);
            universe.addCell(1, 2, CellState.DEAD);
            universe.addCell(2, 0, CellState.DEAD);
            universe.addCell(2, 1, CellState.ALIVE);
            universe.addCell(2, 2, CellState.DEAD);

            universe.tick();

            Assert.AreEqual(universe.getCellState(0, 0), CellState.DEAD);
            Assert.AreEqual(universe.getCellState(0, 1), CellState.DEAD);
            Assert.AreEqual(universe.getCellState(0, 2), CellState.DEAD);
            Assert.AreEqual(universe.getCellState(1, 0), CellState.ALIVE);
            Assert.AreEqual(universe.getCellState(1, 1), CellState.ALIVE);
            Assert.AreEqual(universe.getCellState(1, 2), CellState.ALIVE);
            Assert.AreEqual(universe.getCellState(2, 0), CellState.DEAD);
            Assert.AreEqual(universe.getCellState(2, 1), CellState.DEAD);
            Assert.AreEqual(universe.getCellState(2, 2), CellState.DEAD);
        }


        [Test]
        public void TestToadPattern()
        {
            universe = new Universe(4);

            universe.addCell(0, 0, CellState.DEAD);
            universe.addCell(0, 1, CellState.DEAD);
            universe.addCell(0, 2, CellState.DEAD);
            universe.addCell(0, 3, CellState.DEAD);

            universe.addCell(1, 0, CellState.DEAD);
            universe.addCell(1, 1, CellState.ALIVE);
            universe.addCell(1, 2, CellState.ALIVE);
            universe.addCell(1, 3, CellState.ALIVE);

            universe.addCell(2, 0, CellState.ALIVE);
            universe.addCell(2, 1, CellState.ALIVE);
            universe.addCell(2, 2, CellState.ALIVE);
            universe.addCell(2, 3, CellState.DEAD);

            universe.addCell(3, 0, CellState.DEAD);
            universe.addCell(3, 1, CellState.DEAD);
            universe.addCell(3, 2, CellState.DEAD);
            universe.addCell(3, 3, CellState.DEAD);

            universe.tick();

            Assert.AreEqual(universe.getCellState(0, 0), CellState.DEAD);
            Assert.AreEqual(universe.getCellState(0, 1), CellState.DEAD);
            Assert.AreEqual(universe.getCellState(0, 2), CellState.ALIVE);
            Assert.AreEqual(universe.getCellState(0, 3), CellState.DEAD);

            Assert.AreEqual(universe.getCellState(1, 0), CellState.ALIVE);
            Assert.AreEqual(universe.getCellState(1, 1), CellState.DEAD);
            Assert.AreEqual(universe.getCellState(1, 2), CellState.DEAD);
            Assert.AreEqual(universe.getCellState(1, 3), CellState.ALIVE);

            Assert.AreEqual(universe.getCellState(2, 0), CellState.ALIVE);
            Assert.AreEqual(universe.getCellState(2, 1), CellState.DEAD);
            Assert.AreEqual(universe.getCellState(2, 2), CellState.DEAD);
            Assert.AreEqual(universe.getCellState(2, 3), CellState.ALIVE);

            Assert.AreEqual(universe.getCellState(3, 0), CellState.DEAD);
            Assert.AreEqual(universe.getCellState(3, 1), CellState.ALIVE);
            Assert.AreEqual(universe.getCellState(3, 2), CellState.DEAD);
            Assert.AreEqual(universe.getCellState(3, 3), CellState.DEAD);
        }
    }
}

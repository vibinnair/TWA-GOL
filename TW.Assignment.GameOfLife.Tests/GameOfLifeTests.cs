using NUnit.Framework;

namespace TW.Assignment.GameOfLife.Tests
{
    [TestFixture]
    public class GameOfLifeTests
    {
        private Universe universe;
        private CellList seed;

        [SetUp]
        public void Init()
        {
            universe = new Universe();

            seed = null;
        }

        [Test]
        public void TestBlockPattern()
        {
            seed = new CellList(2);
            seed.addCell(0, 0, CellState.ALIVE);
            seed.addCell(0, 1, CellState.ALIVE);
            seed.addCell(1, 0, CellState.ALIVE);
            seed.addCell(1, 1, CellState.ALIVE);

            CellList firstGeneration = performTick();

            Assert.AreEqual(firstGeneration.getCellState(0, 0), CellState.ALIVE);
            Assert.AreEqual(firstGeneration.getCellState(0, 1), CellState.ALIVE);
            Assert.AreEqual(firstGeneration.getCellState(1, 0), CellState.ALIVE);
            Assert.AreEqual(firstGeneration.getCellState(1, 1), CellState.ALIVE);
        }      


        [Test]
        public void TestBloatPattern()
        {
            seed = new CellList(3);            
            seed.addCell(0, 0, CellState.ALIVE);
            seed.addCell(0, 1, CellState.ALIVE);
            seed.addCell(0, 2, CellState.DEAD);
            seed.addCell(1, 0, CellState.ALIVE);
            seed.addCell(1, 1, CellState.DEAD);
            seed.addCell(1, 2, CellState.ALIVE);
            seed.addCell(2, 0, CellState.DEAD);
            seed.addCell(2, 1, CellState.ALIVE);
            seed.addCell(2, 2, CellState.DEAD);

            CellList firstGeneration = performTick();

            Assert.AreEqual(firstGeneration.getCellState(0, 0), CellState.ALIVE);
            Assert.AreEqual(firstGeneration.getCellState(0, 1), CellState.ALIVE);
            Assert.AreEqual(firstGeneration.getCellState(0, 2), CellState.DEAD);
            Assert.AreEqual(firstGeneration.getCellState(1, 0), CellState.ALIVE);
            Assert.AreEqual(firstGeneration.getCellState(1, 1), CellState.DEAD);
            Assert.AreEqual(firstGeneration.getCellState(1, 2), CellState.ALIVE);
            Assert.AreEqual(firstGeneration.getCellState(2, 0), CellState.DEAD);
            Assert.AreEqual(firstGeneration.getCellState(2, 1), CellState.ALIVE);
            Assert.AreEqual(firstGeneration.getCellState(2, 2), CellState.DEAD);
        }


        [Test]
        public void TestBlinkerPattern()
        {
            seed = new CellList(3);
            seed.addCell(0, 0, CellState.DEAD);
            seed.addCell(0, 1, CellState.ALIVE);
            seed.addCell(0, 2, CellState.DEAD);
            seed.addCell(1, 0, CellState.DEAD);
            seed.addCell(1, 1, CellState.ALIVE);
            seed.addCell(1, 2, CellState.DEAD);
            seed.addCell(2, 0, CellState.DEAD);
            seed.addCell(2, 1, CellState.ALIVE);
            seed.addCell(2, 2, CellState.DEAD);                       

            CellList firstGeneration = performTick();

            Assert.AreEqual(firstGeneration.getCellState(0, 0), CellState.DEAD);
            Assert.AreEqual(firstGeneration.getCellState(0, 1), CellState.DEAD);
            Assert.AreEqual(firstGeneration.getCellState(0, 2), CellState.DEAD);
            Assert.AreEqual(firstGeneration.getCellState(1, 0), CellState.ALIVE);
            Assert.AreEqual(firstGeneration.getCellState(1, 1), CellState.ALIVE);
            Assert.AreEqual(firstGeneration.getCellState(1, 2), CellState.ALIVE);
            Assert.AreEqual(firstGeneration.getCellState(2, 0), CellState.DEAD);
            Assert.AreEqual(firstGeneration.getCellState(2, 1), CellState.DEAD);
            Assert.AreEqual(firstGeneration.getCellState(2, 2), CellState.DEAD);
        }


        [Test]
        public void TestToadPattern()
        {
            seed = new CellList(4);
            seed.addCell(0, 0, CellState.DEAD);
            seed.addCell(0, 1, CellState.DEAD);
            seed.addCell(0, 2, CellState.DEAD);
            seed.addCell(0, 3, CellState.DEAD);
            seed.addCell(1, 0, CellState.DEAD);
            seed.addCell(1, 1, CellState.ALIVE);
            seed.addCell(1, 2, CellState.ALIVE);
            seed.addCell(1, 3, CellState.ALIVE);
            seed.addCell(2, 0, CellState.ALIVE);
            seed.addCell(2, 1, CellState.ALIVE);
            seed.addCell(2, 2, CellState.ALIVE);
            seed.addCell(2, 3, CellState.DEAD);
            seed.addCell(3, 0, CellState.DEAD);
            seed.addCell(3, 1, CellState.DEAD);
            seed.addCell(3, 2, CellState.DEAD);
            seed.addCell(3, 3, CellState.DEAD);                      

            CellList firstGeneration = performTick();

            Assert.AreEqual(firstGeneration.getCellState(0, 0), CellState.DEAD);
            Assert.AreEqual(firstGeneration.getCellState(0, 1), CellState.DEAD);
            Assert.AreEqual(firstGeneration.getCellState(0, 2), CellState.ALIVE);
            Assert.AreEqual(firstGeneration.getCellState(0, 3), CellState.DEAD);
            Assert.AreEqual(firstGeneration.getCellState(1, 0), CellState.ALIVE);
            Assert.AreEqual(firstGeneration.getCellState(1, 1), CellState.DEAD);
            Assert.AreEqual(firstGeneration.getCellState(1, 2), CellState.DEAD);
            Assert.AreEqual(firstGeneration.getCellState(1, 3), CellState.ALIVE);
            Assert.AreEqual(firstGeneration.getCellState(2, 0), CellState.ALIVE);
            Assert.AreEqual(firstGeneration.getCellState(2, 1), CellState.DEAD);
            Assert.AreEqual(firstGeneration.getCellState(2, 2), CellState.DEAD);
            Assert.AreEqual(firstGeneration.getCellState(2, 3), CellState.ALIVE);
            Assert.AreEqual(firstGeneration.getCellState(3, 0), CellState.DEAD);
            Assert.AreEqual(firstGeneration.getCellState(3, 1), CellState.ALIVE);
            Assert.AreEqual(firstGeneration.getCellState(3, 2), CellState.DEAD);
            Assert.AreEqual(firstGeneration.getCellState(3, 3), CellState.DEAD);
        }


        private CellList performTick()
        {
            universe.setSeed(seed);

            universe.tick();

            return universe.getFirstGeneration();
        }
    }
}

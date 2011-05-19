namespace TW.Assignment.GameOfLife
{
    public class Universe
    {
        private CellList cellList;
        

        public void setSeed(CellList cellList)
        {
            this.cellList = cellList;
        }               

        public void tick()
        {
            cellList.assignNeighboursToAllCells();

            cellList.tickCells();
        }      
        
        public CellList getFirstGeneration()
        {
            return cellList;
        }
    }
}

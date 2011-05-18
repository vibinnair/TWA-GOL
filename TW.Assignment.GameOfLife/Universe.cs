using System.Collections.Generic;

namespace TW.Assignment.GameOfLife
{
    public class Universe
    {
        private CellList cellList;
       
        
        public Universe(int size)
        {
            cellList = new CellList(size);
        }


        public void addCell(int xPosition, int yPosition, CellState state)
        {
            cellList.addCell(xPosition, yPosition, state);
        }


        public void tick()
        {
            cellList.setNeighbours();

            tickCells();
        }

        private void tickCells()
        {
            foreach (Cell cell in cellList)
            {
                cell.tick();
            }
        }
       

        public CellState getCellState(int xPosition, int yPosition)
        {
            Cell cell = cellList.getCell(xPosition, yPosition);

            return cell.getState();
        }


    }
}

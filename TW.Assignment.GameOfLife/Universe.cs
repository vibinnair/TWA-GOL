using System;
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
            cellList.assignNeighboursToAllCells();

            cellList.tickCells();
        }      
        

        public CellState getCellState(int xPosition, int yPosition)
        {
            return cellList.getCellState(xPosition, yPosition);
        }
    }
}

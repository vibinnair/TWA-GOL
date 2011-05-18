using System;
using System.Collections.Generic;
using System.Text;

namespace TW.Assignment.GameOfLife
{
    public class AliveState : State
    {
        private Cell cell;

        public AliveState(Cell cell)
        {
            this.cell = cell;
        }

        public void tick()
        {
            if (cell.getAliveNeighbours() < 2) 
            {
                cell.setState(CellState.DEAD);
                return;
            }

            if (cell.getAliveNeighbours() > 3)
            {
                cell.setState(CellState.DEAD);
                return;
            }

        }

        public CellState getState()
        {
            return CellState.ALIVE;
        }
    }
}

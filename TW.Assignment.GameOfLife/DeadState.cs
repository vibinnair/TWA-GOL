using System;
using System.Collections.Generic;
using System.Text;

namespace TW.Assignment.GameOfLife
{
    public class DeadState : State
    {
        private Cell cell;

        public DeadState(Cell cell)
        {
            this.cell = cell;
        }

        public CellState getState()
        {
            return CellState.DEAD;
        }

        public void tick()
        {
            if (cell.getAliveNeighbours() == 3)
            {
                cell.setState(CellState.ALIVE);
            }
        }
    }
}

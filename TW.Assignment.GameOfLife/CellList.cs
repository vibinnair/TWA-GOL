using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace TW.Assignment.GameOfLife
{
    public class CellList : System.Collections.IEnumerable
    {
        Cell[,] cells;

        public CellList(int size)
        {
            cells = new Cell[size, size];
        }

        public void addCell(int xPosition, int yPosition, CellState state)
        {
            Cell cell = new Cell();

            cell.setState(state);

            this.cells[xPosition, yPosition] = cell;
        }

        public void setNeighbours()
        {
            Cell cell = this.cells[0, 0];
            cell.addNeighbour(this.cells[0, 1]);
            cell.addNeighbour(this.cells[1, 0]);
            cell.addNeighbour(this.cells[1, 1]);


            cell = this.cells[0, 1];
            cell.addNeighbour(this.cells[0, 0]);
            cell.addNeighbour(this.cells[1, 0]);
            cell.addNeighbour(this.cells[1, 1]);

            cell = this.cells[1, 0];
            cell.addNeighbour(this.cells[0, 0]);
            cell.addNeighbour(this.cells[0, 1]);
            cell.addNeighbour(this.cells[1, 1]);

            cell = this.cells[1, 1];
            cell.addNeighbour(this.cells[0, 0]);
            cell.addNeighbour(this.cells[0, 1]);
            cell.addNeighbour(this.cells[1, 0]);
        }

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    yield return cells[i,j];    
                }
                
            }
        }

        public Cell getCell(int xPosition, int yPosition)
        {
            return cells[xPosition, yPosition];
        }
    }
}

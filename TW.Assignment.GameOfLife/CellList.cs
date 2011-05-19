using System;
using System.Collections;
using TW.Assignment.GameOfLife.Strategy;

namespace TW.Assignment.GameOfLife
{
    public class CellList
    {
        Cell[,] cells;
        private int minPosition;
        private int maxPosition;

        public CellList(int size)
        {
            cells = new Cell[size, size];
            
            this.minPosition = 0;
            this.maxPosition = size - 1;
        }

        public void addCell(int xPosition, int yPosition, CellState state)
        {
            Cell cell = new Cell(xPosition, yPosition);

            cell.setState(state);

            this.cells[xPosition, yPosition] = cell;
        }

        public void assignNeighboursToAllCells()
        {
            for (int xPosition = 0; xPosition <= this.maxPosition; xPosition++)
            {
                for (int yPosition = 0; yPosition <= this.maxPosition; yPosition++)
                {
                    IStrategy strategy = getStrategyFor(xPosition, yPosition);

                    // Note : put cell up and getStrategyFor(Cell);
                    Cell cell = cells[xPosition, yPosition];

                    cell.addNeighbours(strategy.getNeighbours());
                }
            }
        }

        private IStrategy getStrategyFor(int xPosition, int yPosition)
        {
            if(xPosition == this.minPosition && yPosition == this.minPosition)
            {
                return new FirstRowFirstColumnStrategy(this, xPosition, yPosition);
            }

            if(xPosition == this.minPosition && yPosition == this.maxPosition)
            {
                return new FirstRowLastColumnStrategy(this, xPosition, yPosition);
            }

            if (xPosition == this.maxPosition && yPosition == this.minPosition)
            {
                return new LastRowFirstColumnStrategy(this, xPosition, yPosition);
            }

            if (xPosition == this.maxPosition && yPosition == this.maxPosition)
            {
                return new LastRowLastColumnStrategy(this, xPosition, yPosition);
            }

            if (xPosition == this.minPosition)
            {
                return new FirstRowAnyColumnStrategy(this, xPosition, yPosition);
            }

            if (xPosition == this.maxPosition)
            {
                return new LastRowAnyColumnStrategy(this, xPosition, yPosition);
            }

            if (yPosition == this.minPosition)
            {
                return new FirstColumnAnyRowStrategy(this, xPosition, yPosition);
            }

            if (yPosition == this.maxPosition)
            {
                return new LastColumnAnyRowStrategy(this, xPosition, yPosition);
            }

            return new DefaultStrategy(this, xPosition, yPosition);
        }


        public CellState getCellState(int xPosition, int yPosition)
        {
            Cell cell = cells[xPosition, yPosition];

            return cell.getState();
        }

        public void tickCells()
        {
            foreach (Cell cell in cells)
            {
                cell.tick();
            }
        }
    }
}

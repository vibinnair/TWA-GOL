using System.Collections.Generic;

namespace TW.Assignment.GameOfLife
{
    public class Cell
    {
        private IState state;
        private int xPosition;
        private int yPosition;
        private List<CellState> neighbours;
        

        public Cell(int xPosition, int yPosition)
        {
            neighbours = new List<CellState>();

            this.xPosition = xPosition;
            this.yPosition = yPosition;

        }

        public void setState(CellState state)
        {
          if(state == CellState.ALIVE)
          {
              this.state = new AliveState(this);
          }
          else
          {
              this.state = new DeadState(this);
          }
        }

        public CellState getState()
        {
            return state.getState();
        }

        public void tick()
        {
            state.tick();
        }         

        public int getAliveNeighbours()
        {
            int aliveNeighbours = 0;

            foreach (CellState neighbour in neighbours)
            {
                if(neighbour == CellState.ALIVE)
                {
                    aliveNeighbours++;
                }
            }

            return aliveNeighbours;
        }

        public void addNeighbours(List<CellState> neighbours)
        {
            this.neighbours = neighbours;            
        }
    }
}

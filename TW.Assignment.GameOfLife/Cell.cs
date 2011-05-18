using System.Collections.Generic;

namespace TW.Assignment.GameOfLife
{
    public class Cell
    {
        private State state;
        private List<Cell> neighbours;
        

        public Cell()
        {
            neighbours = new List<Cell>();
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

            foreach (Cell neighbour in neighbours)
            {
                if(neighbour.getState() == CellState.ALIVE)
                {
                    aliveNeighbours++;
                }
            }

            return aliveNeighbours;
        }

        public void addNeighbour(Cell neighbour)
        {
            neighbours.Add(neighbour);            
        }
    }
}

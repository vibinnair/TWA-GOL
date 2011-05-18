using System;
using System.Collections.Generic;
using System.Text;

namespace TW.Assignment.GameOfLife
{
    public interface State
    {
        CellState getState();

        void tick();
    }
}

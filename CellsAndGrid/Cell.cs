using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CellsAndGrid
{
    class Cell
    {

        public Cell(int x, int y)
        {
            XPosition = x;
            YPosition = y;
            Selected = false;

            SetNeighbors(x, y);
        }

        public int XPosition { get; }
        public int YPosition { get; }

        public int Above { get; private set; }
        public int ToRight { get; private set; }
        public int Below { get; private set; }
        public int ToLeft { get; private set; }
        public bool Selected { get; set; }

        private void SetNeighbors(int currentX, int currentY)
        {
            Above = currentX - 1;
            ToRight = currentY + 1;
            Below = currentX + 1;
            ToLeft = currentY - 1;
        }
    }
}

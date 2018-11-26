using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CellsAndGrid
{
    class Cell
    {
        //private int[,] _above;
        //private int[,] _toRight;
        //private int[,] _below;
        //private int[,] _toLeft;


        public Cell(int x, int y)
        {
            Position = new int[x, y];
            XPosition = x;
            YPosition = y;
        }

        public int[,] Position { get; }
        public int XPosition { get; }
        public int YPosition { get; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CellsAndGrid
{
    class Program
    {
        static void Main(string[] args)
        {
            int xPosition = 8;
            int yPosition = 8;

            Grid grid = new Grid(xPosition, yPosition);
        }
    }

    class Cell
    {

    }

    class Grid
    {
        private int _xSize;
        private int _ySize;
        private int[,] _coordinates;

        public Grid(int xSize, int ySize)
        {
            _xSize = xSize;
            _ySize = ySize;
        }
    }
}

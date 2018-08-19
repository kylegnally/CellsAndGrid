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
            int xSize = 8;
            int ySize = 8;

            Grid grid = new Grid(xSize, ySize);
        }
    }

    class Cell
    {

    }

    class Grid
    {
        private int _xSize;
        private int _ySize;
        private Cell[,] _gridArray;

        public Grid(int xSize, int ySize)
        {
            _xSize = xSize;
            _ySize = ySize;
            _gridArray = new Cell[xSize, ySize];
            AddCells(_xSize, _ySize);
        }

        private void AddCells(int sizeX, int sizeY)
        {
            foreach (Cell cell in _gridArray)
            {
                for (int x = 0; x < _xSize; x++)
                {
                    for (int y = 0; y < _ySize; y++)
                    {
                        
                    }
                }
            }
        } 
    }
}

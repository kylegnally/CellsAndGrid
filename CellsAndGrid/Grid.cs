using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CellsAndGrid
{
    class Grid
    {
        private readonly int _xSize;
        private readonly int _ySize;
        private readonly Cell[,] _gridArray;
        private string cellPosition = "";

        public Grid(int xSize, int ySize)
        {
            _xSize = xSize;
            _ySize = ySize;

            _gridArray = new Cell[_xSize, _ySize];
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
                        _gridArray[x, y] = new Cell(x, y);
                    }
                }
            }
        }

        public string FindCell(int x, int y)
        {
            int[,] positionToFind = new int[x,y];
            foreach (Cell cell in _gridArray)
            {
                if (positionToFind == cell.Position)
                {
                    return cellPosition = "The cell's position is " + cell.XPosition + "," + cell.YPosition;
                }
            }
            return cellPosition = "Cell not found.";
        }
    }
}

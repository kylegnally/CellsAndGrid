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
            Console.WriteLine("Grid created.");
        }
    }

    class Cell
    {
        private int _xPos;
        private int _yPos;

        private int[,] _position;
        private int[,] _above;
        private int[,] _toRight;
        private int[,] _below;
        private int[,] _toLeft;


        public Cell(int x, int y)
        {
            _xPos = x;
            _yPos = y;
            _position = new int[x, y];
        }

        public int[,] Position
        {
            get { return _position; }
            set { Position = value; }
        }
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
                int z = 0;
                for (int x = 0; x < _xSize; x++)
                {
                    for (int y = 0; y < _ySize; y++)
                    {                        
                        Cell gridCell = new Cell(x, y);
                        _gridArray[x,y] = gridCell;
                    }
                }
            }
        } 
    }
}

﻿using System;

namespace CellsAndGrid
{
    class Grid
    {
        private readonly int _xSize;
        private readonly int _ySize;
        private int _gridSize;
        private readonly Cell[,] _gridArray;
        private readonly Apple[,] _appleArray;

        public Grid(int xSize, int ySize, int gridSize)
        {
            _xSize = xSize;
            _ySize = ySize;
            _gridSize = gridSize;

            _gridArray = new Cell[_xSize, _ySize];
            AddCells(_xSize, _ySize);
        }

        private void AddCells(int sizeX, int sizeY)
        {
            for (int x = 0; x < sizeX; x++)
            {
                for (int y = 0; y < sizeY; y++)
                {
                    _gridArray[x, y] = new Cell(x, y, _gridSize);
                }
            }
        }

        public void FindCell(int findY, int findX, int gridSize)
        {
            foreach (Cell cell in _gridArray)
            {
                cell.Selected = false;
                if (findX == cell.XPosition && findY == cell.YPosition)
                {
                    cell.Selected = true;
                    cell.Visited = true;
                }
                cell.DetermineContents(findY, findX, gridSize);
            }
        }

        public string DrawGrid(int xSize, int ySize, int findX, int findY)
        {
            string gridString = "";
            Console.Clear();
            int lineLength = 0;
            foreach (Cell cell in _gridArray)
            {
                gridString += cell.Contents;
                lineLength++;

                if (lineLength == xSize)
                {
                    gridString += "\n";
                    lineLength = 0;
                }
            }

            return gridString;
        }

        public bool TestBounds(int findX, int findY, int gridSize)
        {
            bool isEdge = _gridArray[findX, findY].EdgeCell;

            return isEdge;
        }
    }
}
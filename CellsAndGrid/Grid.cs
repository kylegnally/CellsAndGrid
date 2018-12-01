﻿using System;
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

        public void FindCell(int findY, int findX)
        {
            foreach (Cell cell in _gridArray)
            {
                cell.Selected = false;
                if (findX == cell.XPosition && findY == cell.YPosition)
                {
                    cell.Selected = true;
                    //Console.WriteLine("The cell's position is " + cell.XPosition + "," + cell.YPosition);
                    //Console.WriteLine("Its upper neighbor is at " + cell.Above + "," + cell.YPosition);
                    //Console.WriteLine("Its right-hand neighbor is at " + cell.XPosition + "," + cell.ToRight);
                    //Console.WriteLine("Its lower neighbor is at " + cell.Below + "," + cell.YPosition);
                    //Console.WriteLine("Its left-hand neighbor is at " + cell.XPosition + "," + cell.ToLeft);

                }
            }
        }

        public string DrawGrid(int xSize, int ySize, int findX, int findY)
        {
            Console.Clear();
            string gridString = null;
            int lineLength = 0;
            foreach (Cell cell in _gridArray)
            {
                if (cell.Selected)
                {
                    gridString += "* ";
                }
                else
                {
                    gridString += "- ";
                }
                lineLength++;

                if (lineLength == xSize)                
                {
                    gridString += "\n";
                    lineLength = 0;
                }
            }
            gridString += "\n";
            return gridString;
        }
    }
}

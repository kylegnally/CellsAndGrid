using System;

namespace CellsAndGrid
{
    class Grid
    {
        private readonly int _xSize;
        private readonly int _ySize;
        private readonly Cell[,] _gridArray;

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
                }
            }
        }

        public string DrawGrid(int xSize, int ySize, int findX, int findY)
        {
            string gridString = "";

            if (TestBounds(xSize, ySize, findX, findY))
            {
                Console.Clear();
                int lineLength = 0;
                foreach (Cell cell in _gridArray)
                {
                    if (cell.Selected)
                    {
                        gridString += "* ";
                        cell.Visited = true;
                    }
                    else
                    {
                        if (cell.Visited)
                        {
                            gridString += "  ";
                        }
                        else gridString += "- ";
                    }
                    lineLength++;

                    if (lineLength == xSize)
                    {
                        gridString += "\n";
                        lineLength = 0;
                    }
                }

                gridString += "\n";
                
            }
            return gridString;

        }

        public bool TestBounds(int xSize, int ySize, int findX, int findY)
        {
            if (findX > xSize - 1)
            {
                findX--;
                Console.WriteLine("\nThe world ends here.");
                return false;
            }

            if (findY > ySize - 1)
            {
                findY--;
                Console.WriteLine("\nThe world ends here.");
                return false;
            }

            if (findX < 0)
            {
                findX++;
                Console.WriteLine("\nThe world ends here.");
                return false;
            }

            if (findY < 0)
            {
                findY++;
                Console.WriteLine("\nThe world ends here.");
                return false;
            }
            //if (findX > xSize - 1 || findY > ySize - 1 || findX < 0 || findY < 0)
            //{
            //    Console.WriteLine("\nThe world ends here.");
            //    return false;
            //}
            else return true;
        }
    }
}

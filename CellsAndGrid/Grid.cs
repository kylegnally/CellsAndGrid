using System;

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
            MakeApples(_xSize, _ySize);
        }

        private void AddCells(int sizeX, int sizeY)
        {
            foreach (Cell cell in _gridArray)
            {
                for (int x = 0; x < _xSize; x++)
                {
                    for (int y = 0; y < _ySize; y++)
                    {
                        _gridArray[x, y] = new Cell(x, y, _gridSize);
                    }
                }
            }
        }

        private void MakeApples(int sizeX, int sizeY)
        {

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

            gridString += "\n";
            
            gridString += "Press (ESC) to exit the program or (W) to write the array to a file.";
            return gridString;

        }

        public string TestBounds(int findX, int findY, int gridSize)
        {
            string edgeString = "";
            if (_gridArray[findX, findY].EdgeCell)
            {
                edgeString = "\nYou have struck a wall and cannot move further in that direction.";
            }

            return edgeString;
        }
    }
}
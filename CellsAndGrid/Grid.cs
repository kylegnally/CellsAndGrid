using System;

namespace CellsAndGrid
{
    class Grid : GameManager
    {
        private readonly int _xSize;
        private readonly int _ySize;
        private int _gridSize;

        public Grid(int xSize, int ySize, int gridSize) : base(xSize, ySize, gridSize)
        {
            _xSize = xSize;
            _ySize = ySize;
            _gridSize = gridSize;
        }

        public void FindCell(int findY, int findX, int gridSize)
        {
            foreach (Cell cell in CellGrid)
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

        public bool TestBounds(int findX, int findY, int gridSize)
        {
            bool isEdge = CellGrid[findX, findY].EdgeCell;
            return isEdge;
        }
    }
}
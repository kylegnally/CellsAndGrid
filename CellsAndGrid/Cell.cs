using System.Security.Cryptography.X509Certificates;

namespace CellsAndGrid
{
    class Cell
    {
        public Cell(int x, int y, int gridSize)
        {
            XPosition = x;
            YPosition = y;
            Selected = false;
            Visited = false;
            TestForEdge(x, y, gridSize);
        }

        public int XPosition { get; set; }
        public int YPosition { get; set; }
        public bool Selected { get; set; }
        public bool Visited { get; set; }
        public bool EdgeCell { get; set; }
        public string Contents { get; private set; }
        
        public void DetermineContents(int x, int y, int grid)
        {
            if (Selected)
            {
                Contents = "* ";
                Visited = true;
            }
            else
            {
                if (Visited && !EdgeCell)
                {
                    Contents = "  ";
                }
                else if (EdgeCell)
                {
                    Contents = "% ";
                }
                else Contents = "- ";
            }
        }

        public void TestForEdge(int x, int y, int size)
        {
            if (y == 0) EdgeCell = true;
            if (x == 0) EdgeCell = true;
            if (x == size - 1) EdgeCell = true;
            if (y == size - 1) EdgeCell = true;
        }
    }
}
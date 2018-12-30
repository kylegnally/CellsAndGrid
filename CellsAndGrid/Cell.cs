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
        }

        public int XPosition { get; set; }
        public int YPosition { get; set; }
        public bool Selected { get; set; }
        public bool Visited { get; set; }
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
                if (Visited)
                {
                    Contents = "  ";
                }
                else Contents = "- ";
            }
        }
    }
}
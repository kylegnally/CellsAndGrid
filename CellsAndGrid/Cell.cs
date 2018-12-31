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
        public string Contents { get; set; }

        // Somewhere in this class you will want to write code that will implement the GenericQueue 
        // class to create a linked list of segments that will allow each segment to "follow" the
        // one before it. The data in each node will be a two-dimensional array containing the
        // coordinates for each segment and these coordinates will update with each press of the arrow 
        // key. On redraw, this will give the appearance that the snake is moving along the path
        // defined by the user.
        
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
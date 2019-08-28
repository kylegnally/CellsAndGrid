using System;
using System.Security.Cryptography.X509Certificates;

namespace CellsAndGrid
{
    class Cell
    {
        //private string _contentCheck;
        private readonly Apple _appleBlossom;

        //private static string[] _applesOnGrid;
        private static int _counter;
        //private bool _edge;
        public Cell(int x, int y, int gridSize)
        {
            var rand = new Random();

            ApplesOnGrid = new string[2000];
            _appleBlossom = new Apple(rand);
            HasApple = _appleBlossom.AppleExists;
            XPosition = x;
            YPosition = y;
            GridSize = gridSize;
            Selected = false;
            Visited = false;
            EdgeCell = TestForEdge(x, y, gridSize);
        }

        public int XPosition { get; set; }
        public int YPosition { get; set; }
        public int GridSize { get; set; }
        public bool Selected { get; set; }
        public bool Visited { get; set; }

        public bool EdgeCell
        {
            get;
            set;

            //{
            //    _edge = value;
            //    //    if ((YPosition == 0 || 
            //    //        XPosition == 0 || 
            //    //        XPosition == GridSize - 1 || 
            //    //        YPosition == GridSize - 1) && (HasApple))
            //    //    {
            //    //        OneBadApple();
            //    //    }

            //    //    HasApple = value;
            //}
        }
        public string Contents { get; set; }

        public bool HasApple
        {
            get => _appleBlossom.AppleExists;
            set => _appleBlossom.AppleExists = value;
        }

        public static string[] ApplesOnGrid { get; set; }

        public void DetermineContents(int x, int y, int grid)
        {
            if (Selected)
            {
                Contents = "* ";
                Visited = true;
            }
            else
            {
                if (Visited && !EdgeCell /*&& !_appleBlossom.AppleExists*/)
                    Contents = "  ";
                else if (EdgeCell /*&& !_appleBlossom.AppleExists*/)
                    Contents = "% ";
                //else if (!Visited && !EdgeCell /*&& _appleBlossom.AppleExists*/)
                //    Contents = "  ";
                else
                    Contents = "- ";

                //if (Contents == "o ") ApplesOnGrid[_counter] = Contents;
                //_counter++;
            }
            //_contentCheck = Contents;
        }

        public bool TestForEdge(int x, int y, int size)
        {
            if (y == 0 || x == 0 || x == size - 1 || y == size - 1) return true;
            return false;


            //if (x == 0)
            //{
            //    EdgeCell = true;
            //}

            //if (x == size - 1)
            //{
            //    EdgeCell = true;
            //}

            //if (y == size - 1)
            //{
            //    EdgeCell = true;
            //}
        }

        //private void OneBadApple()
        //{
        //    if (HasApple && EdgeCell)
        //    {
        //        Contents = "% ";
        //        HasApple = false;
        //        Apple.ApplesIntended(HasApple);
        //    }
        //}

        // Somewhere in this class you will want to write code that will implement the GenericQueue 
        // class to create a linked list of segments that will allow each segment to "follow" the
        // one before it. The data in each node will be a two-dimensional array containing the
        // coordinates for each segment and these coordinates will update with each press of the arrow 
        // key. On redraw, this will give the appearance that the snake is moving along the path
        // defined by the user.
        //
        // The added benefit of using the GenericQueue is that once the Nutrition property of the Apple
        // class is implemented in the Drawgrid() method of Grid it should be relatively easy to increase the 
        // length of the snake. This will also allow for special Apples that have a higher Nutrition
        // than others. However, you should bear in mind that you will need to read the queue holding
        // the snake to learn the coordinates of each of its segments on the grid before using it in
        // Drawgrid(). 
        //
        // There's an obvious way to do this and a not-so-obvious way. The obvious way is to simply store
        // the coordinates as a [,] in each entry in the queue and read them directly, drawing as needed.
        // Since we're already using [,] arrays throughout the Grid class we already have practice doing 
        // this. The not-so-obvious way is to entirely dispense with the use of coordinates and simply
        // store the user's directional keystrokes. The advantage there is that it eliminates the 
        // possibility of getting the coordinate determination algorithm wrong (because that wouldn't 
        // be necessary). Since programmers (+me) are lazy the keystroke method is the path of least
        // resistance.

    }
}
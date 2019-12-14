using System;

namespace CellsAndGrid
{
    class GameManager
    {
        private int _xPosition;
        private int _yPosition;
        private int[] nextPosition;

        private Grid _grid;
        //private Player _player;
        private Cell _oneCell;

        public int XPosition { get; set; }
        public int YPosition { get; set; }
        public int GridSize { get;  set; }

        public bool ValidMove { get; private set; }

        public string Playfield { get; set; }

        public Grid GridObject { get; set; }
        public Cell[,] CellGrid { get; set; }
        public Player ThePlayer { get; set; }
        public Cell SingleCell { get; set; }

        public GameManager(int xStart, int yStart, int gridSize) // refactor to just int x and int y?
        {
            XPosition = xStart;
            YPosition = yStart;
            GridSize = gridSize;
            nextPosition = new int[2];

            ThePlayer = new Player(xStart, yStart);
            CellGrid = new Cell[GridSize, GridSize];
            InitGrid(GridSize);
        }

        protected Cell[,] InitGrid(int size)
        {
            for (int x = 0; x < GridSize; x++)
            {
                for (int y = 0; y < GridSize; y++)
                {
                    CellGrid[x, y] = new Cell(x, y, GridSize);
                    if (x == 0 || x == GridSize) CellGrid[x, y].IsEdge = true;
                    if (y == 0 || y == GridSize) CellGrid[x, y].IsEdge = true;
                }
            }
            FillCells();
            return CellGrid;
        }

        private void FillCells()
        {
            foreach (Cell cell in CellGrid)
            {
                cell.CellContents = "- ";
                if (cell.IsEdge) cell.CellContents = "% ";
                if (ThePlayer.Position[0] == cell.YPosition && ThePlayer.Position[1] == cell.XPosition)
                    cell.ContainsPlayer = true;
            }
        }


        public string DrawPlayfield()
        {
            Playfield = null;
            Console.Clear();
            FillCells();
            int lineLength = 0;
            foreach (Cell cell in CellGrid)
            {
                if (cell.ContainsPlayer)
                {
                    cell.CellContents = "* ";
                    ThePlayer.CurrentCell = cell; // OF COURSE the cell the player is in doesn't contain a wall!
                }
                Playfield += cell.CellContents;

                lineLength++;

                if (lineLength == GridSize)
                {
                    Playfield += "\n";
                    lineLength = 0;
                }
            }

            return Playfield;
        }

        public void CheckForValidMove(ConsoleKey key)
        {
            ValidMove = false;

            int[] currentPosition = ThePlayer.Position;
            nextPosition[0] = currentPosition[0];
            nextPosition[1] = currentPosition[1];

            switch (key)
            {
                case ConsoleKey.UpArrow:
                    nextPosition[1]--;
                    break;
                case ConsoleKey.RightArrow:
                    nextPosition[0]++;

                    break;
                case ConsoleKey.DownArrow:
                    nextPosition[1]++;

                    break;
                case ConsoleKey.LeftArrow:
                    nextPosition[0]--;
                    break;
            }

            //if (nextPosition[1] < 1 ||              
            //    nextPosition[0] >= GridSize - 1 ||  
            //    nextPosition[1] >= GridSize - 1 ||  
            //    nextPosition[0] < 1)                
            //    ValidMove = false; 

            //else ValidMove = true;

            if (nextPosition[1] > 0 &&                  // Y validity test, moving up
                nextPosition[0] < GridSize - 1 &&      // X validity test, moving right
                nextPosition[1] < GridSize - 1 &&      // Y validity test, moving down
                nextPosition[0] > 0) ValidMove = true;  // X validity test, moving left
        }
    }
}

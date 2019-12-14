using System;

namespace CellsAndGrid
{
    class GameManager
    {
        private readonly int[] _nextPosition;
        private int GridSize { get; }

        public bool ValidMove { get; private set; }

        private string Playfield { get; set; }

        protected Cell[,] CellGrid { get; }
        public Player ThePlayer { get; }

        public GameManager(int xStart, int yStart, int gridSize) 
        {
            GridSize = gridSize;
            _nextPosition = new int[2];

            ThePlayer = new Player(xStart, yStart);
            CellGrid = new Cell[GridSize, GridSize];
            InitGrid(GridSize);
        }

        private void InitGrid(int size)
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
                }

                if (cell.WasVisited) cell.CellContents = "  ";
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

        public void CheckForValidMove(ConsoleKey key)           // this should also be in a Mover class
        {
            ValidMove = false;

            int[] currentPosition = ThePlayer.Position;
            _nextPosition[0] = currentPosition[0];
            _nextPosition[1] = currentPosition[1];

            switch (key)
            {
                case ConsoleKey.UpArrow:
                    _nextPosition[1]--;
                    break;
                case ConsoleKey.RightArrow:
                    _nextPosition[0]++;

                    break;
                case ConsoleKey.DownArrow:
                    _nextPosition[1]++;

                    break;
                case ConsoleKey.LeftArrow:
                    _nextPosition[0]--;
                    break;
            }

            if (_nextPosition[1] > 0 &&                 // Y validity test, moving up
                _nextPosition[0] < GridSize - 1 &&      // X validity test, moving right
                _nextPosition[1] < GridSize - 1 &&      // Y validity test, moving down
                _nextPosition[0] > 0) ValidMove = true; // X validity test, moving left
        }
    }
}

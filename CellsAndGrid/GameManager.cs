using System;

namespace CellsAndGrid
{
    class GameManager
    {
        private readonly int[] _nextPosition;
        private bool _scoreDrawn;
        private bool[,] _appleOrchardArray;
        private Random rnd;
        private int GridSize { get; }

        public bool ValidMove { get; private set; }

        private string Playfield { get; set; }

        private Cell[,] CellGrid { get; set; }
        public Player ThePlayer { get; }
        public Cell SingleCell { get; set; }

        public GameManager(int xStart, int yStart, int gridSize)
        {
            _appleOrchardArray = new bool[gridSize,gridSize];
            rnd = new Random();
            GridSize = gridSize;
            _nextPosition = new int[2];
            ThePlayer = new Player(xStart, yStart);
            CellGrid = new Cell[GridSize, GridSize];
            SingleCell = new Cell(xStart, yStart, gridSize);
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
            FillCells(rnd);
        }

        private void FillCells(Random rnd)
        {
            Orchard appleOrchard = new Orchard();
            foreach (Cell cell in CellGrid)
            {
                _appleOrchardArray[cell.XPosition, cell.YPosition] = false;
                rnd = new Random();
                cell.CellContents = "- ";
                if (cell.IsEdge) cell.CellContents = "% ";
                else if (appleOrchard.Pollinate(rnd) <= 33 && !cell.ContainsPlayer)
                {
                    _appleOrchardArray[cell.XPosition, cell.YPosition] = true;
                    cell.HasApple = true;
                }

                if (ThePlayer.Position[0] == cell.YPosition && ThePlayer.Position[1] == cell.XPosition)
                {
                    cell.ContainsPlayer = true;
                    cell.WasVisited = true;
                }

                else cell.ContainsPlayer = false;
            }
        }

        public string DrawPlayfield()
        {
            Playfield = null;
            _scoreDrawn = false;
            Console.Clear();
            Orchard appleOrchard = new Orchard();
            FillCells(rnd);
            int lineLength = 0;
            foreach (Cell cell in CellGrid)
            {
                Random rnd = new Random();
                if (cell.ContainsPlayer) cell.CellContents = "* ";
                if (cell.WasVisited && !cell.ContainsPlayer)
                {
                    cell.CellContents = "  ";
                }

                if (cell.HasApple)
                {
                    cell.CellContents = "o ";
                }

                Playfield += cell.CellContents;

                lineLength++;

                if (lineLength == GridSize && _scoreDrawn == false)
                {
                    Playfield += "   PLAYER SCORE: " + ThePlayer.PlayerScore;
                    _scoreDrawn = true;
                }

                if (lineLength == GridSize)
                {
                    Playfield += "\n";
                        lineLength = 0;
                }
            }

            _scoreDrawn = false;
            return Playfield;
        }

        public bool CheckForValidMove(ConsoleKey key)           // this should also be in a Mover class
        {
            ValidMove = false;

            int[] currentPosition = ThePlayer.Position;
            _nextPosition[0] = currentPosition[0];
            _nextPosition[1] = currentPosition[1];

            switch (key)                    // get the position of the NEXT move and alter the appropriate field
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

            // SingleCell.CellContents = CellGrid[_nextPosition[0], _nextPosition[1]].CellContents;  // 


            if (_nextPosition[1] > 0 &&             // Y validity test, moving up
                _nextPosition[0] < GridSize - 1 &&  // X validity test, moving right
                _nextPosition[1] < GridSize - 1 &&  // Y validity test, moving down
                _nextPosition[0] > 0)               // X validity test, moving left
            {
                SingleCell = CellGrid[_nextPosition[0], _nextPosition[1]];
                ValidMove = true;
                // ScoreTheMove(_nextPosition[0], _nextPosition[1]);
            }

            return ValidMove;
        }
        
        public bool ScoreTheMove()
        {
            SingleCell.CellContents = CellGrid[_nextPosition[0], _nextPosition[1]].CellContents;
            if (SingleCell.CellContents == "- ")
            {
                ThePlayer.PlayerScore++;
                return true;
            }

            if (SingleCell.CellContents == "o ")
            {
                ThePlayer.PlayerScore += 2;
                return true;
            }
            return false;
        }
    }
}

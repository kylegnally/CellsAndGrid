using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CellsAndGrid
{
    class GameManager
    {
        private int _xPosition;
        private int _yPosition;

        private Grid _grid;
        private Player _player;
        private Cell _oneCell;

        public int XPosition { get; set; }
        public int YPosition { get; set; }
        public int GridSize { get; set; }

        public Grid GridObject { get; set; }
        public Cell[,] CellGrid { get; set; }
        public Player ThePlayer { get; set; }
        public Cell SingleCell { get; set; }

        public GameManager(int gridSize, int xStart, int yStart)
        {
            GridSize = gridSize;
            XPosition = xStart;
            YPosition = yStart;
            CellGrid = new Cell[GridSize, GridSize];
            MakeGrid(GridSize);
        }

        public Cell[,] MakeGrid(int size)
        {
            for (int x = 0; x < GridSize; x++)
            {
                for (int y = 0; y < GridSize; y++)
                {
                    CellGrid[x, y] = new Cell(x, y, GridSize); 
                }
            }

            return CellGrid;
        }
    }
}

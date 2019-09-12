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
        //private Player _player;
        private Cell _oneCell;

        public int XPosition { get; set; }
        public int YPosition { get; set; }
        public int GridSize { get; set; }

        public Grid GridObject { get; set; }
        public Cell[,] CellGrid { get; set; }
        public Player ThePlayer { get; set; }
        public Cell SingleCell { get; set; }

        public GameManager(int xStart, int yStart, int gridSize) // refactor to just int x and int y?
        {
            XPosition = xStart;
            YPosition = yStart;
            GridSize = gridSize;

            ThePlayer = new Player();
            CellGrid = new Cell[GridSize, GridSize];
            InitGrid(GridSize);
        }

        public Cell[,] InitGrid(int size)
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

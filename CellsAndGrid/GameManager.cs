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
        private int _x;
        private int _y;
        private int _size;

        private Grid _grid;
        private Player _player;
        private Cell _oneCell;

        public Grid Playfield { get; set; }

    }
}

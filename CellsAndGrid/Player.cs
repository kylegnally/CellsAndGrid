using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CellsAndGrid
{
    class Player : GameManager
    {
        private int _playerXPosition;
        private int _playerYPosition;

        // private int _playerHealth; // for later

        public int PlayerXPosition { get; set; } 
        public int PlayerYPosition { get; set; }

        public Player()
        {

        }
    }
}

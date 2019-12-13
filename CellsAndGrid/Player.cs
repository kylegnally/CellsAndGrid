using System;

namespace CellsAndGrid
{
    class Player
    {
        private int _xPosition;
        private int _yPosition;
        //private int _oldX;        // these two variables were for debugging
        //private int _oldY;
        private int[] _position;

        public int[] Position { get; set; }

        public Player(int startX, int startY)
        {
            if (Position == null)
            {
                Position = new int[2];
                Position[0] = startX;
                Position[1] = startY;
                _xPosition = startX;
                _yPosition = startY;
            }
        }

        public int[] MovePlayer(ConsoleKey key)
        {
            //_oldX = _xPosition;       // debugging variables
            //_oldY = _yPosition;

            switch (key)                        // You can't assign the values directly to the 
            {                                   // members of the array. Trying to do so will fail.
                case ConsoleKey.UpArrow:
                    _yPosition--;
                    break;
                case ConsoleKey.RightArrow:
                     _xPosition++;
                    break;
                case ConsoleKey.DownArrow:
                    _yPosition++;
                    break;
                case ConsoleKey.LeftArrow:
                    _xPosition--;
                    break;
            }

            Position[0] = _xPosition;
            Position[1] = _yPosition;

            return Position;
        }

        public int[] DenyMovement(int[] playerPosition, int gridSize)
        {
            if (playerPosition[0] < 1) playerPosition[0] = 1;
            if (playerPosition[0] > gridSize - 1) playerPosition[0] = gridSize - 1;
            if (playerPosition[1] < 1) playerPosition[1] = 1;
            if (playerPosition[1] > gridSize - 1) playerPosition[1] = gridSize - 1;

            return playerPosition;
        }
    }
}

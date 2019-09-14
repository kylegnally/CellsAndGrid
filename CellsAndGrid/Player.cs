using System;

namespace CellsAndGrid
{
    class Player
    {
        private int _xPosition;
        private int _yPosition;
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
            switch (key)
            {
                case ConsoleKey.UpArrow:
                    Position[1] = _yPosition--;
                    break;
                case ConsoleKey.RightArrow:
                    Position[0] = _xPosition++;
                    break;
                case ConsoleKey.DownArrow:
                    Position[1] = _yPosition++;
                    break;
                case ConsoleKey.LeftArrow:
                    Position[0] = _xPosition--;
                    break;
            }

            return Position;
        }
    }
}

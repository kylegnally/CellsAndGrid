using System;

namespace CellsAndGrid
{
    class Player
    {
        private int _xPosition;
        private int _yPosition;

        public int[] Position { get; }
        public int PlayerScore { get; set; }
        

        public Player(int startX, int startY)
        {
            if (Position != null) return;
            Position = new int[2];
            Position[0] = startX;
            Position[1] = startY;
            _xPosition = startX;
            _yPosition = startY;
            PlayerScore = 0;
        }

        public void MovePlayer(ConsoleKey key)
        {

            switch (key)                        
            {                                   
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

            Position[0]= _xPosition;
            Position[1] = _yPosition;
        }
    }
}

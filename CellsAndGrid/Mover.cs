using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CellsAndGrid
{
    abstract class Mover : IMover
    {
        public int[] Position { get; set; }
        private ConsoleKey Direction { get; set; }
        private int Size { get; set; }
        private int _xPosition;
        private int _yPosition;

        protected Mover(int[] position, ConsoleKey direction, int size)
        {
            this.Position = position;
            this.Direction = direction;
            this.Size = size;
        }

        public void Move(ConsoleKey key)
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

            Position[0] = _xPosition;
            Position[1] = _yPosition;
        }
        public abstract bool CheckForValidMove(ConsoleKey key);
    }
}

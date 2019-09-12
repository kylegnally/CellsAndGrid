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
            }
        }

        public bool MovePlayer()
        {
            return true;
        }
    }
}

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
                startX = Position[0];
                startY = Position[1];
            }
        }

        public bool DoPlayerMove(Cell source, Cell target)
        {
            return true;
        }
    }
}

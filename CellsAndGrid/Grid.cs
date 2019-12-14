//namespace CellsAndGrid
//{
//    class Grid : GameManager
//    {
//        private readonly int _xSize;
//        private readonly int _ySize;
//        private int _gridSize;

//        public Grid(int xSize, int ySize, int gridSize) : base(xSize, ySize, gridSize)
//        {
//            _xSize = xSize;
//            _ySize = ySize;
//            _gridSize = gridSize;
//        }

//        public void FindCell(int findY, int findX)
//        {
//            foreach (Cell cell in CellGrid)
//            {
//                cell.ContainsPlayer = false;
//                if (ThePlayer.Position[0] == cell.XPosition && ThePlayer.Position[1] == cell.YPosition)
//                {
//                    //cell.ContainsPlayer = true;
//                    cell.WasVisited = true;
//                }
//                //cell.DetermineContents(findY, findX, gridSize);
//            }
//        }

//        //public bool TestBounds(int findX, int findY, int gridSize)
//        //{
//        //    bool isEdge = CellGrid[findX, findY].IsEdge;
//        //    return isEdge;
//        //}

//        //public bool OutOfBounds(int[] playerPosition)
//        //{
//        //    if (playerPosition[0] == 0 || playerPosition[1] == 0) return true;
//        //    if (playerPosition[0] == GridSize -1 || playerPosition[1] == GridSize - 1) return true;
//        //    return false;
//        //}

//    }
//}
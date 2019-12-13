using System;

namespace CellsAndGrid
{
    class Program
    {
        static void Main(string[] args)
        {
            int xSize;
            int ySize;
            int gridSize;

            UserInterface aMenu = new UserInterface();
            Console.WriteLine(aMenu.GetGridSize());
            xSize = int.Parse(Console.ReadLine());
            ySize = xSize;
            gridSize = xSize;

            Grid grid = new Grid(xSize, ySize, gridSize);
            Console.WriteLine(aMenu.GridCreatedMessage());
            Console.WriteLine();
            Console.WriteLine(aMenu.GetXStartingPoint());
            int xPos = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine(aMenu.GetYStartingPoint());
            int yPos = int.Parse(Console.ReadLine());

            GameManager gameManager = new GameManager(xPos, yPos, gridSize);

            Console.Write(gameManager.DrawPlayfield());
            Console.WriteLine(aMenu.PressArrowToMove());
            HandleInteraction();

            void HandleInteraction()
            {
                switch (GetInteraction())
                {
                    case ConsoleKey.UpArrow:
                        
                        gameManager.ThePlayer.MovePlayer(ConsoleKey.UpArrow);
                        Console.Write(gameManager.DrawPlayfield());
                        if (gameManager.ThePlayer.HitAWall(gameManager.ThePlayer.CurrentCell))                          // you need a NextCell that
                        {                                                                                               // gets calculated and stored
                            gameManager.ThePlayer.DenyMovement(gameManager.ThePlayer.Position, gameManager.GridSize);   // BEFORE the player moves there
                            Console.Write(aMenu.CannotMoveIntoWalls());                                                 // so you can check the contents of
                        }                                                                                               // where the player will go next

                        Console.Write(gameManager.DrawPlayfield());
                        Console.WriteLine(aMenu.PressArrowToMove());
                        HandleInteraction();
                        break;
                    case ConsoleKey.RightArrow:
                        if (gameManager.ThePlayer.Position[0] < gridSize)
                        {
                            gameManager.ThePlayer.MovePlayer(ConsoleKey.RightArrow);
                            Console.Write(gameManager.DrawPlayfield());
                            Console.WriteLine(aMenu.PressArrowToMove());
                        }
                        else
                        {
                            gameManager.ThePlayer.DenyMovement(gameManager.ThePlayer.Position, gameManager.GridSize);
                            Console.Write(gameManager.DrawPlayfield());
                            Console.Write(aMenu.CannotMoveIntoWalls());
                        }
                        HandleInteraction();
                        break;
                    case ConsoleKey.DownArrow:
                        if (gameManager.ThePlayer.Position[1] < gridSize)
                        {
                            gameManager.ThePlayer.MovePlayer(ConsoleKey.DownArrow);
                            Console.Write(gameManager.DrawPlayfield());
                            Console.WriteLine(aMenu.PressArrowToMove());
                        }
                        else
                        {
                            gameManager.ThePlayer.DenyMovement(gameManager.ThePlayer.Position, gameManager.GridSize);
                            Console.Write(gameManager.DrawPlayfield());
                            Console.Write(aMenu.CannotMoveIntoWalls());
                        }
                        HandleInteraction();
                        break;
                    case ConsoleKey.LeftArrow:
                        if (gameManager.ThePlayer.Position[0] > 1)
                        {
                            gameManager.ThePlayer.MovePlayer(ConsoleKey.LeftArrow);
                            Console.Write(gameManager.DrawPlayfield());
                            Console.WriteLine(aMenu.PressArrowToMove());
                        }
                        else
                        {
                            gameManager.ThePlayer.DenyMovement(gameManager.ThePlayer.Position, gameManager.GridSize);
                            Console.Write(gameManager.DrawPlayfield());
                            Console.Write(aMenu.CannotMoveIntoWalls());
                        }
                        HandleInteraction();
                        break;
                    //case ConsoleKey.W:
                        ////string fileToWrite = gameManager.DrawPlayfield();
                        //string path = Directory.GetCurrentDirectory();
                        //System.IO.File.WriteAllText(@path, gameManager.DrawPlayfield());
                        //Console.WriteLine("File saved.");
                        //HandleInteraction();
                        //break;
                    default:
                        Environment.Exit(0);
                        break;
                }
            }

            ConsoleKey GetInteraction()
            {
                var ch = Console.ReadKey(false).Key;
                return ch;
            }
        }
    }
}
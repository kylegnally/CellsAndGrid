using System;

namespace CellsAndGrid
{
    class Program
    {
        static void Main(string[] args)
        {
            UserInterface aMenu = new UserInterface();
            Console.WriteLine(aMenu.GetGridSize());
            var gridSize = int.Parse(Console.ReadLine());

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

            /// Let's make a Mover class that can handle movement for everything.
            /// It will inherit from GameManager so it can know everything it needs
            /// to know and will spit out current positions, check for move validity,
            /// and do everything related to a move

            HandleInteraction();

            void HandleInteraction()
            {
                switch (GetInteraction())
                {
                    case ConsoleKey.UpArrow:
                        gameManager.CheckForValidMove(ConsoleKey.UpArrow);

                        if (gameManager.ValidMove)
                        {
                            gameManager.ThePlayer.MovePlayer(ConsoleKey.UpArrow);
                            Console.Write(gameManager.DrawPlayfield());
                            Console.WriteLine(aMenu.PressArrowToMove());
                        }
                        else
                        {
                            Console.Write(gameManager.DrawPlayfield());
                            Console.Write(aMenu.CannotMoveIntoWalls());
                        }

                        HandleInteraction();
                        break;
                    case ConsoleKey.RightArrow:
                        gameManager.CheckForValidMove(ConsoleKey.RightArrow);

                        if (gameManager.ValidMove)
                        {
                            gameManager.ThePlayer.MovePlayer(ConsoleKey.RightArrow);
                            Console.Write(gameManager.DrawPlayfield());
                            Console.WriteLine(aMenu.PressArrowToMove());
                        }
                        else
                        {
                            Console.Write(gameManager.DrawPlayfield());
                            Console.Write(aMenu.CannotMoveIntoWalls());
                        }

                        HandleInteraction();
                        break;
                    case ConsoleKey.DownArrow:
                        gameManager.CheckForValidMove(ConsoleKey.DownArrow);

                        if (gameManager.ValidMove)
                        {
                            gameManager.ThePlayer.MovePlayer(ConsoleKey.DownArrow);
                            Console.Write(gameManager.DrawPlayfield());
                            Console.WriteLine(aMenu.PressArrowToMove());
                        }
                        else
                        {
                            Console.Write(gameManager.DrawPlayfield());
                            Console.Write(aMenu.CannotMoveIntoWalls());
                        }

                        HandleInteraction();
                        break;
                    case ConsoleKey.LeftArrow:
                        gameManager.CheckForValidMove(ConsoleKey.LeftArrow);

                        if (gameManager.ValidMove)
                        {
                            gameManager.ThePlayer.MovePlayer(ConsoleKey.LeftArrow);
                            Console.Write(gameManager.DrawPlayfield());
                            Console.WriteLine(aMenu.PressArrowToMove());
                        }
                        else
                        {
                            Console.Write(gameManager.DrawPlayfield());
                            Console.Write(aMenu.CannotMoveIntoWalls());
                        }

                        HandleInteraction();
                        break;
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
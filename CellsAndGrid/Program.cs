using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.IO;

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

            //Console.Write(grid.DrawGrid(xSize, ySize, xPos, yPos));
            Console.Write(gameManager.DrawPlayfield());
            Console.WriteLine(aMenu.PressArrowToMove());
            HandleInteraction();

            void HandleInteraction()
            {
                switch (GetInteraction())
                {
                    case ConsoleKey.UpArrow:
                        //gameManager.ThePlayer.Position[1]--;
                        //grid.FindCell(gameManager.ThePlayer.Position[0], gameManager.ThePlayer.Position[1], gridSize);
                        //if (grid.TestBounds(gameManager.ThePlayer.Position[0], gameManager.ThePlayer.Position[1], gridSize))
                        //{
                        //    Console.WriteLine(aMenu.CannotMoveIntoWalls());
                        //    gameManager.ThePlayer.Position[1]++;
                        //    HandleInteraction();
                        //}
                        gameManager.ThePlayer.MovePlayer(ConsoleKey.UpArrow);
                        Console.Write(gameManager.DrawPlayfield());
                        Console.WriteLine(aMenu.PressArrowToMove());
                        HandleInteraction();
                        break;
                    case ConsoleKey.RightArrow:
                        //gameManager.ThePlayer.Position[0]++;
                        //grid.FindCell(gameManager.ThePlayer.Position[0], gameManager.ThePlayer.Position[1], gridSize);
                        //if (grid.TestBounds(gameManager.ThePlayer.Position[0], gameManager.ThePlayer.Position[1], gridSize))
                        //{
                        //    Console.WriteLine(aMenu.CannotMoveIntoWalls());
                        //    gameManager.ThePlayer.Position[0]--;
                        //    HandleInteraction();
                        //}
                        gameManager.ThePlayer.MovePlayer(ConsoleKey.RightArrow);
                        Console.Write(gameManager.DrawPlayfield());
                        Console.WriteLine(aMenu.PressArrowToMove());
                        HandleInteraction();
                        break;
                    case ConsoleKey.DownArrow:
                        //gameManager.ThePlayer.Position[1]++;
                        //grid.FindCell(gameManager.ThePlayer.Position[0], gameManager.ThePlayer.Position[1], gridSize); ;
                        //if (grid.TestBounds(gameManager.ThePlayer.Position[0], gameManager.ThePlayer.Position[1], gridSize))
                        //{
                        //    Console.WriteLine(aMenu.CannotMoveIntoWalls());
                        //    gameManager.ThePlayer.Position[1]--;
                        //    HandleInteraction();
                        //}
                        gameManager.ThePlayer.MovePlayer(ConsoleKey.DownArrow);
                        Console.Write(gameManager.DrawPlayfield());
                        Console.WriteLine(aMenu.PressArrowToMove());
                        HandleInteraction();
                        break;
                    case ConsoleKey.LeftArrow:
                        //gameManager.ThePlayer.Position[0]--;
                        //grid.FindCell(gameManager.ThePlayer.Position[0], gameManager.ThePlayer.Position[1], gridSize);
                        //if (grid.TestBounds(gameManager.ThePlayer.Position[0], gameManager.ThePlayer.Position[1], gridSize))
                        //{
                        //    Console.WriteLine(aMenu.CannotMoveIntoWalls());
                        //    gameManager.ThePlayer.Position[0]++;
                        //    HandleInteraction();
                        //}
                        gameManager.ThePlayer.MovePlayer(ConsoleKey.LeftArrow);
                        Console.Write(gameManager.DrawPlayfield());
                        Console.WriteLine(aMenu.PressArrowToMove());
                        HandleInteraction();
                        break;
                    case ConsoleKey.W:
                        ////string fileToWrite = gameManager.DrawPlayfield();
                        //string path = Directory.GetCurrentDirectory();
                        //System.IO.File.WriteAllText(@path, gameManager.DrawPlayfield());
                        //Console.WriteLine("File saved.");
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
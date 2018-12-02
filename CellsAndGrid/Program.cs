using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace CellsAndGrid
{
    class Program
    {
        static void Main(string[] args)
        {
            int xSize;
            int ySize;

            Console.WriteLine("Enter the size for each side of the grid: ");
            xSize = int.Parse(Console.ReadLine());
            ySize = xSize;
            Grid grid = new Grid(xSize, ySize);
            Console.WriteLine("Grid created.");
            Console.WriteLine();
            Console.WriteLine("Enter the starting X coordinate: ");
            int xPos = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Enter the starting Y coordinate: ");
            int yPos = int.Parse(Console.ReadLine());

            xPos--;
            yPos--;

            grid.FindCell(xPos, yPos);

            Console.Write(grid.DrawGrid(xSize, ySize, xPos, yPos));
            Console.WriteLine("\nPress an arrow key (press any other key to end):");
            HandleDirection();

            void HandleDirection()
            {
                switch (GetDirection())
                {
                    case ConsoleKey.UpArrow:
                        yPos--;
                        grid.FindCell(xPos, yPos);
                        Console.Write(grid.DrawGrid(xSize, ySize, xPos, yPos));
                        HandleDirection();
                        break;
                    case ConsoleKey.RightArrow:
                        xPos++;
                        grid.FindCell(xPos, yPos);
                        Console.Write(grid.DrawGrid(xSize, ySize, xPos, yPos));
                        HandleDirection();
                        break;

                    case ConsoleKey.DownArrow:
                        yPos++;
                        grid.FindCell(xPos, yPos);
                        Console.Write(grid.DrawGrid(xSize, ySize, xPos, yPos));
                        HandleDirection();
                        break;

                    case ConsoleKey.LeftArrow:
                        xPos--;
                        grid.FindCell(xPos, yPos);
                        Console.Write(grid.DrawGrid(xSize, ySize, xPos, yPos));
                        HandleDirection();
                        break;
                    default:
                        Environment.Exit(0);
                        break;
                }
            }

            ConsoleKey GetDirection()
            {
                var ch = Console.ReadKey(false).Key;
                return ch;
            }
        }
    }
}
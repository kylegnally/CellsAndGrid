using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CellsAndGrid
{
    class Program
    {
        static void Main(string[] args)
        {
            int xSize = 8;
            int ySize = 8;

            Grid grid = new Grid(xSize, ySize);
            Console.WriteLine("Grid created.");
            Console.WriteLine();
            Console.WriteLine("Enter the X coordinate of the cell you'd like to find: ");
            int xPos = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Enter the Y coordinate of the cell you'd like to find: ");
            int yPos = int.Parse(Console.ReadLine());

            xPos--;
            yPos--;

            grid.FindCell(xPos, yPos);

            Console.Write(grid.DrawGrid(xSize, ySize, xPos, yPos));

            Console.WriteLine("\nPress an arrow key (press ESC to end):");
            
            while (Console.ReadKey().Key != ConsoleKey.Escape)
            {
                var ch = Console.ReadKey(false).Key;
                switch (ch)
                {
                    case ConsoleKey.UpArrow:
                        yPos--;
                        grid.FindCell(xPos, yPos);
                        Console.Write(grid.DrawGrid(xSize, ySize, xPos, yPos));
                        break;
                    case ConsoleKey.RightArrow:
                        xPos++;
                        grid.FindCell(xPos, yPos);
                        Console.Write(grid.DrawGrid(xSize, ySize, xPos, yPos));
                        break;

                    case ConsoleKey.DownArrow:
                        yPos++;
                        grid.FindCell(xPos, yPos);
                        Console.Write(grid.DrawGrid(xSize, ySize, xPos, yPos));
                        break;

                    case ConsoleKey.LeftArrow:
                        xPos--;
                        grid.FindCell(xPos, yPos);
                        Console.Write(grid.DrawGrid(xSize, ySize, xPos, yPos));
                        break;
                }
            }
            //Console.WriteLine("Finished.");
        }
    }
}

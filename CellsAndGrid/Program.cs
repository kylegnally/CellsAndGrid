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

            for (int i = 0; i < xSize; i++)
            {
                for (int j = 0; j < ySize; j++)
                {
                    Console.WriteLine(grid.FindCell(xPos, yPos));
                }
            }

            Console.WriteLine("Finished.");
        }
    }
}

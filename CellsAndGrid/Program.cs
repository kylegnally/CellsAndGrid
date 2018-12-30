﻿using System;
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

            Console.WriteLine("Enter the size for each side of the grid: ");
            xSize = int.Parse(Console.ReadLine());
            ySize = xSize;
            gridSize = xSize;
            Grid grid = new Grid(xSize, ySize, gridSize);
            Console.WriteLine("Grid created.");
            Console.WriteLine();
            Console.WriteLine("Enter the starting X coordinate: ");
            int xPos = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Enter the starting Y coordinate: ");
            int yPos = int.Parse(Console.ReadLine());

            xPos--;
            yPos--;

            grid.FindCell(xPos, yPos, gridSize);

            Console.Write(grid.DrawGrid(xSize, ySize, xPos, yPos));
            Console.WriteLine("\nPress an arrow key (press any other key to end):");
            HandleInteraction();

            void HandleInteraction()
            {
                switch (GetInteraction())
                {
                    case ConsoleKey.UpArrow:
                        yPos--;
                        grid.FindCell(xPos, yPos, gridSize);
                        if (grid.TestBounds(xPos, yPos, gridSize) != "")
                        {
                            Console.WriteLine(grid.TestBounds(xPos, yPos, gridSize));
                            yPos++;
                            HandleInteraction();
                        }
                        Console.Write(grid.DrawGrid(xSize, ySize, xPos, yPos));
                        HandleInteraction();
                        break;
                    case ConsoleKey.RightArrow:
                        xPos++;
                        grid.FindCell(xPos, yPos, gridSize);
                        if (grid.TestBounds(xPos, yPos, gridSize) != "")
                        {
                            Console.WriteLine(grid.TestBounds(xPos, yPos, gridSize));
                            xPos--;
                            HandleInteraction();
                        }
                        Console.Write(grid.DrawGrid(xSize, ySize, xPos, yPos));
                        HandleInteraction();
                        break;
                    case ConsoleKey.DownArrow:
                        yPos++;
                        grid.FindCell(xPos, yPos, gridSize);
                        if (grid.TestBounds(xPos, yPos, gridSize) != "")
                        {
                            Console.WriteLine(grid.TestBounds(xPos, yPos, gridSize));
                            yPos--;
                            HandleInteraction();
                        }
                        Console.Write(grid.DrawGrid(xSize, ySize, xPos, yPos));
                        HandleInteraction();
                        break;
                    case ConsoleKey.LeftArrow:
                        xPos--;
                        grid.FindCell(xPos, yPos, gridSize);
                        if (grid.TestBounds(xPos, yPos, gridSize) != "")
                        {
                            Console.WriteLine(grid.TestBounds(xPos, yPos, gridSize));
                            xPos++;
                            HandleInteraction();
                        }
                        Console.Write(grid.DrawGrid(xSize, ySize, xPos, yPos));
                        HandleInteraction();
                        break;
                    case ConsoleKey.W:
                        string fileToWrite = grid.DrawGrid(xSize, ySize, xPos, yPos);
                        string path = Directory.GetCurrentDirectory();
                        System.IO.File.WriteAllText(@path, fileToWrite);
                        Console.WriteLine("File saved.");
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
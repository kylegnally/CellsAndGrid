using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CellsAndGrid
{
    class UserInterface
    {
        private string _returnString;

        public UserInterface()
        {

        }

        public string GetGridSize()
        {
            return _returnString = "\n\nEnter the size of one side of the square grid as a whole number.\n" +
                              "I would suggest a size not much larger than 24.";
        }

        public string GetXStartingPoint()
        {
            return _returnString = "Enter the X coordinate of the initial starting location: ";
        }

        public string GetYStartingPoint()
        {
            return _returnString = "Enter the Y coordinate of the initial starting location: ";
        }

        public string GridCreatedMessage()
        {
            return _returnString = "Grid created.";
        }

        public string PlayerLocation()
        {
            return _returnString = "The player's position is: ";
        }

        public string CannotMoveIntoWalls()
        {
            return _returnString = "You've attempted to move into a wall. Walls are impassable. Because they're walls.";
        }

        public string PressArrowToMove()
        {
            return _returnString = "Press an arrow key to move around the grid. Press the Escape key (ESC) to exit.";
        }

        public string SaySomethingDammit()
        {
            return _returnString = "This question must have an answer in the form of an integer (a whole number) for this universe to exist.";
        }

        //public bool ConfirmExit()
        //{
        //    Console.WriteLine("Are you sure (y/N)?");
        //    if (Console.ReadKey().Key == ConsoleKey.Y) return true;
        //    else return false;
        //}
    }
}

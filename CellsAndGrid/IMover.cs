using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CellsAndGrid
{
    interface IMover
    {
        void Move(ConsoleKey key);
        bool CheckForValidMove(ConsoleKey key);

        int[] Position { get; set; }
    }
}

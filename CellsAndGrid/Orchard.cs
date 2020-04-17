using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CellsAndGrid
{
    class Orchard
    {
        private bool _appleBlossom;

        private bool AppleBlossom { get; set; }

        public Orchard()
        {
            
        }

        public int Pollinate(Random rand)
        {
            int _appleBlossom = rand.Next(0, 100);
            return _appleBlossom;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CellsAndGrid
{
    class Apple
    {
        private string _apple = "o";
        private int _nutrition = 1;

        public Apple()
        {
            AnApple = _apple;
            Nutrition = _nutrition;
        }

        public string AnApple
        {
            get => _apple;
            set => _apple = value;
        }

        public int Nutrition
        {
            get => _nutrition;
            private set => _nutrition = value;
        }
    }
}

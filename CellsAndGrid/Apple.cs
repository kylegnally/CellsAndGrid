using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CellsAndGrid
{
    class Apple
    {
        //private string _appleString;
        private int _nutrition = 1;
        //private int _randomSeeder;
        //private int _qubit;
        private bool _appleExists;
        private static int _applesIntended;

        public static int ApplesIntended()
        {
            return _applesIntended;
        }

        public static int ApplesIntended(bool removeApple)
        {
            _applesIntended--;
            return _applesIntended;
        }


        public Apple(Random rand)
        {
            _appleExists = false;
            Nutrition = _nutrition;
            PickApple(rand);
        }

        private void PickApple(Random rand)
        {
            int appleSeed = rand.Next(0, 10);
            
            if (appleSeed / 2 == 2)
            {
                _appleExists = true;
                _applesIntended++;
            }
            else _appleExists = false;
        }

        public bool AppleExists
        {
            get
            {
                if (_appleExists) return true;
                return false;
            }
            set => _appleExists = value;
        }

        public int Nutrition
        {
            get => _nutrition;
            private set => _nutrition = value;
        }
    }
}

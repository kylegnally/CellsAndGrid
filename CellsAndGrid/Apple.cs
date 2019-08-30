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
        private static int counter;
        //private int _randomSeeder;
        //private int _qubit;
        //private bool _appleExists;
        private static int _applesIntended;
        private static bool[] _appleTruthArray;

        public static int RemoveAnApple(bool removeApple)
        {
            _applesIntended--;
            return _applesIntended;
        }

        public bool AppleExists { get; set; }

        public int Nutrition
        {
            get => _nutrition;
            private set => _nutrition = value;
        }

        public static bool[] AppleTruthArray { get; set; }
        public Apple(Random rand)
        {
            if (_appleTruthArray == null)
            {
                _appleTruthArray = new bool[2000];
            }
            else AppleTruthArray = _appleTruthArray;
            //GrowAnApple(rand);
            if (GrowAnApple(rand)) AppleExists = true;
            ApplesIntended = _applesIntended;
            Nutrition = _nutrition;
            //AppleExists = GrowAnApple(rand); 
            //AppleExists = _appleExists;
        }

        private bool GrowAnApple(Random rand)
        {
            AppleExists = false;
            //int[] desiredAppleSeedArray = {2};
            int appleSeed = rand.Next(0, 10);
            
             if (appleSeed % 3 == 0)
             {
                _applesIntended++;
                _appleTruthArray[counter] = true;
                counter++;
                return true;
             }
             return false;
        }
        public static int ApplesIntended
        {
            get => _applesIntended;
            set => _applesIntended = value;
        }
    }
}

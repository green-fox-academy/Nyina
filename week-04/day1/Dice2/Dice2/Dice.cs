using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice2
{
    public class Dice
    {
        public int Current;

        public static Random random = new Random();


        public void Roll()
        {
            Current = random.Next(1, 7);
        }

        public int GetCurrent()
        {
            return Current;
        }

        public void Reroll()
        {
            Current = random.Next(1, 7);
        }


    }
}

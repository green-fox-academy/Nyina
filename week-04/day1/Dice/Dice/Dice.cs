using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice
{
    class Dice
    {
        //a dobás eltárolására hozzuk létre:
        public int D6 { get; set; }
        public int reD6 { get; set; }
        public int Current { get; set; }

        public static Random random = new Random();

        //a constructornak ugyanaz a neve, mint a classnak. És arra való, hogy 

        //függvény kell. Ha ide hozzuk léte akkor, példány.tulajdonsággal kell létrehozni
        public void Roll()
        {
            D6 = random.Next(1, 7);  //a második szám már nincs benne, tehát 1-6 közötti számok

        }

        public int GetCurrent( Dice dice )
        {
            return dice.D6;
        }

        public void Reroll()
        {
            if (D6 != 0)
            {
                reD6 = random.Next(1, 7);
            }

        }

        public int Has6()
        {
            return;
        }
    }
}

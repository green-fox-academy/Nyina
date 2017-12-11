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

        public int Current { get; set; }

        public static Random random = new Random();

        //a constructornak ugyanaz a neve, mint a classnak. És arra való, hogy 

        //Itt dobunk és annak az értékét adjuk vissza:
        public void Roll()
        {
            Current = random.Next(1, 7);  //a második szám már nincs benne, tehát 1-6 közötti számok
        }

        //itt tudjuk átadni, hogy ez hányas
        public int GetCurrent()
        {
            return Current;
        }

        public void ReRoll()
        {
            Current = random.Next(1, 7);
        }

    }
}

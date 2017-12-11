using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    class Animal
    {
        public int Hunger;
        public int Thirst;

        public Animal()
        {
            Hunger = 50;
            Thirst = 50;
        }

        public void Eat()
        {
            Hunger--;
        }

        public void Drink()
        {
            Thirst--;
        }

        public void Play()
        {
            Hunger++;
            Thirst++;
        }
    }
}

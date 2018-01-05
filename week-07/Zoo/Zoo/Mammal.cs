using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    class Mammal : Animal
    {
        public Mammal(string animalName) : base(animalName)
        {
            father = "my uterus";
        }

        public override string GetName()
        {
            return name;
        }

        public override string WantChild()
        {
            return GetName() + ", want a child from " + father + " ! ";
        }

        public override void Greet()
        {
            Console.WriteLine("Hello {0}!", GetName());
        }
    }
}

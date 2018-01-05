using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    abstract class Animal
    {
        protected string name;
        private int age;
        protected string father;

        public Animal(string animalName)
        {
            name = animalName;
        }

        public abstract void Greet();
        public abstract string WantChild();
        public abstract string GetName();

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal();

            Console.WriteLine(animal.Hunger);
            Console.WriteLine(animal.Thirst);
            animal.Eat();
            Console.WriteLine(animal.Hunger);
            animal.Drink();
            Console.WriteLine(animal.Thirst);
            animal.Play();
            Console.WriteLine(animal.Hunger);
            Console.WriteLine(animal.Thirst);




            Console.ReadLine();

        }
    }
}

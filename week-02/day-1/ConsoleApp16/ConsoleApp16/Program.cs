using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many chickens have the farmer?");
            int chicken = Convert.ToInt32(Console.ReadLine());
                
            Console.WriteLine("How many pigs have the farmer?");
            int pigs = Convert.ToInt32(Console.ReadLine());

            int chickenLegs = chicken * 2;
            int pigsLegs = pigs * 4;

           Console.WriteLine(chickenLegs);
           Console.WriteLine(pigsLegs);

            Console.ReadLine();

            // Write a program that asks for two integers
            // The first represents the number of chickens the farmer has
            // The seconf represents the number of pigs the farmer has
            // It should print how many legs all the animals have
        }
    }
}

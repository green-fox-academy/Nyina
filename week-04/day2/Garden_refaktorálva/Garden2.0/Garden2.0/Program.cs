using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garden2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Itt most egy kertbe töltjük, de létre lehetne hozni egy másikat is és abba is tudnánk tölteni

            Garden garden = new Garden();
            garden.AddPlants(new Flower("yellow flower", 4));
            Flower flower2 = new Flower("blue flower", 2);
            garden.AddPlants(flower2);

            garden.AddPlants(new Tree("orange tree", 7));
            Tree tree2 = new Tree("purple tree", 3);
            garden.AddPlants(tree2);

            garden.ShareWater(0);
            Console.WriteLine();

            garden.ShareWater(40);
            Console.WriteLine();

            garden.ShareWater(70);


            Console.ReadLine();

        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var planetList = new List<string> { "Mercury", "Venus", "Earth", "Mars", "Jupiter", "Uranus", "Neptune" };
            planetList.Insert(5, "Saturn");
            foreach (string planet in planetList)

            // Saturn is missing from the planetList
            // Insert it into the correct position
            {
                Console.WriteLine(planet);
            }
            Console.ReadLine();
        }
    }
}

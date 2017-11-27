using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                double a = 5;
                double b = 3;
                double c = 2;
                double SurfaceArea = 2 * (a * b + b * c + a * c);
                double Volume = a * b * c;

                Console.WriteLine(SurfaceArea);
                Console.WriteLine(Volume);
                Console.ReadLine();

                // Write a program that stores 3 sides of a cuboid as variables (doubles)
                // The program should write the surface area and volume of the cuboid like:
                //
                // Surface Area: 600
                // Volume: 1000
            }
        }
    }
}

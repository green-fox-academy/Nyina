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
            Console.WriteLine(sumBunnyEars(5));
            Console.ReadLine();

            // We have a number of bunnies and each bunny has two big floppy ears.
            // We want to compute the total number of ears across all the bunnies recursively (without loops or multiplication).
        }

        public static int sumBunnyEars(int Bunny)
        {

            if (Bunny == 1)
            {
                return 2;
            }
            else
            {
                return 2 + (sumBunnyEars(Bunny-1));
            }
        }
    }
}

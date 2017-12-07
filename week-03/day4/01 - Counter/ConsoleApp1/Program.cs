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
            /*
            Áttölthető, de nem fontos:
            int sumNumbers = CounterRecursion(6);
            */

            CounterRecursion(6);
            // Write a recursive function that takes one parameter: n and counts down from n.

            /*
            Felesleges, mert a funkcióban már kiíratom:
            Console.WriteLine(sumNumbers);
            */

            Console.ReadLine();

        }
        public static int CounterRecursion(int number)
        {
            Console.WriteLine(number);
            if (number == 1)
            {
                return 1;
            }
            else
            {
                return(CounterRecursion(number-1));
            }


        }
    }
}

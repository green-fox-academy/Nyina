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

            Console.WriteLine(Divider(126));
            Console.ReadLine();

            // Given a non-negative int n, return the sum of its digits recursively (no loops). 
            // Note that mod (%) by 10 yields the rightmost digit (126 % 10 is 6), while 
            // divide (/) by 10 removes the rightmost digit (126 / 10 is 12).

        }
        public static int Divider(int number)
        {
            int numberSum = (number % 10);

            if (number == 0)
            {
                return 0;
            }
            else
            {
                return numberSum + Divider(number / 10);
            }
        }
    }
}

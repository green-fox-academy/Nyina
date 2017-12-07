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
            Console.WriteLine(AddRecursion(3));
            Console.ReadLine();

            // Write a recursive function that takes one parameter: n and adds numbers from 1 to n.
        }
        public static int AddRecursion(int number)
        {
            if (number == 1)
            {
                return 1;
            }
            else
            {
               return number + AddRecursion(number - 1);
            }

        }
    }
}

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
            int even = 0, odd = 0;
            int[] numbers = new int[] { 0, 1, 2, 3, 4, 5, 6, 7 };
            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                    even++;
                else
                    odd++;
            }
            Console.WriteLine("Found {0} Odd Numbers, and {1} Even Numbers.", 
                odd, even);
            Console.ReadLine();

        }
    }
}

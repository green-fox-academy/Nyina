using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a LINQ Expression to get the average value of the odd numbers from the following array:
            int[] n = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };

            double oddNumbers = n.Where(x => x % 2 != 0).Average();

            Console.WriteLine(oddNumbers);

            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a LINQ Expression to get the squared value of the positive numbers from the following array:
            int[] n = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };

            var positiveEvenNumbers = n.Where(x => x % 2 == 0)
                .Select(num => Math.Pow(num, 2)).ToList();

            positiveEvenNumbers.ForEach(i => Console.WriteLine($"[{i}]"));

            Console.ReadLine();
        }
    }
}

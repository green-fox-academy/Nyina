using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 3, 5, 1, 2, 7 };
            sum(numbers);

            // - Write a function called `sum` that sum all the numbers
            //   until the given parameter
            Console.ReadLine();
        }
        static void sum(int[] numbers)
        {
            int summary = 0;
            for (int i = 0; i < numbers.Length; i++)
                {
                summary += numbers[i];
                }
            Console.WriteLine(summary);
        }
    }
}

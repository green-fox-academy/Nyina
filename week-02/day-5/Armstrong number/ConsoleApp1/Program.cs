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
            Console.WriteLine("Give me a number! Let's check together wether it is an Armstrong number!");


            //int input = int.Parse(Console.ReadLine());

            string input = Console.ReadLine();
            char[] array = input.ToCharArray();

            /*Rövidebben ugyanez:
            char[] array = Console.ReadLine().ToCharArray();
            */

            double sum = 0;
            foreach (var number in array)
            {
                sum += Math.Pow((int)Char.GetNumericValue(number), array.Length);
            }
            Console.WriteLine(sum);

            Console.ReadLine();
        }
    }
}

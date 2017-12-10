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
            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Recursion(1634));

            /*double result = Recursion(number);

            if (result == number)
                {
                Console.WriteLine("WOW, You have an Armstorng number!");
                }
            else
                {
                Console.WriteLine("Keep trying!");
                }*/
            Console.ReadLine();
        }
        public static int Recursion(int number)
        {
            int sumDigits = 0;

            if (number == 0)
            {
                return 0;
            }
            else
            {
                return sumDigits = Recursion(number / 10);
            }
        }
    }
}

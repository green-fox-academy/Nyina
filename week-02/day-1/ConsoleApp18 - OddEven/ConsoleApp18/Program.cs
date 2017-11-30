using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me a number!");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number % 2 == 0)
                {
                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("Odd");
            }

            Console.ReadLine();

            // Write a program that reads a number from the standard input,
            // Then prints "Odd" if the number is odd, or "Even" if it is even.

        }
    }
}
using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me a number!");
            int number = Convert.ToInt32(Console.ReadLine());

            for(int i = 1; i <= number; i++ )
            {
                for(int k = number - 1; k >= 1; k--)
                {
                    Console.Write(" ");
                }
                for (int m = 1; m <= i * 2 -1; m++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            for (int h = number + 1; h <= number * 2 -1; h++)
            {
                for (int k = 1; k <= h - number; k++)
                {
                    Console.Write(" ");
                }
                for (int m = number * 2 - h; m >= 1; m--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.ReadLine();

            // Write a program that reads a number from the standard input, then draws a
            // diamond like this:
            //
            //
            //    *
            //   ***
            //  *****
            // *******
            //  *****
            //   ***
            //    *
            //
            // The diamond should have as many lines as the number was

        }
    }
}
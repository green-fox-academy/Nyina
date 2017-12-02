using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me one number");
            int number = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
              

                for (int k = number - i ;  k >= 1 ; k--)
                {
                    Console.Write(" ");
                }

                for (int m = 1; m <= (i * 2 - 1) ; m++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
            Console.ReadLine();


            // Write a program that reads a number from the standard input, then draws a
            // pyramid like this:
            //
            //
            //    *
            //   ***
            //  *****
            // *******
            //
            // The pyramid should have as many lines as the number was

            Console.ReadLine();
        }    
       
    }
}
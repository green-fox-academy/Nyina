using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me a number!");
            int number = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                if (i == 1)
                {
                    for (int j = 1; j <=number; j++ )
                    Console.Write("*");
                }

                if (i>1 && i < number)
                {
                    for (int k = 1;  k <= number; k++)
                    {
                        if (k == 1 || k == number)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                }


                if (i == number)
                {
                    for (int m = 1; m <= number; m++)
                    Console.Write("*");
                }

                Console.WriteLine();
            }
            Console.ReadLine();

            // Write a program that reads a number from the standard input, then draws a
            // square like this:
            //
            //
            // %%%%%
            // %   %
            // %   %
            // %   %
            // %   %
            // %%%%%
            //
            // The square should have as many lines as the number was
        }
    }
}

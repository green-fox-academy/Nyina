using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me a number to draw a Chess table");
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i <= number-1; i++)
            {
                for (int k = 0; k <= number; k++)
                {
                    if (i == 0 || i == number-1;  i % 2 == 0)
                    {
                        for (k = 0; k < number-1; k++)
                        {
                            Console.Write("%");
                        }
                    }
                    else
                    {
                        for (k = 1; k <= number-1; k++)
                        {
                            Console.Write("%");
                        }
                    }

                }
                Console.WriteLine();
            }
            Console.ReadLine();

            // Crate a program that draws a chess table like this
            //
            // % % % %
            //  % % % %
            // % % % %
            //  % % % %
            // % % % %
            //  % % % %
            // % % % %
            //  % % % %
            //
        }
    }
}
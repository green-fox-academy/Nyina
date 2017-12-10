using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me a number to draw a Chess table");
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i <= number - 1; i++)
            {
                for (int k = 0; k <= number; k++)
                {
                    if (i % 2 != 0)
                    {
                        if (k == 0)
                        {
                            Console.Write(" ");
                        }
                        else
                        {
                            Console.Write("%");
                        }
                    }
                    else
                    {
                        if (k == number)
                        {
                            Console.Write(" ");
                        }
                        else
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

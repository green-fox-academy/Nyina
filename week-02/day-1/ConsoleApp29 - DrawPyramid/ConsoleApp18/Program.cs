using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me one number");
            int number = Convert.ToInt32(Console.ReadLine());

            string star = "*";
            string space = " ";

            for (int circle = 0; circle < number; circle++)
            {
                for (int i = 1; i < number; i++)
                {
                    for (int j = number - i; j >= 0; j--)
                    {
                        Console.Write(space);
                        //space.Substring(0);
                    }
                    Console.Write(star);
                    //star += "*";  
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
        }
    }
}
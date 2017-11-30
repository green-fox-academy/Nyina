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

       
            int loop = 0;
            int i = 0;
            for (int j = number - 1; loop < number && i <= (number * 2) - 1 && j >= 0; loop++, i = i + 2, j--)
            {
                Console.Write(space);
                //space.Substring(0);
                Console.Write(star);
                star = star + "*" + "*";

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
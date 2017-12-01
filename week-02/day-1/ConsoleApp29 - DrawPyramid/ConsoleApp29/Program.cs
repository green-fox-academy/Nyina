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
            int j = number - 1;
            for (int i = 1; loop < number && j >= 0 && i < (number * 2) - 1; loop++, j--, i = i + 2)
            {
                Console.Write(space);
                //space.Substring(0);
                Console.Write(star);
                //star = star + "*" + "*";

                Console.WriteLine(space[j] + star[i]);
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
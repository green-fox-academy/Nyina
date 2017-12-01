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

            for (int loop = 0; loop < number; loop++)
            {
                int j = number - 1;
                for (int i = 1; j >= 0 && i < (number * 2) - 1; j--, i = i + 2)
                {
                    Console.Write(space[j]);
                    //space.Substring(0);
                    Console.Write(star[i]);
                    //star = star + "*" + "*";
                }
                Console.WriteLine();
                Console.ReadLine();

                //star = star + "*" + "*";

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
}
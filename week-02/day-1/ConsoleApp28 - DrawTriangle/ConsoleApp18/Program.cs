using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me a number!");
            int number = Convert.ToInt32(Console.ReadLine());

            string star = "*";
            for(int i = 0; i <= number; i++)
            {
               Console.WriteLine(star);
                star += "*";
            }
            Console.ReadLine();

            // Write a program that reads a number from the standard input, then draws a
            // triangle like this:
            //
            // *
            // **
            // ***
            // ****
            //
            // The triangle should have as many lines as the number was
        }
    }
}

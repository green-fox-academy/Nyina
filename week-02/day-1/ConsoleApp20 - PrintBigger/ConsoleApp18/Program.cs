using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me 2 numbers!");
            int number1 = Convert.ToInt32(Console.ReadLine());
            int number2 = Convert.ToInt32(Console.ReadLine());

            if (number1 < number2)
            {
                Console.WriteLine(number2);
            }
            else
            {
                Console.WriteLine(number1);
            }
            Console.ReadLine();

            // Write a program that asks for two numbers and prints the bigger one
        }
    }
}
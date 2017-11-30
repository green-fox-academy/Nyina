using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Give me 5 numbers");
            int number1 = Convert.ToInt32(Console.ReadLine());
            int number2 = Convert.ToInt32(Console.ReadLine());
            int number3 = Convert.ToInt32(Console.ReadLine());
            int number4 = Convert.ToInt32(Console.ReadLine());
            int number5 = Convert.ToInt32(Console.ReadLine());

            int sum = number1 + number2 + number3 + number4 + number5;

            Console.WriteLine(sum);

            int average = sum / 5;
            Console.WriteLine(average);
            Console.ReadLine();


            // Write a program that asks for 5 integers in a row,
            // then it should print the sum and the average of these numbers like:
            //
            // Sum: 22, Average: 4.4
        }
    }
}
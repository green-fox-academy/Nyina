using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I guessed a number. Could you find out which is that?");
            int guesses = Convert.ToInt32(Console.ReadLine());

            
             int myNumber = 31;

             if (guesses > myNumber)
             {
                Console.WriteLine("The stored number is higher");
                    
             }
             if (guesses < myNumber)
             {
                 Console.WriteLine("The stried number is lower");
             }
             if (guesses == myNumber)
             {
                 Console.WriteLine("You found the number: 31");
                    
             }
             Console.ReadLine();

            // Write a program that stores a number, and the user has to figure it out.
            // The user can input guesses, after each guess the program would tell one
            // of the following:
            //
            // The stored number is higher
            // The stried number is lower
            // You found the number: 8
        }
    }
}
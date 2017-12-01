using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I guessed a number. Find out which was it! You have 5 lives.");
            int guessedNumber = Convert.ToInt32(Console.ReadLine());
            
            int myNumber = 32;
            int lives = 5;

            for (lives = 4; lives > 0; lives--)
            {
                if (guessedNumber > 32)
                {
                    Console.WriteLine("Too high. You have {0} lives left.", lives);
                }
                if (guessedNumber < 32)
                {
                    Console.WriteLine("Too low. You have {0} lives left.", lives);
                }
                if (myNumber == guessedNumber)
                {
                    Console.WriteLine("Congratulations. You won!", lives);
                    break;
                }
            guessedNumber = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine("GAME OVER");
            Console.ReadLine();
        }
    }
}

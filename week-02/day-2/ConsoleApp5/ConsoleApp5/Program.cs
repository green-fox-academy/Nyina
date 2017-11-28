using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your factorial number = " );
            int UserNumber = int.Parse(Console.ReadLine());
            Factorio(UserNumber);

            // - Create a function called `factorio`
            //   that returns it's input's factorial
            Console.ReadLine();
        }

        static void Factorio(int number)
        {
            int result = 1;
            for (int i = 1; i <= number; i++)
            {
                result *= i;
            }
            Console.WriteLine("The result is:" + result);
            
        }
    }
}

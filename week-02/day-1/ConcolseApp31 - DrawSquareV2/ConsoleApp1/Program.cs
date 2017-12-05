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
            Console.WriteLine("Give me a number to draw a square");
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                for (int k = 0; k < number; k++)
                {
                    if (i == 0 || i == number - 1)
                    {
                        Console.Write("%");
                    }
                    else
                    {
                        if (k == 0 || k == number - 1 || i == k)
                        {
                            Console.Write("%");
                        }
                        else
                        {
                            Console.Write("*");
                        }
                    }
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}

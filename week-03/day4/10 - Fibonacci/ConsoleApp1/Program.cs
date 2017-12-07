﻿using System;
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
            Console.WriteLine(Fibonacci(5));
            Console.ReadLine();

            // The fibonacci sequence is a famous bit of mathematics, and it happens to
            // have a recursive definition. The first two values in the sequence are
            // 0 and 1 (essentially 2 base cases). Each subsequent value is the sum of the
            // previous two values, so the whole sequence is: 0, 1, 1, 2, 3, 5, 8, 13, 21
            // and so on. Define a recursive fibonacci(n) method that returns the nth
            // fibonacci number, with n=0 representing the start of the sequence.
        }

        public static int Fibonacci(int number)
        {
            if (number == 1)
            {
                return 0;
            }
            else if (number == 2)
            {
                return 1;
            }
            else
            {
                Console.WriteLine(number + Fibonacci(number - 1));
            }
        }
    }
}

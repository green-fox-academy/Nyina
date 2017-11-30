using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int a = 123;
            int b = 526;
            var temp = a;
            a = b;
            b = temp;

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.ReadLine();

        }
    }
}
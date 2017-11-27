using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = Add(10, 2);

            if (result > 10)
            {
                Console.WriteLine("Result is larger than 10!");
            }
            else
            {
                Console.WriteLine("Result is smaller than 10!");
            }
            Console.ReadKey();
        }

        public static int Add(int num1, int num2)
        {
            return (num1 + num2);
        }
    }
}

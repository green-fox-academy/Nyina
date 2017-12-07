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
            Console.WriteLine(Power(3, 2));
            Console.ReadLine();

            // Given base and n that are both 1 or more, compute recursively (no loops)
            // the value of base to the n power, so powerN(3, 2) is 9 (3 squared).
        }
        public static int Power(int baseInt, int n)
        {
            if (n == 0)
            {
                return 1;
            }
            else
            {
                return baseInt * Power(baseInt, n - 1);
            }
        }
    }
}

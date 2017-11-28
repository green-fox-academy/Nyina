using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] p1 = {1, 2, 3};
            int[] p2 = {4, 5};

            if (p2.Length > p1.Length)
            {
                Console.WriteLine("p2");
            }
            else
            {
                Console.WriteLine("p2 is smaller than p1");
            }

            // - Create an array variable named `p1`
            //   with the following content: `[1, 2, 3]`
            // - Create an array variable named `p2`
            //   with the following content: `[4, 5]`
            // - Print if `p2` has more elements than `p1`
            Console.ReadLine();
        }
    }
}

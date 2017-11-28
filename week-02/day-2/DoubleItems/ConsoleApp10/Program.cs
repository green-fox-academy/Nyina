using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ag = {3, 4, 5, 6, 7};

            for(int i = 0; i < ag.Length; i++)
            {
                Console.WriteLine(ag[i] * 2);
            }

            // - Create an array variable named `ag`
            //   with the following content: `[3, 4, 5, 6, 7]`
            // - Double all the values in the array
            Console.ReadLine();
        }
    }
}

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
            Console.WriteLine(sumEars(13));
            Console.ReadLine();

            // We have bunnies standing in a line, numbered 1, 2, ... The odd bunnies
            // (1, 3, ..) have the normal 2 ears. The even bunnies (2, 4, ..) we'll say
            // have 3 ears, because they each have a raised foot. Recursively return the
            // number of "ears" in the bunny line 1, 2, ... n (without loops or multiplication).
        }

        public static int sumEars(int bunnyNumber)
        {

            if (bunnyNumber == 0)
            {
                return 0;
            }
            else if (bunnyNumber % 2 == 0)
            {
                return 2 + sumEars(bunnyNumber - 1);
            }
            else
            {    
               return 3 + sumEars(bunnyNumber - 1);
            }


            
        }

    }
}
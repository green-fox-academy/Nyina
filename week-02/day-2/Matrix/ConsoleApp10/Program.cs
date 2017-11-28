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
            int[,] array = new int [4, 4] 
            { 
                {1, 0, 0, 0 },                               
                {0, 1, 0, 0 },                            
                {0, 0, 1, 0 },                           
                {0, 0, 0, 1 } };

            //foreach (int i in array)
            //{
            //    Console.WriteLine(i);
            //}

            Console.WriteLine(array[0,0]);
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                    Console.Write(array[i, j] + " ");
                Console.WriteLine();
            }

            // - Create (dynamically) a two dimensional array
            //   with the following matrix. Use a loop!
            //
            //   1 0 0 0
            //   0 1 0 0
            //   0 0 1 0
            //   0 0 0 1
            //
            // - Print this two dimensional array to the output
            Console.ReadLine();
        }
    }
}

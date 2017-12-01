using System;

namespace AppendA
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nimals = { "kuty", "macsk", "cic" };
            string character = "a";
            foreach (string animals in nimals)
            {
                Console.WriteLine(animals + character);
            }
           
            Console.ReadLine();


            // - Create an array variable named `nimals`
            //   with the following content: `["kuty", "macsk", "cic"]`
            // - Add all elements an `"a"` at the end
            Console.ReadLine();
        }
    }
}
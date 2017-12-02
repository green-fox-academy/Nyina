using System;

namespace SwapElements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] abc = { "first", "second", "third" };

            Swap(abc);

            // - Create an array variable named `abc`
            //   with the following content: `["first", "second", "third"]`
            // - Swap the first and the third element of `abc`
            Console.ReadLine();
        }
        static void Swap(string[] array)
        {
            string temp = array[0];
            array[0] = array[2];
            array[2] = temp;

            foreach (string elements in array)
            {
                Console.WriteLine(elements);
            }
            Console.ReadKey();
        }
    }
}
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
            string[] names = { "Tamás", "Endre", "Márk" };

            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }

            //string[] names = { "Tamás", "Endre", "Márk" };
            //for (int i = 0; i < names.Length; i++)
            //{
            //    string name = names[i];
            //    Console.WriteLine(name);
            //}

            //foreach (string i in names)
            //{
            //    Console.WriteLine(i);
            //}

            Console.ReadLine();
        }
    }
}

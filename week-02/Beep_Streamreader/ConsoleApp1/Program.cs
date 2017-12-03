using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] lines = System.IO.File.ReadAllLines("Value.txt");
            foreach (var line in lines)
            {
                Console.WriteLine(line);
                /*string[] values = line.Split(',');
                Int64 frequency = Convert.ToInt64(values[0]);
                Int64 duration = Convert.ToInt64(values[1]);
                Console.Beep(frequency, duration);*/
                
            }

            Console.ReadLine();

        }
    }
}

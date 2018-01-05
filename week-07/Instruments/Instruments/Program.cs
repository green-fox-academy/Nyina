using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instruments
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test 1, create Electric Guitar, Bass Guitar and Violin with default strings.");
            var guitar = new Electric_Guitar(6);
            var bassGuitar = new Bass_Guitar(4);
            var violin = new Violin(4);

            Console.WriteLine("Test 1 Play");
            guitar.Play();
            bassGuitar.Play();
            violin.Play();

            Console.WriteLine("Test 2, create Electric Guitar, Bass Guitar with 7 and 5 strings .");
            Electric_Guitar guitar2 = new Electric_Guitar(7);
            Bass_Guitar bassGuitar2 = new Bass_Guitar(5);

            Console.WriteLine("Test 2 Play");
            guitar2.Play();
            bassGuitar2.Play();

            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Name___Propertyvel
{
    class Program
    {
        static void Main(string[] args)
        {
            Name name1 = new Name("ádám", "krajcs");
            Name name2 = new Name("nyina", "dobi");

            //Console.WriteLine(name1.getName());
            //Console.WriteLine(name2.getName());

            Console.WriteLine(name1.getName());
            Console.WriteLine(name2.getName());

            Console.ReadLine();


            //Ugyanazt kell csinálni, mint az előzőnél, csak propertyvel
            //A különbség, hogy az összefésülést Name propertyvel kell megoldani majd
            
        }
    }
}

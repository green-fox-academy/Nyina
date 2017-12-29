using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Name___Propertyvel___get___set
{
    class Program
    {
        static void Main(string[] args)
        {
            //mivel nincs constructor, ezért csak az objektumokat kell példányosítani
            Name name1 = new Name();
            Name name2 = new Name();

            //mivel az objektum tulajdonsága, ezért kell meghívni a példány mögött
            name1.firstName = "ádám";
            name1.lastName = "krajcs";
            name2.firstName = "nyina";
            name2.lastName = "dobi";

            Console.WriteLine(name1.getName());
            Console.WriteLine(name2.getName());


            Console.ReadLine();
        }
    }
}

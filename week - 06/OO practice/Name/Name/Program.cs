using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Name
{
    class Program
    {
        static void Main(string[] args)
        {
            Name name2 = new Name();
            Name name1 = new Name();

            //name1.SetName();
            //Console.WriteLine(name1.GetName());
            //name2.SetName();
            //Console.WriteLine(name2.GetName());


            name1.SetFirstname("ádám");
            name1.SetLastname("krajcs");
            Console.WriteLine(name1.GetName());
            name2.SetFirstname("nyina");
            name2.SetLastname("dobi");
            Console.WriteLine(name2.GetName());

            Console.ReadLine();

            //2 fieldje van: a Firstname és a Lastname
            //Legyenek ezek protectedek és mindkettőnek kell egy setter funcion ahol az első betűt nagybetűsítjük.
            //Kell egy getName ami visszaadja a teljes nevet: Firstname, Lastname
            //A main programban kisbetűvel adjuk meg a neveket és írassuk ki a teljes nevet a getname - mel.

        }
    }
}

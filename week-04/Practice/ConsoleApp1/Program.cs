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
            //létrehoztunk egy objektumot
            Trousers gant = new Trousers();

            //értéket adunk az objektum tulajdonságainak. A típust a clothes-ból örökölte
            gant.brand = "Gant";
            gant.color = "black";
            gant.price = 300;
            gant.size = 36;

            int IHave = 10;

            //kiíratjuk:
            Console.WriteLine(gant.IsAffordable(IHave));



            Shirt oakley = new Shirt();

            oakley.brand = "Oakley";
            oakley.color = "black";
            oakley.price = 666;
            oakley.size = 1;

            //megnézzük, hogy ruhadarab színe egyezik-e
            Console.WriteLine(gant.IsColorMatch(oakley));

            

            //itt látszik, hogy az objektumoknak van tulajdonságuk(ez most nem lényeg itt) és saját akcióik
            gant.Writeprice();
            oakley.Writeprice();


            Console.ReadLine();
        }
    }
}

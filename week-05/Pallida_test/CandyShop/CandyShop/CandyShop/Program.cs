using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandyShop
{
    class Program
    {
        static void Main(string[] args)
        {
            Candyshop Candyshop = new Candyshop(300);
            Candyshop.CreateSweets(Candyshop.CANDY);
            Candyshop.CreateSweets(Candyshop.CANDY);
            Candyshop.CreateSweets(Candyshop.LOLLIPOP);
            Candyshop.CreateSweets(Candyshop.LOLLIPOP);
            Candyshop.PrintInfo();
            Console.WriteLine(Candyshop.Sell(Candyshop.LOLLIPOP, 1));
            Console.WriteLine(Candyshop.Sell(Candyshop.CANDY, 1));
            Candyshop.PrintInfo();
            Candyshop.Raise(5);
            Candyshop.Sell(Candyshop.LOLLIPOP, 1);
            Candyshop.PrintInfo();
            Candyshop.BuySugar(300);
            Candyshop.PrintInfo();

            Console.ReadLine();

        }
    }
}

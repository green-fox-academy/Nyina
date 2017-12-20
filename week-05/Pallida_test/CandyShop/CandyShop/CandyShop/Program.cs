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
            Candyshop MyCandyshop = new Candyshop(300);
            Lollipop Lollipop1 = new Lollipop();
            CandyShop.CreateSweets(CandyShop.Lollipop);
            Lollipop Lollipop2 = new Lollipop();

            Candy Candy1 = new Candy();
            Candy Candy2 = new Candy();
        }
    }
}

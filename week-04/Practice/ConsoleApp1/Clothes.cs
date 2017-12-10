using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Clothes
    {
        public int size;
        public string color;
        public int price;
        public string brand;

        public bool IsColorMatch(Clothes cloth)
        {
            if (this.color == cloth.color)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsAffordable(int ownMoney)
        {
            if (this.price <= ownMoney)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Writeprice()
        {
            Console.WriteLine(this.price);
        }



    }
}

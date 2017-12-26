using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandyShop
{
    class Candyshop
    {
        
        //a candyshop listája ami üres, de csak sweetek és lollipopok és candyk tölthetőek
        List<Sweets> sweets = new List<Sweets>();

        //olyan mint a függvényeknél a static
        public const string CANDY = "Candy";
        public const string LOLLIPOP = "Lollipop";

        public double Amount { get; set; } = 0;
        public double sugarAmount { get; set; }
        public Candyshop(double amountOfSugar)
        {
            sugarAmount = amountOfSugar;
        }


        public double CandyCounter()
        {
            double candyCounter = 0;
            foreach (var sweetElement in sweets)
            {
                if (sweetElement is Candy)
                {
                    candyCounter++;
                }
            }
            return candyCounter;
        }

        public double LolliCounter()
        {
            double lolliCounter = 0;
            foreach (var sweetElement in sweets)
            {
                //a listából kiszedi az objektumot és megnézi, hogy úgy hívják-e mint az objektumunkat
                if (sweetElement is Lollipop)
                {
                    lolliCounter++;
                }
            }
            return lolliCounter;
        }

        public void CreateSweets(string sweetType)
        //public void CreateSweets(string sweetType)
        {
            double lolliCounter = 0;
            double candyCounter = 0;
            if (sweetType == LOLLIPOP)
            {
                Lollipop lollipop1 = new Lollipop();
                sweets.Add(lollipop1);
                sugarAmount-=5;
                lolliCounter++;
            }
            else if (sweetType == CANDY)
            {
                Candy candy1 = new Candy();
                sweets.Add(candy1);
                sugarAmount-=10;
                candyCounter++;
            }
        }

        public void PrintInfo()
        {
            //mivel a metódusokat használom az összesítéshez, ezért tuti jó az érték
            Console.WriteLine("Invetory: {0} candies, {1} lollipops, Income: {2}'$', Sugar: {3}gr", LolliCounter(), CandyCounter(), Amount, sugarAmount);
        }

        public void Raise(double number)
        {
            foreach (var sweet in sweets)
            {
                //a listából kiszedi az objektumot és megnézi, hogy úgy hívják-e mint az objektumunkat
                if (sweet is Lollipop)
                {
                    sweet.Price = (number / 100.0) * sweet.Price;
                }
                else if (sweet is Candy)
                {
                    sweet.Price = (number / 100.0) * sweet.Price;
                }
            }
        }


        public double Sell(string sweetType, int numberOfSweets)
        {
            for (int j = 0; j < numberOfSweets; j++)
            {
                foreach (var sweet in sweets)
                {
                    if (sweet is Lollipop && sweetType == LOLLIPOP)
                    {
                        sweets.Remove(sweet);
                        Amount = Amount + sweet.Price;
                        break;
                    }
                    else if (sweet is Candy && sweetType == CANDY)
                    {
                        sweets.Remove(sweet);
                        Amount = Amount + sweet.Price;
                        break;
                    }
                }
            }
            return Amount;
        }

        public void BuySugar(int boughtSugar)
        {
            sugarAmount += boughtSugar;
            Amount -= boughtSugar / 10;
        }

    }
}

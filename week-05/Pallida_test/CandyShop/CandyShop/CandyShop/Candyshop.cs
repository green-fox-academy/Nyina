using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandyShop
{
    class Candyshop
    {
        public double Amount;
        //a candyshop listája ami üres, de csak sweetek és lollipopok és candyk tölthetőek
        List<Sweets> sweets = new List<Sweets>();

        //olyan mint a függvényeknél a static
        public const string CANDY = "Candy";
        public const string LOLLIPOP = "Lollipop";

        public double sugarAmount { get; set; }

        public Candyshop(double amount)
        {
            Amount = amount;
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
        {
            if (sweetType == LOLLIPOP)
            {
                Lollipop lollipop1 = new Lollipop();
                sweets.Add(lollipop1);
            }
            else if (sweetType == CANDY)
            {
                Candy candy1 = new Candy();
                sweets.Add(candy1);
            }
        }

        public void PrintInfo()
        {
            foreach (var sweet in sweets)
            {
                Console.WriteLine("Invetory: {0} candies, {1} lollipops, Income: {3}'$', Sugar: {4}gr", LolliCounter(), CandyCounter(), Amount, sugarAmount);
            }
        }

        public void Raise(double number)
        {
            foreach (var sweet in sweets)
            {
                double result;

                //a listából kiszedi az objektumot és megnézi, hogy úgy hívják-e mint az objektumunkat
                if (sweet is Lollipop)
                {
                    result = (number / 100) * sweet.Price;
                }
                else if (sweet is Candy)
                {
                    result = (number / 100) * sweet.Price;
                }
            }
        }

        public void Sell(string sweetType, int numberOfSweets)
        {
            foreach (var sweet in sweets)
            {
                if (sweet is Lollipop)
                {
                    Lollipop lollipop1 = new Lollipop();
                    sweets.Remove(lollipop1);
                }
                else if (sweet is Candy)
                {
                    Candy candy1 = new Candy();
                    sweets.Remove(candy1);
                }
            }
        }

        public void BuySugar(int sugarNumber)
        {
            sugarAmount += sugarNumber * 10;
            Amount -= sugarNumber;
        }



    }
}

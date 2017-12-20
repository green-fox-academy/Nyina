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
        List<Sweets> sweets = new List<Sweets>();

        public Candyshop(double amount)
        {
            Amount = amount;
        }

        public double SweetCounter(List<Lollipop>lollis, List<Candy> candies)
        {
            double lolliCounter = 0;
            double candyCounter = 0;
            double sweetCounter = 0;

            foreach (var lolliElement in lollis)
            {
                lolliCounter++;
            }

            foreach (var candiElement in candies)
            {
                candyCounter++;
            }

            return sweetCounter = lolliCounter + candyCounter;
        }

        public double LolliCounter(List<Lollipop> lollis)
        {
            double lolliCounter = 0;

            foreach (var lolliElement in lollis)
            {
                lolliCounter++;
            }

            return lolliCounter;
        }

        public void CreateSweets(string sweetType)
        {
            if (sweetType == "lollipop")
            {
                Lollipop lollipop1 = new Lollipop();
                sweets.Add(lollipop1);
            }
            else if (sweetType == "candy")
            {
                Candy candy1 = new Candy();
                sweets.Add(candy1);
            }
        }

        public void PrintInfo()
        {
            
        }

        public void Raise(double number)
        {
            foreach (var sweet in sweets)
            {
                double result;

                if (sweet.Type == "lollipop")
                {
                    result = number * sweet.Price;
                }
                else if (sweet.Type == "candy")
                {
                    result = number * sweet.Price;
                }
            }

        }

    }
}

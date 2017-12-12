using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garden_Application
{
    class Program
    {
        static void Main(string[] args)
        {
            Flower yellow = new Flower(6);
            Flower blue = new Flower(12);

            Tree purple = new Tree(25);
            Tree orange = new Tree(44);

            for (int i = 0; i <= 1; i++)
            {
                if (yellow.waterAmount < 5)
                {
                    yellow.GetFirstWater();
                }
            }

            for (int i = 0; i <= 1; i++)
            {
                if (yellow.waterAmount < 5)
                {
                    yellow.GetSecondWater();
                }
            }


        }
    }
}

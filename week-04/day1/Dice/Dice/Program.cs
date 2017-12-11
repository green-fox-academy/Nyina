using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dice;

namespace Dice
{
    class Program
    {
        static void Main(string[] args)
        {
            /*objektum létrehozása, ha csak egy dobás kellene
            Dice Dice1= new Dice();*/

            List<Dice> dices = new List<Dice>();

            for (int i = 0; i < 6; i++)
            {
                dices.Add(new Dice());
                //foreach-csel lehet kiíratni
            }


            for (int j = 0; j < dices.Count; j++)
            {
                dices[j].Roll();
            }

            Console.WriteLine();


            Console.ReadLine();


        }
    }
}

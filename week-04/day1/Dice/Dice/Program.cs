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
            Dice dices= new Dice();*/

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
            //Azért ide, mert ha a ciklusba írnánk, akkor 6X írná ki)
            Console.WriteLine("First dices");
            for (int j = 0; j < dices.Count; j++)
            {
                Console.Write(dices[j].GetCurrent() + " ");
            }
            //Itt csak 2 ürest sort tettünk be, hogy elváljanak az eredények
            Console.WriteLine();
            Console.WriteLine();
            for (int j = 0; j < dices.Count; j++)
            {
                dices[j].ReRoll();
            }
            Console.WriteLine("Second dices");
            for (int j = 0; j < dices.Count; j++)
            {
                Console.Write(dices[j].GetCurrent() + " ");
            }

            Console.ReadLine();


        }
    }
}

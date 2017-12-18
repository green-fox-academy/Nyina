using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice2
{
    class Program
    {
        static void Main(string[] args)
        {

        List<Dice> dices = new List<Dice>();
            
        for (int i = 0; i < 6; i++)
        {
            dices.Add(new Dice());
        }

        for (int j = 0; j < dices.Count; j++)
        {
               dices[j].Roll();
        }

            for (int j = 0; j < dices.Count; j++)
        {
            Console.WriteLine(dices[j].GetCurrent() + " ");
        }

        Console.WriteLine();
        Console.WriteLine();


            for (int i= 0; i< dices.Count; i++)
        {
            dices[i].Reroll();
        }

        for (int i = 0; i < dices.Count; i++)
        {
            Console.WriteLine(dices[i].GetCurrent() + " ");
        }


            Console.ReadLine();



            //You have a Dice class which has 6 dice
            //You can roll all of them with Roll()
            //Check the current rolled numbers with GetCurrent()
            //You can reroll with Reroll()
            //Your task is to get where all dice is a 6


        }
    }
}

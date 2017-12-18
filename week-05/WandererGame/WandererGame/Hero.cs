using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GreenFox;

namespace WandererGame
{
    class Hero
    {
        private double X1 = 0;
        private double Y1 = 0;


        public Hero(string filename, double x1, double y1)
        {
            X1 = x1;
            Y1 = y1;
        }


        public void StepRight(FoxDraw foxDraw)
        {
                X1 += 50;
                foxDraw.AddImage("hero-right.png", X1, Y1);
        }

        public void StepLeft(FoxDraw foxDraw)
        {
            X1 -= 50;
            foxDraw.AddImage("hero-left.png", X1, Y1);
        }

        public void StepDown(FoxDraw foxDraw)
        {
            Y1 += 50;
            foxDraw.AddImage("hero-down.png", X1, Y1);
        }

        public void StepUp(FoxDraw foxDraw)
        {
            Y1 -= 50;
            foxDraw.AddImage("hero-up.png", X1, Y1);
        }



        /*
        public void KeyDownEvent(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Right)
            {
                double x = FoxDraw.GetRight(FoxDraw.Tiles[0]) + 10;
                FoxDraw.SetPosition(FoxDraw.Tiles[0], x, y);
                Console.WriteLine("To the right!");
            }

            if (e.Key == Key.Top)
            {
                double y = FoxDraw.GetTop(FoxDraw.Tiles[0]) + 10;
                FoxDraw.SetPosition(FoxDraw.Tiles[0], x, y);
                Console.WriteLine("To the top!");
            }

            if (e.Key == Key.Left)
            {
                double x = FoxDraw.GetLeft(FoxDraw.Tiles[0]) - 10;
                FoxDraw.SetPosition(FoxDraw.Tiles[0], x, y);
                Console.WriteLine("To the left!");
            }

            if (e.Key == Key.Down)
            {
                double y = FoxDraw.GetDown(FoxDraw.Tiles[0]) - 10;
                FoxDraw.SetPosition(FoxDraw.Tiles[0], x, y);
                Console.WriteLine("To the down!");
            }

        }*/

    }
}

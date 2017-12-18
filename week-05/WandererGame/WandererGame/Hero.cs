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
        private double X1 { set; get; }
        private double Y1 { set; get; }

        public Hero(double x1, double y1)
        {
            X1 = x1;
            Y1 = y1;
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

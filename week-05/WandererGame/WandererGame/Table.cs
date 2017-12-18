using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GreenFox;

namespace WandererGame
{
    public class Table
    {

        private double X1 { get; set; }
        private double Y1 { get; set; }
        
        public Table(double x1, double y1)
        {
            X1 = x1;
            Y1 = y1;
        }     



    public void DrawATable(FoxDraw foxDraw)
    {
        double X1 = 0;
        double Y1 = 0;

        for (int i = 0; i < 8; i++)
        {

            X1 = 0;

            for (int j = 0; j < 11; j++)
            {
                foxDraw.AddImage("floor.png", X1, Y1);
                X1 += 50;
            }
            Y1 += 50;
        }
    }

    public void DrawWall0(FoxDraw foxDraw)
    {
        double X1 = 100;
        double Y1 = 0;

        for (int i = 0; i < 3; i++)
        {
            foxDraw.AddImage("wall.png", X1, Y1);
            Y1 += 50;
        }
    }

    public void DrawWall1(FoxDraw foxDraw)
    {
        double X1 = 100;
        double Y1 = 100;

        for (int i = 0; i < 3; i++)
        {
            foxDraw.AddImage("wall.png", X1, Y1);
            X1 += 50;
        }
    }

    public void DrawWall2(FoxDraw foxDraw)
    {
        double X1 = 450;
        double Y1 = 100;

        for (int i = 0; i < 4; i++)
        {
            foxDraw.AddImage("wall.png", X1, Y1);
            Y1 += 50;
        }
    }

    public void DrawWall3(FoxDraw foxDraw)
    {
        double X1 = 350;
        double Y1 = 200;

        for (int i = 0; i < 3; i++)
        {

            for (int k = 0; k < 1; k++)
            {
                foxDraw.AddImage("wall.png", X1, Y1);
                X1 += 50;
            }
            Y1 += 50;
        }
    }

    public void DrawWall4(FoxDraw foxDraw)
    {
        double X1 = 150;
        double Y1 = 250;

        for (int i = 0; i < 3; i++)
        {
            foxDraw.AddImage("wall.png", X1, Y1);
            Y1 = 250;
            for (int k = 0; k < 1; k++)
            {
                foxDraw.AddImage("wall.png", X1, Y1);
                X1 += 50;
            }
            Y1 += 50;


        }
    }
    }
}

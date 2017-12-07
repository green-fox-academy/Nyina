using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using GreenFox;


namespace Checkerboard
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            DrawRectangle(foxDraw);
            // fill the canvas with a checkerboard pattern.

        }
        public static void DrawBlackRectangle(FoxDraw foxDraw)
        {
            double X1 = 0;
            double Y1 = 0;
            double size = 80;
            double X2 = X1 + size;
            double Y2 = Y1 + size;

            for (int i = 1; i < 11; i++)
            {
                foxDraw.FillColor(Colors.Green);
                foxDraw.DrawRectangle(X1, Y1, size, size);


                for (int k = 1; k < 11; k++)
                {
                    if (i % 2 == 0)
                    {
                        foxDraw.FillColor(Colors.Green);
                        foxDraw.DrawRectangle(X2, Y2, size, size);
                        X2 = X2 + size*2;
                    }
                    else
                    {
                        foxDraw.FillColor(Colors.Green);
                        foxDraw.DrawRectangle(X1, Y1, size, size);
                        X1 = X1 + size * 2;
                    }
                }
                Y1 = Y1 + size * 2;
            }
        }
    }
}

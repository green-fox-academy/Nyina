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
        public static void DrawRectangle(FoxDraw foxDraw)
        {
            double X1 = 0;
            double Y1 = 0;
            double size = 80;
            double X2 = X1 + size;

            for (int i = 1; i < 11; i++)
            {
                Y1 = Y1 + size * 2;
                
                for (int k = 1; k < 11; k++)
                {
                    if (i % 2 == 0)
                    {
                        X2 = X2 + size;
                    }
                    else
                    {
                        X1 = X1 + size * 2;
                    }
                }
                foxDraw.FillColor(Colors.Green);
                foxDraw.DrawRectangle(X1, Y1, size, size);
            }
        }
    }
}

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


namespace PurpleSteps
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            DrawRectangle(foxDraw, 10, 10);


            // reproduce this:
            // [https://github.com/greenfox-academy/teaching-materials/blob/master/workshop/drawing/purple-steps/r3.png]

        }
        public static void DrawRectangle(FoxDraw foxDraw, double X1, double Y1)
        {
            double xStart = 0;
            double yStart = 0;

            for (int i = 0; i < 20; i++)
            {
                foxDraw.FillColor(Colors.Purple);
                xStart = xStart + 50;
                yStart = yStart + 50;
                foxDraw.DrawRectangle(xStart, yStart, 50, 50);
                
            }
        }
    }
}

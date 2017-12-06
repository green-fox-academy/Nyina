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

namespace FourRectangles
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            DrawRectangle(foxDraw);
            // draw four different size and color rectangles.



        }
        public static void DrawRectangle(FoxDraw foxDraw)
        {
            double xstart = 10;
            double ystart = 10;
            double with = 80;
            double heigh = 50;
            string[] color = { Red, Green, Yellow, Black };

            for (int i = 0; i < 5; i++)
            {
                xstart = xstart + 80;
                ystart = ystart + 100;
                with = with + 50;
                heigh = heigh + 90;
                foxDraw.DrawRectangle(xstart, ystart, with, heigh);
                foxDraw.FillColor(Colors.color);
            }
        }
    }
}

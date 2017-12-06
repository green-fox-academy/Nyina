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

namespace PositionSquare
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);

            double x1 = 10;
            double y1 = 10;

            DrawRectangle(foxDraw, x1, y1);

            // create a square drawing function that takes 2 parameters:
            // the x and y coordinates of the square's top left corner
            // and draws a 50x50 square from that point.
            // draw 3 squares with that function.            

        }
        public static void DrawRectangle(FoxDraw foxDraw, double xstart, double ystart)
        {
            
            Random randomColor = new Random();

            for (int i = 0; i < 3; i++)
            {
                xstart = xstart + 80;
                ystart = ystart + 80;
                foxDraw.DrawRectangle(xstart, ystart, 50, 50);
                foxDraw.FillColor(Color.FromRgb((byte)randomColor.Next(), (byte)randomColor.Next(), (byte)randomColor.Next()));

            }
        }
    }
}
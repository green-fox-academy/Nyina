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

namespace GoToCenter
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            
            /* Egyszerűbb megoldás
            DrawGreenLines(foxDraw);*/

            double x = 50;
            double y = 100;
            DrawGreenLines(foxDraw, x, y);


            // create a line drawing function that takes 2 parameters:
            // the x and y coordinates of the line's starting point
            // and draws a line from that point to the center of the canvas.
            // draw 3 lines with that function.

        }
        public static void DrawGreenLines(FoxDraw foxDraw, double x, double y)
        {

            for (int i=0; i < 3; i++)
            {
                x = x + 50;
                y = y + 100;
                foxDraw.StrokeColor(Colors.Green);
                foxDraw.DrawLine(x, y, 260, 120);
            }


            /* Egyszerűbb megoldás:
            public static void DrawGreenLines(FoxDraw foxDraw)
        {
            foxDraw.StrokeColor(Colors.Green);
            foxDraw.DrawLine(10, 10, 260, 120);

            foxDraw.StrokeColor(Colors.Red);
            foxDraw.DrawLine(280, 10, 260, 120);

            foxDraw.StrokeColor(Colors.Purple);
            foxDraw.DrawLine(20, 160, 260, 120);*/



        }
    }
}

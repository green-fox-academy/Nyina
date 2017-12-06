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

namespace HorizontalLines
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);

            double ystart = 150;
            double yend = 150;
            DrawGreenLines(foxDraw, ystart, yend);



            // create a line drawing function that takes 2 parameters:
            // the x and y coordinates of the line's starting point
            // and draws a 50 long horizontal line from that point.
            // draw 3 lines with that function.

        }

        public static void DrawGreenLines(FoxDraw foxDraw, double y1, double y2)
        {


            foxDraw.StrokeColor(Colors.Green);

            for (int i = 0; i < 3; i++)
            {
                foxDraw.DrawLine(150, y1, 280, y2 );
                y1 = y1 + 50;
                y2 = y2 + 50;
            }

        }
    }
}
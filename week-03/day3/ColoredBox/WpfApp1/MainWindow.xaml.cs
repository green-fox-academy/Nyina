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

namespace ColoredBox
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            DrawGreenLines(foxDraw);
            // draw a box that has different colored lines on each edge.

        }

        public static void DrawGreenLines(FoxDraw foxDraw)
        {
            foxDraw.StrokeColor(Colors.Green);
            foxDraw.DrawLine(150, 110, 220, 110);

            foxDraw.StrokeColor(Colors.Red);
            foxDraw.DrawLine(150, 110, 150, 210);

            foxDraw.StrokeColor(Colors.Yellow);
            foxDraw.DrawLine(150, 210, 220, 210);

            foxDraw.StrokeColor(Colors.Black);
            foxDraw.DrawLine(220, 110, 220, 210);


            //foxDraw.DrawLine(startPoint, endPoint);
        }
    }
}

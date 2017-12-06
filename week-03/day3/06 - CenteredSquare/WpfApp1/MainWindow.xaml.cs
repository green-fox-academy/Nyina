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

namespace CenteredSquare
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            DrawGreenPolygon(foxDraw);
            // draw a green 10x10 square to the canvas' center.

        }
        public static void DrawGreenPolygon(FoxDraw foxDraw)
        {
            var points = new List<Point>();
            points.Add(new Point(100, 160));
            points.Add(new Point(150, 160));
            points.Add(new Point(150, 210));
            points.Add(new Point(100, 210));

            foxDraw.FillColor(Colors.Green);
            foxDraw.DrawPolygon(points);
        }
    }
}

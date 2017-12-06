using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using GreenFox;
using System.Windows.Media;

namespace LineInTheMiddle
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            DrawGreenLines(foxDraw);


            //  draw a red horizontal line to the canvas' middle.
            //  draw a green vertical line to the canvas' middle.


        }
        public static void DrawGreenLines(FoxDraw foxDraw)
        {
            foxDraw.StrokeColor(Colors.Red);
            foxDraw.DrawLine(200, 80, 200, 220);

            foxDraw.StrokeColor(Colors.Green);
            var startPoint = new Point(100, 150);
            var endPoint = new Point(300, 150);
            foxDraw.DrawLine(startPoint, endPoint);
          
        }



    }
}

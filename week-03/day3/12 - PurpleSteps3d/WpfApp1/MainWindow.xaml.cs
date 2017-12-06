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


namespace PurpleSteps3d
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            DrawRectangle(foxDraw);

            // reproduce this:
            // [https://github.com/greenfox-academy/teaching-materials/blob/master/workshop/drawing/purple-steps-3d/r4.png]

        }
        public static void DrawRectangle(FoxDraw foxDraw)
        {
            double X1 = 10;
            double Y1 = 10;
            double Size = 50;

            for( int i = 0; i < 7; i++)
            {
                foxDraw.FillColor(Colors.Purple);
                foxDraw.DrawRectangle(X1, Y1, Size , Size );
                X1 = X1 + Size;
                Y1 = Y1 + Size;
                Size = Size * 1.5;
            }
        }
    }
}

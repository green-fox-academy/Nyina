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

namespace CenterBoxFunction
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            DrawRectangle(foxDraw, 150);


            // create a square drawing function that takes 1 parameter:
            // the square size
            // and draws a square of that size to the center of the canvas.
            // draw 3 squares with that function.

        }
        public static void DrawRectangle(FoxDraw foxDraw, double Size)
        {
            Color[] color = { Colors.Red, Colors.Plum, Colors.Green };
            for (int i = 0; i < 3; i++)
            {
                foxDraw.DrawRectangle(262 - Size / 2, 175 - Size / 2, Size, Size);
                Size = Size - 50;
                foxDraw.FillColor(color[i]);
            }
        }
    }
}
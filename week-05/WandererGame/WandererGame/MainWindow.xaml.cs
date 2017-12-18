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

namespace WandererGame
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            var table = new Table(0, 0);
            var hero = new Hero(0, 0);

            table.DrawATable(foxDraw);
            table.DrawWall0(foxDraw);
            table.DrawWall1(foxDraw);
            table.DrawWall2(foxDraw);
            table.DrawWall3(foxDraw);
            table.DrawWall4(foxDraw);

            //hero.KeyDownEvent();

            Console.ReadLine();

        }



    }
}

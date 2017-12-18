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
        private FoxDraw foxDraw;
        private Table table;
        private Hero hero;

        public MainWindow()
        {
            InitializeComponent();
            foxDraw = new FoxDraw(canvas);
            table = new Table(0, 0);
            hero = new Hero("hero-down.png", 0, 0);

            table.DrawATable(foxDraw);
            table.DrawWall0(foxDraw);
            table.DrawWall1(foxDraw);
            table.DrawWall2(foxDraw);
            table.DrawWall3(foxDraw);
            table.DrawWall4(foxDraw);

            

            Console.ReadLine();

        }

        private void WindowKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Right)
            {
                hero.StepRight(foxDraw);
            }
            if (e.Key == Key.Left)
            {
                hero.StepLeft(foxDraw);
            }
            if (e.Key == Key.Down)
            {
                hero.StepDown(foxDraw);
            }
            if (e.Key == Key.Up)
            {
                hero.StepUp(foxDraw);
            }
        }



    }
}

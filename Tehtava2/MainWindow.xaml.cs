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

namespace Tehtava2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // muuttujat
        int x = 0;
        int y = 0;
        int sum = 0;

        public MainWindow()
        {
            InitializeComponent(); //lue design ikkunaan
        }

        private void Numero1_Click(object sender, RoutedEventArgs e)
        {
            if (x == 0)
                x = (x + 1);
            else
                y = (y + 1);
            Summa.Text = "1";
        }

        private void Numero2_Click(object sender, RoutedEventArgs e)
        {
            if (x == 0)
                x = (x + 2);
            else
                y = (y + 2);
            Summa.Text = "2";
        }

        private void Numero3_Click(object sender, RoutedEventArgs e)
        {
            if (x == 0)
                x = (x + 3);
            else
                y = (y + 3);
            Summa.Text = "3";
        }

        private void Numero4_Click(object sender, RoutedEventArgs e)
        {
            if(x == 0)
                x = (x + 4);
            else
                y = (y + 4);
            Summa.Text = "4";
        }

        private void Numero5_Click(object sender, RoutedEventArgs e)
        {
            if (x == 0)
                x = (x + 5);
            else
                y = (y + 5);
            Summa.Text = "5";
        }

        private void Numero6_Click(object sender, RoutedEventArgs e)
        {
            if (x == 0)
                x = (x + 6);
            else
                y = (y + 6);
            Summa.Text = "6";
        }

        private void Numero7_Click(object sender, RoutedEventArgs e)
        {
            if (x == 0)
                x = (x + 7);
            else
                y = (y + 7);
            Summa.Text = "7";
        }

        private void Numero8_Click(object sender, RoutedEventArgs e)
        {
            if (x == 0)
                x = (x + 8);
            else
                y = (y + 8);
            Summa.Text = "8";
        }

        private void Numero9_Click(object sender, RoutedEventArgs e)
        {
            if (x == 0)
                x = (x + 9);
            else
                y = (y + 9);
            Summa.Text = "9";
        }

        private void Yhtäkuin_Click(object sender, RoutedEventArgs e)
        {
            sum = (x + y);
            Summa.Text = "= " + sum;
            x = 0;
            y = 0;
            sum = 0;
        }
    }
}

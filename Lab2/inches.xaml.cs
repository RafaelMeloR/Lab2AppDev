using Lab2.Classes;
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
using System.Windows.Shapes;

namespace Lab2
{
    /// <summary>
    /// Interaction logic for inches.xaml
    /// </summary>
    public partial class inches : Window
    {
        AverageRainfall rain;
        public inches(string x, AverageRainfall rain)
        {
            InitializeComponent();
            lb1.Content = x;
            this.rain = rain; 
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            rain.setInches(double.Parse(inch.Text));
            Close();
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            inch.Focus();
        }

        private void inch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                btn1_Click(sender, e);
            }
        }
    }
}

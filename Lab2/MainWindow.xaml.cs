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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lab2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            if (combo1.SelectedIndex == 0)
            {
                TestScore testScore = new TestScore();
                Close();
                testScore.Show();
            }
            else if (combo1.SelectedIndex == 1)
            { 
                RainAverage rain = new RainAverage();
                Close();
                rain.Show();
            }
            else if ( combo1.SelectedIndex == 2)
            { 
                ShippingCharges shippingCharges = new ShippingCharges();
                Close();
                shippingCharges.Show();
            }
            else if (combo1.SelectedIndex == 3)
            {
                DistanceTraveled distanceTraveled = new DistanceTraveled(); 
                Close();
                distanceTraveled.Show();
            }
        }
    }
}

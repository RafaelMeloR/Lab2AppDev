using AS1;
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
    /// Interaction logic for ShippingCharges.xaml
    /// </summary>
    public partial class ShippingCharges : Window
    {
        public ShippingCharges()
        {
            InitializeComponent();
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            weight.Text = "";
            miles.Text = "";
            ratesLabel.Content = 0;
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            if (weight.Text == "")
            {
                weight.Text = "0";
            }
            if (miles.Text == "")
            {
                miles.Text = "0";
            }

            ShippingChargesClass rates = new ShippingChargesClass(double.Parse(weight.Text), int.Parse(miles.Text));
            ratesLabel.Content = rates.getShippingCharges()+" CAD";
        }
    }
}

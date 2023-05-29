using AS1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
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
using static System.Formats.Asn1.AsnWriter;

namespace Lab2
{
    /// <summary>
    /// Interaction logic for DistanceTraveled.xaml
    /// </summary>
    public partial class DistanceTraveled : Window
    {
        public DistanceTraveled()
        {
            InitializeComponent();
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            speed.Text = "";
            time.Text = "";
            distanceLabel.Content = 0;
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            if (speed.Text == "")
            {
                speed.Text = "0";
            }
            if (time.Text == "")
            {
                time.Text = "0";
            } 

            DistanceTravel dist = new DistanceTravel(int.Parse(speed.Text), double.Parse(time.Text));
            distanceLabel.Content = dist.getDistance() + "KM";

        }
    }
}

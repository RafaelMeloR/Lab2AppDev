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

namespace Lab2.Classes
{
    /// <summary>
    /// Interaction logic for RainAverage.xaml
    /// </summary>
    public partial class RainAverage : Window
    {
        public static Boolean setYears = false;
        public RainAverage()
        {
            InitializeComponent();
            
        }

        private void set_Click(object sender, RoutedEventArgs e)
        {
            setYears= true;
            years.IsEnabled = false;
            
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            years.Text = "";
            avg.Content = "";
            setYears= false;
        }

        private async void btn1_Click(object sender, RoutedEventArgs e)
        {
          
            if (years.Text == "" || setYears==false)
            { 
                years.IsEnabled = true;
                MessageBox.Show("Set the numbers of years to start");

            }
            else { 
            AverageRainfall rain = new AverageRainfall(int.Parse(years.Text));

            for (int n=0;n<int.Parse(years.Text);n++)
            {
                for (int m = 0; m < 12; m++)
                {
                    string x = ("Insert the amount of inches of rainfall for the year " + (n + 1) + " and month " + (m + 1));
                    inches i = new inches(x,rain);

                    await Application.Current.Dispatcher.InvokeAsync(() =>
                    {
                        i.ShowDialog();
                    });


                }

            }

           
            avg.Content = rain.getAverage();
            }
        }
    }
}

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
    /// Interaction logic for TestScore.xaml
    /// </summary>
    public partial class TestScore : Window
    {
        public TestScore()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            if (score1.Text == "")
            {
                score1.Text = "0";
            }
            if (score2.Text == "")
            {
                score2.Text = "0";
            }
            if (score3.Text == "")
            {
                score3.Text = "0";
            }

            TestScores testScores = new TestScores(int.Parse(score1.Text), int.Parse(score2.Text), int.Parse(score3.Text));
            avg.Content = testScores.average();
            
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            score1.Text = "";
            score2.Text = "";
            score3.Text = "";
            avg.Content = 0;
        }
    }
}

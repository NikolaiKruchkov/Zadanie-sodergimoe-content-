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

namespace Zadanie_Sodergimoe
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double rateDollar = Convert.ToDouble(rate.Text);
            double sumDollar = Convert.ToDouble(sum.Text);
            double resDollar = rateDollar * sumDollar;
            resSum.Text = resDollar.ToString();

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            double rateDollar2 = Convert.ToDouble(rate2.Text);
            double sumDollar2 = Convert.ToDouble(sum2.Text);
            double resDollar2 = rateDollar2 * sumDollar2;
            resSum2.Text = resDollar2.ToString();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            double rateDollar3 = Convert.ToDouble(rate3.Text);
            double sumDollar3 = Convert.ToDouble(sum3.Text);
            double resDollar3 = rateDollar3 * sumDollar3;
            resSum3.Text = resDollar3.ToString();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            double rateDollar4 = Convert.ToDouble(rate4.Text);
            double sumDollar4 = Convert.ToDouble(sum4.Text);
            double resDollar4 = rateDollar4 * sumDollar4;
            resSum4.Text = resDollar4.ToString();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            decimal rateDlina = Convert.ToDecimal(rate5.Text);
            decimal resDlina = rateDlina * Convert.ToDecimal(1.0936);
            resSum5.Text = resDlina.ToString();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            decimal rateDlina2 = Convert.ToDecimal(rate6.Text);
            decimal resDlina2 = rateDlina2 * Convert.ToDecimal(3.28084);
            resSum6.Text = resDlina2.ToString();

        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            decimal rateDlina3 = Convert.ToDecimal(rate7.Text);
            decimal resDlina3 = rateDlina3 * Convert.ToDecimal(0.000539957);
            resSum7.Text = resDlina3.ToString();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            decimal rateDlina4 = Convert.ToDecimal(rate8.Text);
            decimal resDlina4 = rateDlina4 * Convert.ToDecimal(39.3701);
            resSum8.Text = resDlina4.ToString();
        }
    }
}

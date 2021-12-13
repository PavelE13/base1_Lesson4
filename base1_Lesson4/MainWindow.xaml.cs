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

namespace base1_Lesson4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
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
            double sumDollar = Convert.ToDouble(summ.Text);
            double resDouble = rateDollar * sumDollar;
            resSumm.Text = resDouble.ToString("0.00");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            double rateEUR = Convert.ToDouble(rate1.Text);
            double sumEUR = Convert.ToDouble(summ1.Text);
            double resDouble = rateEUR * sumEUR;
            resSumm1.Text = resDouble.ToString("0.00");
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            double rateGBF = Convert.ToDouble(rate2.Text);
            double sumGBF = Convert.ToDouble(summ2.Text);
            double resDouble = rateGBF * sumGBF;
            resSumm2.Text = resDouble.ToString("0.00");
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            double rateTEN = Convert.ToDouble(rate3.Text);
            double sumTEN = Convert.ToDouble(summ3.Text);
            double resDouble = rateTEN * sumTEN;
            resSumm3.Text = resDouble.ToString("0.00");
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            const double dyim = 39.37;
            double unitDuym = Convert.ToDouble(unit.Text);
            double resCalcDouble = unitDuym / dyim;
            resCalc.Text = resCalcDouble.ToString("0.0000");
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            const double fut = 3.281;
            double unitfut = Convert.ToDouble(unit2.Text);
            double resCalc2Double = unitfut / fut;
            resCalc2.Text = resCalc2Double.ToString("0.0000");
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            const double mile = 1609.34;
            double unitmile = Convert.ToDouble(unit3.Text);
            double resCalc3Double = unitmile * mile;
            resCalc3.Text = resCalc3Double.ToString("0.0000");
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            const double yard = 1.094;
            double unitarch = Convert.ToDouble(unit4.Text);
            double resCalc4Double = unitarch / yard;
            resCalc4.Text = resCalc4Double.ToString("0.0000");
        }
    }
}

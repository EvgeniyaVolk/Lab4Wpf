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

namespace Lab4Wpf
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
            double rateDollar = Convert.ToDouble(rateD.Text);
            double sumDollar = Convert.ToDouble(sumD.Text);
            double resDollar = rateDollar * sumDollar;
            resSumD.Text = resDollar.ToString();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            double rateEuro = Convert.ToDouble(rateE.Text);
            double sumEuro = Convert.ToDouble(sumE.Text);
            double resEuro = rateEuro * sumEuro;
            resE.Text = resEuro.ToString();

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            double ratePound = Convert.ToDouble(rateP.Text);
            double sumPound = Convert.ToDouble(sumP.Text);
            double resPound = ratePound*sumPound;
            resP.Text = resPound.ToString();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            double rateHryvnia = Convert.ToDouble(rateH.Text);
            double sumHryvnia = Convert.ToDouble(sumH.Text);
            double resHryvnia = rateHryvnia * sumHryvnia;
            resH.Text = resHryvnia.ToString();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            double rateFoot = Convert.ToDouble(rateF.Text);
            double resFoot = 3048 * rateFoot / 10000;
            resF.Text = resFoot.ToString();
        }

        private void Рассчитать_Click(object sender, RoutedEventArgs e)
        {
            double rateInch = Convert.ToDouble(rateI.Text);
            double resInch = 25 * rateInch / 1000;
            resI.Text = resInch.ToString();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            double rateMiles = Convert.ToDouble(rateM.Text);
            double resMiles = 1609.34 * rateMiles;
            resM.Text = resMiles.ToString();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            double rateVerst = Convert.ToDouble(rateV.Text);
            double resVerst = 1066.8 * rateVerst;
            resV.Text = resVerst.ToString();
        }
    }
}

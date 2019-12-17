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

namespace Main
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

        private double calculate(double g, double M, double R, double p0, double h0, double h, double T)
        {
            return Math.Pow((p0 * Math.E), (-g * M * (h - h0) / (R * T)));
        }

        private void button_click(object sender, RoutedEventArgs e)
        {
            double g = 9.80665;
            double M = 0.0289644;
            double R = 8.31432;
            double p0 = 1;
            double h0 = 0;
            double h = double.Parse(Altitude.Text);
            double T = double.Parse(Temperature.Text);
            string output = calculate(g, M, R, p0, h0, h, T).ToString("F2");
            Pressure.Text = output;
        }
    }
}

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

using static Pr2.rZF;


namespace Pr2
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

        private void Dod(object sender, RoutedEventArgs e)
        {
            rez.Text = Convert.ToString(DOD(Convert.ToDouble(ch0.Text), Convert.ToInt32(ch1.Text)));
        }

        private void Podil(object sender, RoutedEventArgs e)
        {
            rez.Text = Convert.ToString(POD(Convert.ToDouble(ch0.Text), Convert.ToInt32(ch1.Text)));
        }

        private void Pomnij(object sender, RoutedEventArgs e)
        {
            rez.Text = Convert.ToString(POM(Convert.ToDouble(ch0.Text), Convert.ToInt32(ch1.Text)));
        }

        private void Vid(object sender, RoutedEventArgs e)
        {
            rez.Text = Convert.ToString(VID(Convert.ToDouble(ch0.Text), Convert.ToInt32(ch1.Text)));
        }
    }
}

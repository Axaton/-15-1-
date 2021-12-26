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
using Lib_10;

namespace practice_1
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

        private void Calculate_Click(object sender, RoutedEventArgs e)
        {
            int k;
            bool f = Int32.TryParse(inputValue.Text, out k);
            if (f == true)
            {
                var result = Practice.Total(k);
                Summ.Text = result.sum.ToString();
                Nambers.Text = result.number;
                CountNumbers.Text = result.count.ToString();
            }
            else
            {
                MessageBox.Show("Ведите корректные данные!");
            }
        }

        private void Info_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Харенко Кирилл ИСП-34", "Разработчик", MessageBoxButton.OK);
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
using System.Windows.Threading;

namespace Lab1302
{
    
    public partial class MainWindow : Window
    {
        int count = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                char[] str = text.Text.ToCharArray();
                char symbl = Convert.ToChar(symbol.Text);
                for (int i = 0; i < str.Length; i++)
                {
                    if (str[i] == symbl)
                    {
                        count++;
                    }
                }
                MessageBox.Show($"{count++} ");
            }
            catch (Exception)
            {
                symbol.Background = Brushes.Red;
                MessageBox.Show($"Необходимо ввести один символ");
                symbol.Background = Brushes.White;
            }
            
        }
    }
}

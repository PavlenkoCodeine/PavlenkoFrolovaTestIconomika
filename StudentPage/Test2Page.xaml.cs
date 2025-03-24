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

namespace PavlenkoFrolovaTestIconomika.StudentPage
{
    /// <summary>
    /// Логика взаимодействия для Test2Page.xaml
    /// </summary>
    public partial class Test2Page : Page
    {
        int b = 0;
        int c = 0;
        public Test2Page()
        {
            InitializeComponent();
        }

        private void p5_Click(object sender, RoutedEventArgs e)
        {
            if (TextBox3.Text == "2")
            {
                MessageBox.Show("Правильно");
                b = b + 1;
            }
            else MessageBox.Show("Неправильно");
            p5.Visibility = Visibility.Collapsed;
            products.SelectedItem = v2;
        }

        private void p6_Click(object sender, RoutedEventArgs e)
        {
            if (TextBox4.Text == "1")
            {
                MessageBox.Show("Правильно");
                b = b + 1;
            }
            else MessageBox.Show("Неправильно");
            p6.Visibility = Visibility.Collapsed;
            products.SelectedItem = v3;
        }

        private void p7_Click(object sender, RoutedEventArgs e)
        {
            if (TextBox4.Text == "1")
            {
                MessageBox.Show("Правильно");
                b = b + 1;
            }
            else MessageBox.Show("Неправильно");
            p7.Visibility = Visibility.Collapsed;
            products.SelectedItem = v4;
        }

        private void p8_Click(object sender, RoutedEventArgs e)
        {
            if (TextBox6.Text == "4")
            {
                MessageBox.Show("Правильно");
                b = b + 1;
            }
            else MessageBox.Show("Неправильно");
            p8.Visibility = Visibility.Collapsed;
            products.SelectedItem = v5;
        }

        private void p9_Click(object sender, RoutedEventArgs e)
        {
            if (TextBox7.Text == "1")
            {
                MessageBox.Show("Правильно");
                b = b + 1;
            }
            else MessageBox.Show("Неправильно");
            p9.Visibility = Visibility.Collapsed;
            products.SelectedItem = v6;
        }

        private void p10_Click(object sender, RoutedEventArgs e)
        {
            if (TextBox8.Text == "3")
            {
                MessageBox.Show("Правильно");
                b = b + 1;
            }
            else MessageBox.Show("Неправильно");
            p10.Visibility = Visibility.Collapsed;
            products.SelectedItem = v7;
        }

        private void p11_Click(object sender, RoutedEventArgs e)
        {
            if (TextBox9.Text == "1")
            {
                MessageBox.Show("Правильно");
                b = b + 1;
            }
            else MessageBox.Show("Неправильно");
            p11.Visibility = Visibility.Collapsed;
            products.SelectedItem = v8;
        }

        private void p12_Click(object sender, RoutedEventArgs e)
        {
            if (TextBox10.Text == "2")
            {
                MessageBox.Show("Правильно");
                b = b + 1;
            }
            else MessageBox.Show("Неправильно");
            p12.Visibility = Visibility.Collapsed;
            products.SelectedItem = v9;
        }

        private void p13_Click(object sender, RoutedEventArgs e)
        {
            if (TextBox11.Text == "5")
            {
                MessageBox.Show("Правильно");
                b = b + 1;
            }
            else MessageBox.Show("Неправильно");
            p13.Visibility = Visibility.Collapsed;
            products.SelectedItem = v10;
        }

        private void p14_Click(object sender, RoutedEventArgs e)
        {
            if (TextBox12.Text == "5")
            {
                MessageBox.Show("Правильно");
                b = b + 1;
            }
            else MessageBox.Show("Неправильно");
            p14.Visibility = Visibility.Collapsed;
            products.SelectedItem = v11;
        }

        private void p15_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}

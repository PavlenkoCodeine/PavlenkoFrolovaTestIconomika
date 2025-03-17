using PavlenkoFrolovaTestIconomika.AppData;
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

namespace PavlenkoFrolovaTestIconomika.MainPage
{
    /// <summary>
    /// Логика взаимодействия для AutoPrepodavatelPage.xaml
    /// </summary>
    public partial class AutoPrepodavatelPage : Page
    {
        public AutoPrepodavatelPage()
        {
            InitializeComponent();
        }

        private void OKBtn_Click(object sender, RoutedEventArgs e)
        {
            string mes = "";
            if (string.IsNullOrWhiteSpace(PasswordBtn.Password))
                mes += "Введите пароль\n";
            if (mes != "")
            {
                MessageBox.Show(mes);
                mes = "";
                return;
            }
            if (PasswordBtn.Password == "123")
            {
                ClassFrame.FrameBody.Navigate(new MenuPage());
            }
            else
            {
                MessageBox.Show("Неверный пароль!");
            }
        }
    }
}

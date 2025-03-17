using PavlenkoFrolovaTestIconomika.AppData;
using PavlenkoFrolovaTestIconomika.StudentPage;
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
    /// Логика взаимодействия для SttartPage.xaml
    /// </summary>
    public partial class SttartPage : Page
    {
        public SttartPage()
        {
            InitializeComponent();
        }

        private void PrepBtn_Click(object sender, RoutedEventArgs e)
        {
            ClassFrame.FrameBody.Navigate(new AutoPrepodavatelPage());
        }

        private void StudentBtn_Click(object sender, RoutedEventArgs e)
        {
            ClassFrame.FrameBody.Navigate(new ChoicePage());
        }
    }
}

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
    /// Логика взаимодействия для GroupPage.xaml
    /// </summary>
    public partial class GroupPage : Page
    {
        public GroupPage()
        {
            InitializeComponent();
           
        }

        private void AddBtn_Click_1(object sender, RoutedEventArgs e)
        {
            string mes = "";
            if (string.IsNullOrWhiteSpace(Name.Text))
                mes += "Введите название группы\n";
            if (mes != "")
            {
                MessageBox.Show(mes);
                mes = "";
                return;
            }
            Group group = new Group()
            {
                Name = Name.Text,
            };
            App.Ent.Group.Add(group);
            App.Ent.SaveChanges();
            MessageBox.Show("Группа добавлена");

            Name.Text = "";
        }

        private void FeedBtn_Click_1(object sender, RoutedEventArgs e)
        {
            ClassFrame.FrameBody.Navigate(new MenuPage());
        }
    }
}

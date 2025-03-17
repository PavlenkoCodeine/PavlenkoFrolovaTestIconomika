using PavlenkoFrolovaTestIconomika.AppData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Логика взаимодействия для AddStudentPage.xaml
    /// </summary>
    public partial class AddStudentPage : Page
    {
        public AddStudentPage()
        {
            InitializeComponent();
            GroupCmb.SelectedValuePath = "ID";
            GroupCmb.DisplayMemberPath = "Name";
            GroupCmb.ItemsSource = App.Ent.Group.ToList();
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            string mes = "";
            if (string.IsNullOrWhiteSpace(Name.Text))
                mes += "Введите имя студента\n";
            if (string.IsNullOrWhiteSpace(GroupCmb.Text))
                mes += "Выберите группу\n";
            if (mes != "")
            {
                MessageBox.Show(mes);
                mes = "";
                return;
            }
            Student student = new Student()
            {
                Name = Name.Text,
                IdGroup = ((Group)GroupCmb.SelectedItem).ID
            };
            App.Ent.Student.Add(student);
            App.Ent.SaveChanges();
            MessageBox.Show("Студент добавлен");

            Name.Text = "";
            GroupCmb.Text = "";
        }

        private void FeedBtn_Click(object sender, RoutedEventArgs e)
        {
            ClassFrame.FrameBody.Navigate(new MenuPage());
        }
    }
}

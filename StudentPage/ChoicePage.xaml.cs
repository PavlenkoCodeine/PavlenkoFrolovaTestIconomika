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

namespace PavlenkoFrolovaTestIconomika.StudentPage
{
    /// <summary>
    /// Логика взаимодействия для ChoicePage.xaml
    /// </summary>
    public partial class ChoicePage : Page
    {
        public ChoicePage()
        {
            InitializeComponent();
            CmbGroup.SelectedValuePath = "ID";
            CmbGroup.DisplayMemberPath = "Name";
            CmbGroup.ItemsSource = App.Ent.Group.ToList();

            CmbStudent.SelectedValuePath = "ID";
            CmbStudent.DisplayMemberPath = "Name";
            CmbStudent.ItemsSource = App.Ent.Student.ToList();

            CmbTest.SelectedValuePath = "ID";
            CmbTest.DisplayMemberPath = "Name";
            CmbTest.ItemsSource = App.Ent.Test.ToList();
        }

        private void CmbGroup_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int SelectedGroup = Convert.ToInt32(CmbGroup.SelectedValue);
            CmbStudent.ItemsSource = App.Ent.Student.Where
                (x=> x.IdGroup==SelectedGroup).ToList();    
        }

        private void BtnStart_Click(object sender, RoutedEventArgs e)
        {
            string mes = "";
            if (string.IsNullOrWhiteSpace(CmbGroup.Text))
                mes += "Выберите группу\n";
            if (string.IsNullOrWhiteSpace(CmbStudent.Text))
                mes += "Выберите студента\n";
            if (string.IsNullOrWhiteSpace(CmbTest.Text))
                mes += "Выберите тест\n";
            if (mes != "")
            {
                MessageBox.Show(mes);
                mes = "";
                return;
            }
            else if (CmbTest.Text == "Общие основы функционирования субъектов хозяйствования")
            {
                ClassFrame.FrameBody.Navigate(new StudentPage.Test1Page());
            }
            else if (CmbTest.Text == "Сущность и структура основного капитала и оборотных средств предприятия")
            {
                ClassFrame.FrameBody.Navigate(new StudentPage.Test2Page());
            }
            else if (CmbTest.Text == "Формы и системы оплаты труда")
            {
                ClassFrame.FrameBody.Navigate(new StudentPage.Test3Page());
            }
            else if (CmbTest.Text == "Результаты коммерческой деятельности")
            {
                ClassFrame.FrameBody.Navigate(new StudentPage.Test4Page());
            }
            ClassVariable.classman = Convert.ToInt32(CmbStudent.SelectedValue);
        }
    }
}

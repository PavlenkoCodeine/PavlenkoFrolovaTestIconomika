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
    /// Логика взаимодействия для ListMarkPage.xaml
    /// </summary>
    public partial class ListMarkPage : Page
    {
        public ListMarkPage()
        {
            InitializeComponent();
            GroupCmb.SelectedValuePath = "ID";
            GroupCmb.DisplayMemberPath = "Name";
            GroupCmb.ItemsSource = App.Ent.Group.ToList();

            StCmb.SelectedValuePath = "ID";
            StCmb.DisplayMemberPath = "Name";
            StCmb.ItemsSource = App.Ent.Student.ToList();
        }
       
        private void fekBtn_Click(object sender, RoutedEventArgs e)
        {
            ClassFrame.FrameBody.Navigate(new MenuPage());
        }

        private void PrintBtn_Click(object sender, RoutedEventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            if (printDialog.ShowDialog() == true) printDialog.PrintVisual(GridJournal, "Студенты");
        }

        private void StCmb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int SelectedSt = Convert.ToInt32(StCmb.SelectedValue);

            GridJournal.ItemsSource = App.Ent.Journal.Where(x => x.IdStudent == SelectedSt).ToList();
        }

        private void GroupCmb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int SelectedS = Convert.ToInt32(GroupCmb.SelectedValue);
            StCmb.ItemsSource = App.Ent.Student.Where(x => x.IdGroup == SelectedS).ToList();
            int SelectedGroup = Convert.ToInt32(GroupCmb.SelectedValue);
            GridJournal.ItemsSource = App.Ent.Journal.Where(x => x.Student.IdGroup== SelectedGroup).ToList();
        }

        private void GridJournal_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}

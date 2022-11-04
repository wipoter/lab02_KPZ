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
using Organizer.UI.ViewModels;

namespace Organizer.UI.View
{
    /// <summary>
    /// Interaction logic for AdminUserControl.xaml
    /// </summary>
    public partial class AdminUserControl : UserControl
    {
        public AdminUserControl()
        {
            InitializeComponent();
        }

        private void Button_Click_Positive(object sender, RoutedEventArgs e)
        {
            try
            {
                var achievement = (AchievementViewModel)DataGrid2.SelectedItem;
                achievement.IsPositive = Status.Positive;
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        private void DataGrid1_OnMouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (dataGrid1.CurrentCell.Item is StudentViewModel)
            {
                var selected = (StudentViewModel)dataGrid1.CurrentCell.Item;
                DataGrid2.ItemsSource = selected.Achievements;
                Close.Visibility = Visibility.Visible;
            }
        }

        private void Button_Click_Negative(object sender, RoutedEventArgs e)
        {
            try
            {
                var achievement = (AchievementViewModel)DataGrid2.SelectedItem;
                achievement.IsPositive = Status.Negative;
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}

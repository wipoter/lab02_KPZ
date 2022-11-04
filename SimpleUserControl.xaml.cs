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
    /// Interaction logic for SimpleUserControl.xaml
    /// </summary>
    public partial class SimpleUserControl : UserControl
    {
        public SimpleUserControl()
        {
            InitializeComponent();
        }

        private void ButtonBase_Profile(object sender, RoutedEventArgs e)
        {
            ButPro.Opacity = 0.5;
            ButStat.Opacity = 1;
            Profile.Visibility = Visibility.Visible;
            Achive.Visibility = Visibility.Hidden;
            var data = (DataModelView)DataContext;

            var tmp1 = data.ObservableDictionary.Where(k => k.Key.Login == RegNameUserControl.Now);
                        
            Ach.ItemsSource = tmp1.First().Value.Achievements;
            NameA.Content = tmp1.First().Value.Name;
            SurnameA.Content = tmp1.First().Value.Surname;
            InstituteA.Content = tmp1.First().Value.Institute;
            GroupA.Content = tmp1.First().Value.Group;
            NumbA.Content = tmp1.First().Value.NumberOfGroup;

            Ach.ItemsSource = tmp1.First().Value.Achievements;
        }

        private void ButStat_OnClick(object sender, RoutedEventArgs e)
        {
             ButPro.Opacity = 1;
             ButStat.Opacity = 0.5;
             Profile.Visibility = Visibility.Hidden;
             Achive.Visibility = Visibility.Visible;
             
             var data = (DataModelView)DataContext;

             var tmp1 = data.ObservableDictionary.Where(k => k.Key.Login == RegNameUserControl.Now);
                        
             Ach.ItemsSource = tmp1.First().Value.Achievements;
             NameA.Content = tmp1.First().Value.Name;
             SurnameA.Content = tmp1.First().Value.Surname;
             InstituteA.Content = tmp1.First().Value.Institute;
             GroupA.Content = tmp1.First().Value.Group;
             NumbA.Content = tmp1.First().Value.NumberOfGroup;

             Ach.ItemsSource = tmp1.First().Value.Achievements;
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            ButtonQuit.CommandParameter = "LogUser";
        }
    }
}

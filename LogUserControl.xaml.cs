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
    /// Interaction logic for LogUserControl.xaml
    /// </summary>
    public partial class LogUserControl : UserControl
    {
        public LogUserControl()
        {
            InitializeComponent();
        }

        private void ButtonLogIn_OnClick(object sender, RoutedEventArgs e)
        {
            ErrorLogIn.Visibility = Visibility.Hidden;
            string loggin = LogBox.Text;
            string password = PassBox.Password;
            var list = (DataModelView)DataContext;
            var tmp = list.ObservableDictionary.Keys.Where(k => k.Login == loggin);
            if (tmp.Count() == 1)
            {
                if (tmp.First().Password == password)
                {
                    if (tmp.First().IsAdmin == true)
                    {
                        LogButton.CommandParameter = "Admin";
                    }
                    else
                    {
                        RegNameUserControl.Now = tmp.First().Login;
                        LogButton.CommandParameter = "Simple";

                        

                    }
                }
                else
                {
                    LogButton.CommandParameter = "LogUser";
                    ErrorLogIn.Visibility = Visibility.Visible;
                }
            }
            else
            {
                LogButton.CommandParameter = "LogUser";
                ErrorLogIn.Visibility = Visibility.Visible;
            }
        }



        private void SingUp_OnMouseEnter(object sender, MouseEventArgs e) =>
            SingUp.Foreground = new SolidColorBrush(Colors.Crimson);

        private void SingUp_OnMouseLeave(object sender, MouseEventArgs e) =>
            SingUp.Foreground = new SolidColorBrush(Colors.Black);

        private void UIElement_OnIsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            LogBox.Text = String.Empty;
            PassBox.Password = String.Empty;
        }
    }
}

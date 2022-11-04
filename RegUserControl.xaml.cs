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
    /// Interaction logic for RegUserControl.xaml
    /// </summary>
    public partial class RegUserControl : UserControl
    {
        public RegUserControl()
        {
            InitializeComponent();
        }

        private void ButtonReg_OnClick(object sender, RoutedEventArgs e)
        {
            ErrorLogInReg.Visibility = Visibility.Hidden;
            string login = LogBoxReg.Text;
            //.Accounts.Where(k => k.Login == login).Count() == 0
            var data = (DataModelView)DataContext;
            if (data.Accounts.Where(k => k.Login == login).Count() == 0)
            {
                if (PassBoxReg.Password == PassBoxRegRep.Password)
                {
                    data.ObservableDictionary.Add(
                        new AccountViewModel() { Login = login, Password = PassBoxRegRep.Password, IsAdmin = false },
                        new StudentViewModel());
                    ButtonSing.CommandParameter = "RegName";
                    //RegPage.Visibility = Visibility.Hidden;
                    //RegName.Visibility = Visibility.Visible;
                }
                else
                {
                    ErrorLogInReg.Content = "Passwords are not the same!";
                    ErrorLogInReg.Visibility = Visibility.Visible;
                    ButtonSing.CommandParameter = "RegUser";
                }
            }
            else
            {
                ErrorLogInReg.Content = "This login is already used!";
                ErrorLogInReg.Visibility = Visibility.Visible;
                ButtonSing.CommandParameter = "RegUser";
            }
        }

        private void UIElement_OnIsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            LogBoxReg.Text = "";
            PassBoxReg.Password = "";
            PassBoxRegRep.Password = "";
        }
    }
}

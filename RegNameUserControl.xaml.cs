using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
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
using Organizer.UI.ViewModels;

namespace Organizer.UI.View
{
    /// <summary>
    /// Interaction logic for RegNameUserControl.xaml
    /// </summary>
    public partial class RegNameUserControl : UserControl
    {
        public static string Now { get; set; }
        public RegNameUserControl()
        {
            InitializeComponent();
        }
        private void PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }
        private void ButtonRegName_Click(object sender, RoutedEventArgs e)
        {
            var data = (DataModelView)DataContext;
            data.ObservableDictionary.Last().Value.Name = LogBoxName.Text;
            data.ObservableDictionary.Last().Value.Surname = LogBoxSurname.Text;
            data.ObservableDictionary.Last().Value.Institute = LogBoxInst.Text;
            data.ObservableDictionary.Last().Value.Group = LogBoxGroup.Text;
            data.ObservableDictionary.Last().Value.NumberOfGroup = Int32.Parse(LogBoxNumb.Text);
            data.ObservableDictionary.Last().Value.Achievements = new ObservableCollection<AchievementViewModel>();
            data.ObservableDictionary.Last().Value.Achievements.Add(new AchievementViewModel() { IsPositive = Status.Positive, Name = "First step!", Descripyion = "Registred.", Cost = 2 });

            Now = data.ObservableDictionary.Keys.Last().Login;

            ButtonName.CommandParameter = "Simple";

            var tmp = data.ObservableDictionary.Where(k => k.Key.Login == Now);
        }

        private void UIElement_OnIsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            LogBoxName.Text = String.Empty;
            LogBoxSurname.Text = String.Empty;
            LogBoxInst.Text = String.Empty;
            LogBoxGroup.Text = String.Empty;
            LogBoxNumb.Text = String.Empty;
        }
    }
}

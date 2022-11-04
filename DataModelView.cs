using Organizer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Organizer.UI.ViewModels
{
    internal class DataModelView:ViewModelBase
    {
        public DataModelView() => SetControlVisibility = new Command(ControlVisibility);
        public ICommand SetControlVisibility { get; set; }

        public void ControlVisibility(object args) => VisibleControl = args.ToString();

        public List<StudentViewModel> Students { get; set; }
        public List<AccountViewModel> Accounts { get; set; }
        public ObservableDictionary<AccountViewModel, StudentViewModel> ObservableDictionary { get; set; }
        
        private string _visibleControl = "LogUser";
        public string VisibleControl
        {
            get => _visibleControl;
            set
            {
                _visibleControl = value;
                OnPropertyChanged("VisibleControl");
            }
        }
    }
}

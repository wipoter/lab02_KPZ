using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Organizer.Model;

namespace Organizer.UI.ViewModels;

public class DataViewModel:ViewModelBase
{
    private ObservableDictionary<AccountViewModel, StudentViewModel> _students;
    public ObservableDictionary<AccountViewModel, StudentViewModel> Acounts
    {
        get => _students;
        set
        {
            _students = value;
            OnPropertyChanged("Acounts");
        }
    }
}
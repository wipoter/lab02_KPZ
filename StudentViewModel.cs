using System.Collections.Generic;
using System.Collections.ObjectModel;
using Organizer.Model;

namespace Organizer.UI.ViewModels;

public class StudentViewModel : ViewModelBase
{
    private string name;
    private string surname;
    private string institute;
    private string group;
    private int numberOfGroup;
    
    public ObservableCollection<AchievementViewModel> achievements;
    
    public string Name
    {
        get => name;
        set
        {
            name = value; 
            OnPropertyChanged("Name");
        }
    }

    public string Surname
    {
        get => surname;
        set
        {
            surname = value; 
            OnPropertyChanged("Surname");
        }
    }

    public string Institute
    {
        get => institute;
        set
        {
            institute = value; 
            OnPropertyChanged("Institute");
        }
    }

    public string Group
    {
        get => group;
        set
        {
            group = value; 
            OnPropertyChanged("Group");
        }
    }

    public int NumberOfGroup
    {
        get => numberOfGroup;
        set
        {
            numberOfGroup = value; 
            OnPropertyChanged("NumberOfGroup");
        }
    }

    public ObservableCollection<AchievementViewModel> Achievements
    {
        get => achievements;
        set
        {
            achievements = value;
            OnPropertyChanged("Achievements");
        }
    }
}
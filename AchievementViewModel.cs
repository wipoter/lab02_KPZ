namespace Organizer.UI.ViewModels;

public class AchievementViewModel: ViewModelBase
{
    private Status isPositive;
    private string name;
    private string descripyion;
    private int cost;
    
    public Status IsPositive
    {
        get => isPositive;
        set
        {
            isPositive = value;
            OnPropertyChanged("IsPositive");
        }
    }

    public string Name
    {
        get => name;
        set
        {
            name = value;
            OnPropertyChanged("Name");
        }
    }

    public string Descripyion
    {
        get => descripyion;
        set
        {
            descripyion = value;
            OnPropertyChanged("Descripyion");
        }
    }

    public int Cost
    {
        get => cost;
        set
        {
            cost = value; 
            OnPropertyChanged("Cost");
        }
    }
}
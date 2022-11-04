namespace Organizer.UI.ViewModels;

public class AccountViewModel: ViewModelBase
{
    private string login;
    private string password;
    private bool isAdmin;


    public string Login
    {
        get => login;
        set
        {
            login = value; 
            OnPropertyChanged("Login");
        }
    }

    public string Password
    {
        get => password;
        set
        {
            password = value;
            OnPropertyChanged("Password");
        }
    }

    public bool IsAdmin
    {
        get => isAdmin;
        set
        {
            isAdmin = value;
            OnPropertyChanged("IsAdmin");
        }
    }
}
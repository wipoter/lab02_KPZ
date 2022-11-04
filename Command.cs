using System;
using System.Windows.Input;

namespace Organizer.UI.ViewModels;

public class Command:ICommand
{
    public Command(Action<object> action) => ExecuteDelegate = action;

    public Predicate<object> CanExecuteDelegate { get; set; }
    public Action<object> ExecuteDelegate { get; set; }

    #region Icommand

    public bool CanExecute(object? parameter) => CanExecuteDelegate != null ? CanExecuteDelegate(parameter) : true;

    public void Execute(object? parameter)
    {
        if (ExecuteDelegate != null) ExecuteDelegate(parameter);
    }

    public event EventHandler? CanExecuteChanged
    {
        add { CommandManager.RequerySuggested += value; }
        remove { CommandManager.RequerySuggested -= value; }
    }

    #endregion
    
}
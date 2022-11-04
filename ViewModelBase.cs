﻿using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Organizer.UI.ViewModels;

public class ViewModelBase: INotifyPropertyChanged
{
    public event PropertyChangedEventHandler? PropertyChanged;

    protected void OnPropertyChanged(string propertyName)
    {
        PropertyChangedEventHandler handler = PropertyChanged;

        if (handler != null)
            handler(this, new PropertyChangedEventArgs(propertyName));
    }
}
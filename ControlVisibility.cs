﻿using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace Organizer.UI.Converter;

public class ControlVisibility:IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        return value.ToString() == parameter.ToString() ? Visibility.Visible : Visibility.Hidden;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}
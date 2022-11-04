using System;
using System.Globalization;
using System.IO;
using System.Windows.Data;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using Organizer.Model;


namespace Organizer.UI.Converter;

public class ImagePathConvertor:IValueConverter
{
    public ImageSource Positive { get; set; }
    public ImageSource Negative { get; set; }
    
    
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        var status = (Status)value;
        var uri = new Uri($"D:/Projects/Lab02_KPZ/Organizer.UI/Image/{status}.png", UriKind.RelativeOrAbsolute);
        return new BitmapImage(uri);
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}
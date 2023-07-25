using System.Globalization;

namespace PocketManager.Services.Converters;
public class SizeExpanderConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        return double.TryParse(value.ToString(), out var numerator) &&
           double.TryParse(parameter.ToString(), out double denominator) &&
           denominator is not 0 ?
           numerator + denominator : numerator;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}


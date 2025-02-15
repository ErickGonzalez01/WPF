using System.Globalization;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Data;

namespace System_Retail_Operation_POS.Converter
{
    public class StringToDoubleConvert : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if(value is double intValue)
            {
                return intValue.ToString();
            }
            return string.Empty;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if(double.TryParse(value as string, out double result))
            {
                return result;
            }
            return DependencyProperty.UnsetValue;
        }
    }
}

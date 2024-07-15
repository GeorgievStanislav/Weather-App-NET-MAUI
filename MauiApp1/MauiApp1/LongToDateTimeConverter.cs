using System.Globalization;

namespace MauiApp1
{
    public class LongToDateTimeConverter : IValueConverter
    {
        DateTime _time = new DateTime(1970,1,1,0,0,0,0);
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            int dateTime = (int)value;
            return $"{_time.AddSeconds(dateTime).ToString()}";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}

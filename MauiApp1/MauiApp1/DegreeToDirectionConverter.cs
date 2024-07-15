using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1
{
    internal class DegreeToDirectionConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            double deg = (Int64)value;
            deg = Math.Round(deg / 45)+1;
            return deg switch
            {
                1 => "N",
                2 => "NE",
                3 => "E",
                4 => "SE",
                5 => "S",
                6 => "SW",
                7 => "W",
                8 => "NW",
                9 => "NW",
                _ => "NaN",
            };
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}

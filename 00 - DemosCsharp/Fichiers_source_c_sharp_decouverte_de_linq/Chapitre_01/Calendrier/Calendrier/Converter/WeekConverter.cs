using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace Calendrier.Converter
{
    [ValueConversion(typeof(DateTime), typeof(string))]
    class WeekConverter: IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (value == null) throw new NullReferenceException("la valeur ne peut pas être null");
            var d = (DateTime)value;
            return System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.DayNames[(int)d.DayOfWeek];
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}

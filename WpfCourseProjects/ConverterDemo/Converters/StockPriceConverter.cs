using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Data;

namespace ConverterDemo.Converters
{
    internal class StockPriceConverter : IValueConverter
    {
        public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            if (value is not null)
            {
                double amount = (double)value;

                double percent = parameter is not null ? double.Parse((string)parameter) : 1.18;

                return (amount * percent).ToString("0.0000");
            }

            return string.Empty;
        }

        public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}

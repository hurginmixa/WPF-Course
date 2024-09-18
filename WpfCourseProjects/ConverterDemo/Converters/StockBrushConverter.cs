﻿using System.Globalization;
using System.Windows;
using System.Windows.Data;
using System.Windows.Media;

namespace ConverterDemo.Converters;

internal class StockBrushConverter : IValueConverter
{
    public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        if (value is not null)
        {
            double amount = (double)value;

            return amount > 100 ? SystemColors.WindowBrush : new SolidColorBrush(Colors.LightPink);
        }

        return new SolidColorBrush(Colors.Blue);
    }

    public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}
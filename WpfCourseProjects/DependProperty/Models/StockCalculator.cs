using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DependProperty.Models
{
    internal class StockCalculator : DependencyObject
    {
        public int MyProperty
        {
            get => (int)GetValue(MyPropertyProperty);
            set => SetValue(MyPropertyProperty, value);
        }

        public static readonly DependencyProperty MyPropertyProperty =
            DependencyProperty.Register(
                name: nameof(MyProperty),
                propertyType: typeof(int),
                ownerType: typeof(StockCalculator),
                typeMetadata: new PropertyMetadata(0));
    }
}

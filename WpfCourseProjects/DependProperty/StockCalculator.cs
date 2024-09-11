using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DependProperty
{
    internal class StockCalculator
    {
        public int MyProperty
        {
            get { return (int)GetValue(MyPropertyProperty); }
            set { SetValue(MyPropertyProperty, value); }
        }

        public static int GetValue(DependencyObject obj) => (int)obj.GetValue(MyPropertyProperty);

        public static readonly DependencyProperty MyPropertyProperty =
            DependencyProperty.Register("MyProperty",
                typeof(int),
                typeof(UIElement),
                new PropertyMetadata(0));
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace StylesManagment.Selectors
{
    internal class GradeStyleSelector : StyleSelector
    {
        public Style GoodStyle { get; set; }

        public Style BadStyle { get; set; }

        public override Style SelectStyle(object item, DependencyObject container)
        {
            int countItem = (int)item;

            return countItem > 80 ? GoodStyle : BadStyle;
        }
    }
}

using LotoDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace LotoDemo.Selectors
{
    internal class CellSelector  : StyleSelector
    {
        public Style BadStyle { get; set; }

        public Style GoodStyle { get; set; }

        public Style EmptyStyle { get; set; }

        public ILottoChecker Checker { get; set; }

        public override Style SelectStyle(object item, DependencyObject container)
        {
            int itemNumber = (int)item;

            switch(Checker.IsRightNumber(itemNumber))
            {
                case eCellStatus.Good: 
                    return GoodStyle;

                case eCellStatus.Bad:
                    return BadStyle;

                case eCellStatus.Empty:
                    return EmptyStyle;
            }

            return EmptyStyle;
        }
    }
}

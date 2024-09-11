using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Automation.Text;

namespace LotoDemo.Models
{
    internal enum eCellStatus
    {
        Empty = 0,
        Good = 1,
        Bad = 2
    }

    internal interface ILottoChecker
    {
        eCellStatus IsRightNumber(int number);
    }
}

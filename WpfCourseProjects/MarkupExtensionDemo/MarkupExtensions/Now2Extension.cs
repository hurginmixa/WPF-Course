using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace MarkupExtensionDemo.MarkupExtensions
{
    internal class Now2Extension : MarkupExtension
    {
        public int DayExtra { get; set; } = 0;

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return DateTime.Now.AddDays(DayExtra).ToString("yyyy-MM-dd HH:mm");
        }
    }
}

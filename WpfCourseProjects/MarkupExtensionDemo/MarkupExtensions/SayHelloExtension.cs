using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace MarkupExtensionDemo.MarkupExtensions
{
    internal class SayHelloExtension : MarkupExtension
    {
        private readonly string _name;

        public SayHelloExtension(string name)
        {
            _name = name;
        }

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return $"Hello {_name}";
        }
    }
}

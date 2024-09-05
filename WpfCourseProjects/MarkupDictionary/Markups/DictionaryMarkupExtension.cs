using System.Windows.Markup;

namespace MarkupDictionary.Markups
{
    public class DictionaryMarkupExtension : MarkupExtension
    {
        private static readonly Dictionary<string, string> Eng2Rus = new Dictionary<string, string>()
        {
            { "Chair", "Стул" },
            { "Table", "Стол" }
        };

        private static readonly Dictionary<string, string> Eng2Hebr = new Dictionary<string, string>()
        {
            { "Chair", "כיסא" },
            { "Table", "שולחן" }
        };

        public enum eDictionayDirect
        {
            Russian, Hebrew
        }

        private readonly Dictionary<string, string> _dictionary;

        public DictionaryMarkupExtension(eDictionayDirect dictionaryDirectDirect)
        {
            _dictionary = (dictionaryDirectDirect == eDictionayDirect.Hebrew) ? Eng2Hebr : Eng2Rus;
        }

        public string Key { get; set; } = "";

        public override object? ProvideValue(IServiceProvider serviceProvider)
        {
            return _dictionary.GetValueOrDefault(Key, defaultValue: "Not found");
        }
    }
}

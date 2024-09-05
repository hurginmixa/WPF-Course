using System.Windows.Markup;

namespace MarkupDictionary.Markups
{
    public enum eDictionaryDirect
    {
        Russian, Hebrew
    }

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

        public eDictionaryDirect Direct { get; set; } = eDictionaryDirect.Hebrew;

        public string Key { get; set; } = "";

        public override object? ProvideValue(IServiceProvider serviceProvider)
        {
            var _dictionary = (Direct == eDictionaryDirect.Hebrew) ? Eng2Hebr : Eng2Rus;

            return _dictionary.GetValueOrDefault(Key, defaultValue: "Not found");
        }
    }
}

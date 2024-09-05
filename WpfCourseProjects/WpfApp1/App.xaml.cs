using System.Configuration;
using System.Data;
using System.Windows;
using System.Xml;
using System.Xml.Linq;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            
        }

        class Word
        {
            public Word(string key, string value)
            {
                Key = key;
                Value = value;
            }

            public string Key { get; }

            public string Value { get; }
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            XDocument document = XDocument.Load(@"Data\XMLFile1.xml");

#pragma warning disable CS8602 // Dereference of a possibly null reference.
            foreach (Word word in document.Descendants("Word").Select(w => new Word(w.Element("Key").Value, w.Element("Value").Value)))
#pragma warning restore CS8602 // Dereference of a possibly null reference.
            {
                
            }
        }
    }

}

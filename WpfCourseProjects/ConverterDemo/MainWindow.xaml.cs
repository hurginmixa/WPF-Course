using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ConverterDemo.Models;

namespace ConverterDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private BaseStock _stock;

        public MainWindow()
        {
            InitializeComponent();

            Loaded += (s, e) =>
            {
                _stock = new BaseStock
                {
                    Value = 10,
                    Symbol = "MFS"
                };

                DataContext = _stock;
            };
        }
    }
}
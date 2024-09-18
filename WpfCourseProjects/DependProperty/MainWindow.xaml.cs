using DependProperty.Models;
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

namespace DependProperty
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonBase1_OnClick(object sender, RoutedEventArgs e)
        {
            StockCalculator? r = (StockCalculator)Panel.Resources["StockCalculator1"];

            int v = r.MyProperty;
            r.MyProperty = v + 1;
        }

        private void ButtonBase2_OnClick(object sender, RoutedEventArgs e)
        {
            StockUpdater? r = (StockUpdater)Panel.Resources["StockCalculator2"];

            double v = r.Sum;
            r.Sum = v + 1;
        }
    }
}
using System.Diagnostics;
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

namespace Events
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            grid.MouseLeftButtonDown += OnMouseLeftButtonDown;
            border.MouseLeftButtonDown += OnMouseLeftButtonDown;
            sp.MouseLeftButtonDown += OnMouseLeftButtonDown;
            el.MouseLeftButtonDown += OnMouseLeftButtonDown;

            grid.MouseEnter += OnMouseEnter;
            border.MouseEnter += OnMouseEnter;
            sp.MouseEnter += OnMouseEnter;
            el.MouseEnter += OnMouseEnter;
        }

        private void OnMouseEnter(object sender, MouseEventArgs e)
        {
            Debug.WriteLine($"MouseEnter {sender.ToString()}");
        }

        private void OnMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Debug.WriteLine($"MouseLeftButtonDown {sender.ToString()}");
        }
    }
}
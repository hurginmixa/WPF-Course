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

namespace CanvasDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            this.Loaded += (s, e) =>
            {
                Canvas canvas = new Canvas();   
                canvas.Width = 300;
                canvas.Height = 300;
                canvas.Background = new SolidColorBrush(color: Colors.Yellow);

                Ellipse ellipse = new Ellipse();
                ellipse.Fill = new SolidColorBrush(Colors.Red);
                ellipse.Width = 50;
                ellipse.Height = 150;

                canvas.Children.Add(ellipse);

                Canvas.SetTop(ellipse, 20);
                Canvas.SetLeft(ellipse, 20);

                this.MainGrid.Children.Add(canvas);
            };
        }
    }
}
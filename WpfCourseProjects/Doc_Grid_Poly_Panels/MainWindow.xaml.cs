using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Doc_Grid_Poly_Panels
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Loaded += MainWindow_Loaded;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            Grid grid = new Grid();

            grid.ShowGridLines = true;

            grid.ColumnDefinitions.Add(new ColumnDefinition
            {
                Width = new GridLength(1, GridUnitType.Star)
            });

            grid.ColumnDefinitions.Add(new ColumnDefinition
            {
                Width = new GridLength(2, GridUnitType.Star)
            });

            grid.ColumnDefinitions.Add(new ColumnDefinition
            {
                Width = new GridLength(3, GridUnitType.Star)
            });

            grid.RowDefinitions.Add(new RowDefinition()
            {
                Height = new GridLength(1, GridUnitType.Star)
            });

            grid.RowDefinitions.Add(new RowDefinition()
            {
                Height = new GridLength(2, GridUnitType.Star)
            });

            grid.RowDefinitions.Add(new RowDefinition()
            {
                Height = new GridLength(3, GridUnitType.Star)
            });

            OuterDocPanel.Children.Add(grid);


            UniformGrid uniformGrid = new UniformGrid();
            uniformGrid.Columns = 5;

            Grid.SetColumn(uniformGrid, 1);
            Grid.SetRow(uniformGrid, 1);
            grid.Children.Add(uniformGrid);


            for (int i = 0; i < 10; i++)
            {
                Ellipse ellipse = new Ellipse
                {
                    Width = 50,
                    Height = 50,
                    Fill = new SolidColorBrush(i % 2 == 0 ? Colors.Blue : Colors.Red)
                };

                uniformGrid.Children.Add(ellipse);
            }
        }
    }
}
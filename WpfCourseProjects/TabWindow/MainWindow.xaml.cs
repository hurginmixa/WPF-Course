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
using TabWindow.Models;

namespace TabWindow
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            DataContext = new GlobalModel();
        }

        private void AddTab_Click(object sender, RoutedEventArgs e)
        {
            TabItem1 tabItem1 = new TabItem1();
            tabItem1.DataContext = ((GlobalModel) DataContext).AddModel();

            TabItem newTab = new TabItem();
            newTab.Header = "Mixa";
            newTab.Content = tabItem1;
            DynamicTabControl.Items.Add(newTab);

            DynamicTabControl.SelectedItem = newTab;
        }
    }
}
using System.Windows;
using MarkupDictionary.ViewModels;

namespace MarkupDictionary
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            Content = new ViewModel();

            InitializeComponent();
        }
    }
}
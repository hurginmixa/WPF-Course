using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace BindingDemo
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();

            this.Loaded += Window1_Loaded;
        }

        private User _user;

        private void Window1_Loaded(object sender, RoutedEventArgs e)
        {
            _user = new User()
            {
                Id = 1,
                FirstName = "Mixa1",
                LastName = "Mixa2"
            };

            DataContext = _user;
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            _user.LastName += "1";
        }
    }
}

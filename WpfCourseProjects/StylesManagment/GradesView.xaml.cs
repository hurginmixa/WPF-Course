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

namespace StylesManagment
{
    /// <summary>
    /// Interaction logic for GradesView.xaml
    /// </summary>
    public partial class GradesView : Window
    {
        public GradesView()
        {
            InitializeComponent();

            int[] grdes = new int[] { 10, 100, 85, 78, 95};

            Box.ItemsSource = grdes;
        }
    }
}

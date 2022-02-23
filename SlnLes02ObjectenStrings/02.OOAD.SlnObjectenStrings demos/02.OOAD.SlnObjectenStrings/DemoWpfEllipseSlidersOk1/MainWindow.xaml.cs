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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DemoWpfEllipseSlidersOk1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            sldWidth.Value = 100;
            sldHeight.Value = 50;
        }
        private void Update()
        {
            ellipse1.Width = sldWidth.Value;
            ellipse1.Height = sldHeight.Value;
            lblWidth.Content = Convert.ToString(Convert.ToInt32(sldWidth.Value));
            lblHeight.Content = Convert.ToString(Convert.ToInt32(sldHeight.Value));
        }

        private void sldVertical_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Update();
        }

        private void sldHorizontal_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Update();
        }
    }
}

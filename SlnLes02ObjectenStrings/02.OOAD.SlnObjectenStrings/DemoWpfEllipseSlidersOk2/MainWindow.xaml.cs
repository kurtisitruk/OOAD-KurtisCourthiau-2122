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

namespace DemoWpfEllipseSlidersOk2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Ellipse ellipse1;

        public MainWindow()
        {
            InitializeComponent();

            // init ellipse
            ellipse1 = new Ellipse();
            ellipse1.Stroke = new SolidColorBrush(Colors.Blue);
            ellipse1.Fill = new SolidColorBrush(Colors.LightBlue);
            ellipse1.Margin = new Thickness(0, 0, 0, 0);
            canvas1.Children.Add(ellipse1);

            // init sliders
            sldWidth.Minimum = 0;
            sldWidth.Maximum = canvas1.Width;
            sldWidth.Value = 100;
            sldHeight.Minimum = 0;
            sldHeight.Maximum = canvas1.Height;
            sldHeight.Value = 50;

            // set labels
            lblWidth.Content = Convert.ToString(Convert.ToInt32(sldWidth.Value));
            lblHeight.Content = Convert.ToString(Convert.ToInt32(sldHeight.Value));
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

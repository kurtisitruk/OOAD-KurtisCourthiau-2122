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

namespace DemoWpfEllipsSliders
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Ellipse ellipse;

        public MainWindow()
        {
            InitializeComponent();

            // init sliders
            sldWidth.Minimum = 0;
            sldWidth.Maximum = canvas.Width;
            sldHeight.Minimum = 0;
            sldHeight.Maximum = canvas.Height;

            // init ellipse
            ellipse = new Ellipse();
            ellipse.Stroke = new SolidColorBrush(Colors.Orange);
            ellipse.Fill = new SolidColorBrush(Colors.Black);
            ellipse.Margin = new Thickness(0, 0, 0, 0);
            canvas.Children.Add(ellipse);

            // set initial slider values
            sldWidth.Value = 100;
            sldHeight.Value = 50;
            Update(); // this is actually not required - why?
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

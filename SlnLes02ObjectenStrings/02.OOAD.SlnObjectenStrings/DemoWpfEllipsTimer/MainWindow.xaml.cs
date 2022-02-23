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
using System.Windows.Threading;

namespace DemoWpfEllipsTimer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer timer;
        Random rnd;
        public MainWindow()
        {
            InitializeComponent();
            ellips1.Width = sldHor.Value;
            sldHor.Maximum = canvas1.Width;
            rnd = new Random();
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromMilliseconds(100);
            timer.Tick += AddTick;
        }

        private void AddTick(object sender, EventArgs e)
        {
            sldHor.Value += rnd.Next(1, 5);
        }

        private void SldHor_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            ellips1.Width = sldHor.Value;
        }

        private void BtnStart_Click(object sender, RoutedEventArgs e)
        {
            timer.Start();
        }
    }
}

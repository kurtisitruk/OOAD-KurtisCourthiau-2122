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

namespace DemoWpfRaden
{
    public partial class MainWindow : Window
    {
        int getal;
        int pogingenOver = 3;

        public MainWindow()
        {
            InitializeComponent();
            Random rnd = new Random();
            getal = rnd.Next(1, 6);
        }

        private void btnCheck_Click(object sender, RoutedEventArgs e)
        {
            pogingenOver--;
            int gok = Convert.ToInt32(txtGok.Text);
            if (gok == getal)
            {
                lblPogingen.Content = "Gewonnen!";
                btnCheck.IsEnabled = false;
            }
            else
            {
                lblPogingen.Content = $"Fout! Je hebt nog {pogingenOver} pogingen over";
                if (pogingenOver == 0)
                {
                    btnCheck.IsEnabled = false;
                }
            }
        }

    }
}

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

namespace CarRent
{
    /// <summary>
    /// Interaction logic for wdwLogin.xaml
    /// </summary>
    public partial class wdwLogin : Window
    {
        public wdwLogin()
        {
            InitializeComponent();
        }

        private void btnBelepes_Click(object sender, RoutedEventArgs e)
        {
            wdwRentals rentals = new wdwRentals();  
            this.Hide();
            rentals.Show();

        }

        private void btnKilepes_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(1);
        }
    }
}

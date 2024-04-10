using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
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
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;  

namespace CarRent
{
    /// <summary>
    /// Interaction logic for wdwLogin.xaml
    /// </summary>
    public partial class wdwLogin : Window
    {
        wdwRentals rentals = new wdwRentals();
        public wdwLogin()
        {
            InitializeComponent();
        }

        private async void btnBelepes_Click(object sender, RoutedEventArgs e)
        {
            if(txtFelhasznalonev.Text != "" && txtJelszo.Text != "")
            {                           
                var userName = txtFelhasznalonev.Text;
                var id = 0;
                var httpClient = new HttpClient();
                try
                {
                    var response = await httpClient.GetAsync($"http://localhost:5230/autorent/api/GetUser?id={id}");
                    if (response.IsSuccessStatusCode)
                    {
                        var json = await response.Content.ReadAsStringAsync();
                        var user = JsonConvert.DeserializeObject<dynamic>(json);
                        MessageBox.Show( $"Username: {user.Username}, Password: {user.Password}");
                        this.Hide();
                        rentals.Show();
                    }else if(response.StatusCode == System.Net.HttpStatusCode.NotFound)
                    {
                        MessageBox.Show("A felhasználó nem található!");
                        // amikor a felhasználó nem található
                    }
                    else
                    {
                        MessageBox.Show( "Nem sikerült lekérdezni a felhasználót.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Hiba történt: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Jelszót és a felhasználónév kitöltése kötelező!!");
                return;
            }
        }

        private void btnKilepes_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(1);
        }
    }
}

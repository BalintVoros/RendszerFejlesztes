
﻿using System;
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
using System.Net.Http;
using System.Collections.Generic;
using Newtonsoft.Json;


namespace CarRent
{
    /// <summary>
    /// Interaction logic for wdwRentals.xaml
    /// </summary>
    public partial class wdwRentals : Window
    {
        public wdwRentals()
        {
            InitializeComponent();
           // loadWindow();
        }


       /* public void loadWindow()
        {
            try
            {
                var products = await GetProductsAsync();
                dgElerhetoAutok.ItemsSource = products;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hiba történt az adatok betöltése közben: {ex.Message}");
            }

        }
        public async Task<List<Auto>> GetProductsAsync()
        {
            var httpClient = new HttpClient();
            var response = await httpClient.GetAsync("http://yourapiaddress/api/products");
            var json = await response.Content.ReadAsStringAsync();
            var products = JsonConvert.DeserializeObject<List<Auto>>(json);
            return products;
        }*/
    }
}
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Newtonsoft.Json;
using SpotifyAPI.Web.Models;
using SpotifyAPI.Web.Enums;


namespace GroupProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ComboBoxItem_Selected(object sender, RoutedEventArgs e)
        {

          
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            
        }

        private void btnSelect_Click(object sender, RoutedEventArgs e)
        {

            string selection;

            selection = comboCategory.Text;

            using (HttpClient client = new HttpClient())
            {


                if (selection == "Artist")
                {

                    var response = client.GetAsync($"https://api.spotify.com/v1/artists/{txtboxDetails.Text}/top-tracks").Result;
                    if (!response.IsSuccessStatusCode)
                    {
                        txtboxDetails.Clear();
                        MessageBox.Show("You done FUCKED up.");
                    }
                    else if (response.IsSuccessStatusCode)
                    {
                        var song = response.Content.ReadAsStringAsync().Result;
                        FullArtist a = JsonConvert.DeserializeObject<FullArtist>();

                    }
                }

            }
        }

        private void Grid_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }
    }
}

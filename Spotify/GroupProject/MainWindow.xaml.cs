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
using SpotifyAPI.Web;
using SpotifyAPI.Web.Auth;
using SpotifyAPI.Web.Models;
using SpotifyAPI.Web.Enums;


namespace GroupProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 

    

    public partial class MainWindow : Window
    {
        //private static SpotifyWebAPI _spotify;
        public MainWindow()
        {
            InitializeComponent();
            //_spotify = new SpotifyWebAPI()
            //{
            //    UseAuth = false,
            //};
            //FullTrack track = _spotify.GetTrack("da3e0a9c9ef44b03b0867f5fcef7c155");
            //Console.WriteLine(track.Name);

            ImplicitGrantAuth auth = new ImplicitGrantAuth("da3e0a9c9ef44b03b0867f5fcef7c155", "http://localhost:4002", "http://localhost:4002", Scope.UserReadPrivate);
            auth.AuthReceived += (sender, playload) =>
            {
                auth.Stop();
                SpotifyWebAPI api = new SpotifyWebAPI() { TokenType = playload.TokenType, AccessToken = playload.AccessToken };

            };

            auth.Start();
            auth.OpenBrowser();

            //CredentialsAuth auth = new CredentialsAuth("da3e0a9c9ef44b03b0867f5fcef7c155", "8cf189c167384e71abda96d728bf305f");
            //Token token = await auth.GetToken();
            //SpotifyWebAPI api = new SpotifyWebAPI() { TokenType = token.TokenType, AccessToken = token.AccessToken };


            //TokenSwapWebAPIFactory webAPIFactory;
            //SpotifyWebAPI spotify;

            //webAPIFactory = new TokenSwapWebAPIFactory("INSERT LINK TO YOUR index.php HERE")
            //{
            //    Scope = Scope.UserReadPrivate | Scope.UserReadEmail | Scope.PlaylistModifyPrivate,
            //    AutoRefresh = true

            //};

            //try
            //{
            //    spotify = webAPIFactory.GetWebApiAsync().Result;
            //}
            //catch (Exception ex)
            //{

            //}
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

            //string selection;

            //selection = comboCategory.Text;

            //using (HttpClient client = new HttpClient())
            //{


            //    if (selection == "Artist")
            //    {

            //        var response = client.GetAsync($"https://api.spotify.com/v1/artists/{txtboxDetails.Text}/top-tracks").Result;
            //        if (!response.IsSuccessStatusCode)
            //        {
            //            txtboxDetails.Clear();
            //            MessageBox.Show("You done FUCKED up.");
            //        }
            //        else if (response.IsSuccessStatusCode)
            //        {
            //            var song = response.Content.ReadAsStringAsync().Result;
            //            FullArtist a = JsonConvert.DeserializeObject<FullArtist>();

            //        }
            //    }

            //}
        }

        private void Grid_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }
    }
}

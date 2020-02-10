using Newtonsoft.Json;
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

namespace JSON_RickAndMorty
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            string dataSetUrl = "https://rickandmortyapi.com/api/character/";
            RickAndMortyAPI rickAndMortyStuff;
            using (var client = new HttpClient())
            {
                //client.BaseAddress = new Uri(dataSetUrl);
                string json = client.GetStringAsync(dataSetUrl).Result;


                rickAndMortyStuff = JsonConvert.DeserializeObject<RickAndMortyAPI>(json);
                
            }

            foreach (var character in rickAndMortyStuff.results)
            {
                lstCharacters.Items.Add(character);
            }

        }

        private void LstCharacters_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            var selectedCharacterFromList = (ResultObject) lstCharacters.SelectedItem;

            //imgCharacter.Source = new BitmapImage(new Uri("https://rickandmortyapi.com/api/character/avatar/1.jpeg"));
            imgCharacter.Source = new BitmapImage(new Uri(selectedCharacterFromList.image));

        }
    }

    
}

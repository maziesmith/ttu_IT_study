using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using kodutöö_12.Model;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Windows.UI.Xaml.Media.Imaging;

namespace kodutöö_12 {
    public sealed partial class MainPage : Page {
        private const int CharactersCount = 10;

        public ObservableCollection<Character> MarvelCharacters { get; set; }
        public ObservableCollection<ComicBook> MarvelComics { get; set; }

        public MainPage() {
            this.InitializeComponent();
            InitializeMarvelData();
        }

        private void InitializeMarvelData() {
            MarvelCharacters = new ObservableCollection<Character>();
            MarvelComics = new ObservableCollection<ComicBook>();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e) {
            Refresh();
        }

        private void EnableProgressbar() {
            MyProgressRing.IsActive = true;
            MyProgressRing.Visibility = Visibility.Visible;
        }

        private void DisableProgressbar() {
            MyProgressRing.IsActive = false;
            MyProgressRing.Visibility = Visibility.Collapsed;
        }

        public async void Refresh () {
            EnableProgressbar();

            MarvelCharacters.Clear();

            while (MarvelCharacters.Count < CharactersCount) {
                Task t = MarvelFacade.PopulateMarvelCharactersAsync(MarvelCharacters);
                await t;
            }

            DisableProgressbar();
        }

        private async void MasterListView_ItemClick(object sender, ItemClickEventArgs e) {
            EnableProgressbar();

            ComicDetailNameTextBlock.Text = "";
            ComicDetailDescriptionTextBlock.Text = "";
            ComicDetailImage.Source = null;

            Character selectedCharacter = (Character)e.ClickedItem;

            DetailNameTextBlock.Text = selectedCharacter.name;
            DetailDescriptionTextBlock.Text = selectedCharacter.description;

            BitmapImage largeImage = new BitmapImage();
            Uri uri = new Uri(selectedCharacter.thumbnail.large, UriKind.Absolute);
            largeImage.UriSource = uri;
            DetailImage.Source = largeImage;

            MarvelComics.Clear();

            await MarvelFacade.PopulateMarvelComicsAsync(selectedCharacter.id, MarvelComics);

            DisableProgressbar();
        }

        private void ComicsGridView_ItemClick(object sender, ItemClickEventArgs e) {
            var selectedComic = (ComicBook)e.ClickedItem;

            ComicDetailNameTextBlock.Text = selectedComic.title;

            if (selectedComic.description != null) {
                ComicDetailDescriptionTextBlock.Text = selectedComic.description;
            }

            BitmapImage largeImage = new BitmapImage();
            Uri uri = new Uri(selectedComic.thumbnail.large, UriKind.Absolute);
            largeImage.UriSource = uri;
            ComicDetailImage.Source = largeImage;
        }
    }
}

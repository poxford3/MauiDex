using MauiDex.Model;
using MauiDex.Services;
using MauiDex.ViewModels;
using Microsoft.Maui.Controls.Platform.Compatibility;

namespace MauiDex
{
    public partial class MainPage : ContentPage
    {
        public MainViewModel MainViewModel { get; }

        public MainPage(MainViewModel mainViewModel)
        {
            InitializeComponent();
            BindingContext = MainViewModel = mainViewModel;
            MainViewModel = mainViewModel;
            // StartTest();
        }

        //private async void StartTest()
        //{
        //    if (Application.Current != null)
        //    {
        //        PokeAPICall pokeAPICall = await MainViewModel.LoadDataAsync();
        //        PokeAPICall PLI_Main = pokeAPICall;
        //    }
        //}

        private async void FavoriteClick(object sender, EventArgs e)
        {
            Console.WriteLine("OnStart");
            System.Diagnostics.Debug.WriteLine("onstart sys");

            if (Application.Current != null)
            {
                await MainViewModel.LoadDataAsync();
            }
        }

        private void SettingsClick(object sender, EventArgs e)
        {
            if (Application.Current != null)
            {
                Console.WriteLine("CONSOLE");
                System.Diagnostics.Debug.WriteLine("CONSOLE SYSTEM");
            }
        }

        //protected override async void onNavigatedTo

        private void OnSearchChange(object sender, EventArgs e)
        {
            SearchBar searchbar = (SearchBar)sender;
            Console.WriteLine(e);
            //PokeList.ItemsSource = DataService.GetSearchResults(searchbar.Text);
        }
    }

}

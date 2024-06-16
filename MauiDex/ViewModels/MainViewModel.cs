using CommunityToolkit.Mvvm.ComponentModel;
using MauiDex.Model;
using MauiDex.Services;
using System.Collections.ObjectModel;
using System.Security.Cryptography.X509Certificates;

namespace MauiDex.ViewModels
{
    public partial class MainViewModel : BaseViewModel
    {
        private readonly PokeAPICall _pokeAPICall;

        public MainViewModel(PokeAPICall pokeAPICall)
        {
            _pokeAPICall = pokeAPICall;
        }

        //[ObservableProperty]
        //ObservableCollection<PokeListItem> pokeListItems;
        PokeListItem PLI {  get; set; }


        public async Task<PokeAPICall> LoadDataAsync()
        {
            PokeAPICall pokeAPICall = new PokeAPICall();
            await pokeAPICall.GetPokemonByGenAsync(1);
            return pokeAPICall;
        }

    }
}

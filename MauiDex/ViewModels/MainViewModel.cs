using MauiDex.Model;
using MauiDex.Services;

namespace MauiDex.ViewModels
{
    public partial class MainViewModel : BaseViewModel
    {
        private readonly IPokeAPICall _pokeAPICall;

        public MainViewModel(IPokeAPICall pokeAPICall)
        {
            _pokeAPICall = pokeAPICall;
        }

        //[ObservableProperty]
        //ObservableCollection<PokeListItem> pokeListItems;
        PokeListItem PLI {  get; set; }


        public async Task<PokeAPICall> LoadDataAsync()
        {
            PokeAPICall pokeAPICall = new();
            PLI = await pokeAPICall.GetPokemonByGenAsync(1);
            return pokeAPICall;
        }

    }
}

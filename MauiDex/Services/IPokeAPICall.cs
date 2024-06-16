using MauiDex.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiDex.Services
{
    public interface IPokeAPICall
    {
        Task<PokeListItem> GetPokemonByGenAsync(int Gen);

        Task<PokeListItem> GetPokemonByIdAsync(int Id);
    }
}

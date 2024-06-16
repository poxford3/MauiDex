using CommunityToolkit.Mvvm.ComponentModel;
using System.Text.Json.Serialization;
using System.Xml.Linq;

namespace MauiDex.Model
{
    public class PokemonSpecy
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("url")]
        public Uri Url { get; set; }
    }

    public class PokeListItem
    {
        [JsonPropertyName("pokemon_species")] 
        public List<PokemonSpecy> PokemonSpecies { get; set; }
    }
}

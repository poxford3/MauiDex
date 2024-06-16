using MauiDex.Model;
using System.Diagnostics;
using System.Text.Json;

namespace MauiDex.Services
{
    public class PokeAPICall : IPokeAPICall
    {
        //private readonly HttpClient httpClient;
        HttpClient _httpClient;
        JsonSerializerOptions _serializerOptions;

        public PokeListItem PLI { get; private set; }

        public PokeAPICall() // (HttpClient httpClient) // old
        {
            //this.httpClient = httpClient;
            _httpClient = new HttpClient();
            _serializerOptions = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                WriteIndented = true
            };
        }

        public async Task<PokeListItem> GetPokemonByGenAsync(int Gen)
        {
            PLI = new PokeListItem();

            Uri url = new($"https://pokeapi.co/api/v2/generation/{Gen}");

            try
            {
                HttpResponseMessage response = await _httpClient.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();
                    PLI = JsonSerializer.Deserialize<PokeListItem>(content, _serializerOptions);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(@"\tERROR {0}", ex.Message);
            }

            System.Diagnostics.Debug.WriteLine("gen async " + PLI.ToString());

            return PLI;
        }

        public async Task<PokeListItem> GetPokemonByIdAsync(int Id)
        {
            PLI = new PokeListItem();

            Uri url = new($"https://pokeapi.co/api/v2/pokemon/{Id}");

            try
            {
                HttpResponseMessage response = await _httpClient.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();
                    PLI = JsonSerializer.Deserialize<PokeListItem>(content, _serializerOptions);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(@"\tERROR {0}", ex.Message);
            }

            return PLI;
        }
    }
}

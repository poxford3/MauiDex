using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MauiDex.Models.Other;

namespace MauiDex.Models
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class Ability
    {
        public Ability ability { get; set; }
        public bool is_hidden { get; set; }
        public int slot { get; set; }
    }

    public class Ability2
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class Animated
    {
        public string back_default { get; set; }
        public object back_female { get; set; }
        public string back_shiny { get; set; }
        public object back_shiny_female { get; set; }
        public string front_default { get; set; }
        public object front_female { get; set; }
        public string front_shiny { get; set; }
        public object front_shiny_female { get; set; }
    }

    public class Cries
    {
        public string latest { get; set; }
        public string legacy { get; set; }
    }

    public class Form
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class GameIndex
    {
        public int game_index { get; set; }
        public Version version { get; set; }
    }

    public class Icons
    {
        public string front_default { get; set; }
        public object front_female { get; set; }
    }

    public class Move2
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class MoveLearnMethod
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class OfficialArtwork
    {
        public string front_default { get; set; }
        public string front_shiny { get; set; }
    }

    public class Other
    {
        [JsonProperty("official-artwork")]
        public OfficialArtwork officialartwork
        {
            get; set;
        }


        public class Pokemon
        {
            public List<Ability> abilities { get; set; }
            public int base_experience { get; set; }
            public Cries cries { get; set; }
            public List<Form> forms { get; set; }
            public List<GameIndex> game_indices { get; set; }
            public int height { get; set; }
            public List<object> held_items { get; set; }
            public int id { get; set; }
            public bool is_default { get; set; }
            public string location_area_encounters { get; set; }
            public string name { get; set; }
            public int order { get; set; }
            public List<object> past_abilities { get; set; }
            public List<object> past_types { get; set; }
            public Species species { get; set; }
            public Sprites sprites { get; set; }
            public List<Stat> stats { get; set; }
            public List<Type> types { get; set; }
            public int weight { get; set; }
        }

        public class Species
        {
            public string name { get; set; }
            public string url { get; set; }
        }

        public class Sprites
        {
            public string back_default { get; set; }
            public object back_female { get; set; }
            public string back_shiny { get; set; }
            public object back_shiny_female { get; set; }
            public string front_default { get; set; }
            public object front_female { get; set; }
            public string front_shiny { get; set; }
            public object front_shiny_female { get; set; }
            public Other other { get; set; }
        }

        public class Stat
        {
            public int base_stat { get; set; }
            public int effort { get; set; }
            public Stat stat { get; set; }
        }

        public class Stat2
        {
            public string name { get; set; }
            public string url { get; set; }
        }

        public class Type
        {
            public int slot { get; set; }
            public Type type { get; set; }
        }

        public class Type2
        {
            public string name { get; set; }
            public string url { get; set; }
        }

    }
}

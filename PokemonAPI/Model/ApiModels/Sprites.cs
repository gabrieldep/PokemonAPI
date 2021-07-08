using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PokemonAPI.Model.ApiModels
{
    public class Sprites
    {
        [JsonProperty("front_default")]
        public Uri FrontDefault { get; set; }
    }
}

using PokemonAPI.Model.ApiModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PokemonAPI.Model
{
    public class PokemonDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Uri Image { get; set; }
        public IEnumerable<string> Types { get; set; }
    }
}

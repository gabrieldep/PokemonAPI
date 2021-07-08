using HttpRequestHelper.Control;
using Newtonsoft.Json;
using PokemonAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace PokemonAPI.Comunication
{
    public class Pokeapi
    {
        public static async Task<Pokemon> GetDataAsync(int id) => await RequestControl.GetAsync<Pokemon>("https://pokeapi.co/api/v2/pokemon/" + id);
    }
}

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
        public static async Task<Pokemon> GetDataAsync(int id)
        {
            HttpClient client = new HttpClient
            {
                BaseAddress = new Uri("https://pokeapi.co/api/v2/pokemon/")
            };

            using HttpResponseMessage response = await client.GetAsync(id.ToString());
            var s = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
            return response.IsSuccessStatusCode ?
                JsonConvert.DeserializeObject<Pokemon>(response.Content.ReadAsStringAsync().GetAwaiter().GetResult())
                    : null;
        }
    }
}

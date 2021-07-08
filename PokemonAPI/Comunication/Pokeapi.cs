using HttpRequestHelper.Control;
using Newtonsoft.Json;
using PokemonAPI.Model;
using PokemonAPI.Model.ApiModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace PokemonAPI.Comunication
{
    public class Pokeapi
    {
        /// <summary>
        /// Faz uma requisição e monta um pokemon
        /// </summary>
        /// <returns>Objeto Pokemon.</returns>
        /// <param name="id">Pokemon id.</param>
        public static async Task<Pokemon> GetPokemonDataByIdAsync(int id) => await RequestControl.GetAsync<Pokemon>("https://pokeapi.co/api/v2/pokemon/" + id);

        /// <summary>
        /// Faz uma requisição e monta um pokemon
        /// </summary>
        /// <returns>Objeto Pokemon.</returns>
        /// <param name="name">Pokemon name.</param>
        public static async Task<Pokemon> GetPokemonDataByNameAsync(string name) => await RequestControl.GetAsync<Pokemon>("https://pokeapi.co/api/v2/pokemon/" + name);
    }
}

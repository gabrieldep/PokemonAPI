using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using PokemonAPI.Comunication;
using PokemonAPI.Model;
using PokemonAPI.Model.ApiModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace PokemonAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PokemonAPI : ControllerBase
    {
        /// <summary>
        /// Faz uma requisição e monta um pokemon
        /// </summary>
        /// <returns>IAction result com o Pokemon caso dê certo.</returns>
        /// <param name="name">Pokemon name.</param>
        /// <param name="id">Pokemon id.</param>
        [HttpGet("GetPokemon")]
        public async Task<IActionResult> GetPokemon(int? id, string name)
        {
            Pokemon pokemon;
            if (id != null)
            {
                pokemon = await Pokeapi.GetPokemonDataByIdAsync(id.Value);
            }
            else if (!string.IsNullOrEmpty(name))
            {
                pokemon = await Pokeapi.GetPokemonDataByNameAsync(name);
            }
            else
            {
                return StatusCode((int)HttpStatusCode.NoContent);
            }
            PokemonDTO dto = new PokemonDTO
            {
                Id = pokemon.Id,
                Image = pokemon.Sprites.FrontDefault,
                Name = pokemon.Name,
                Types = pokemon.Types.Select(t => t.Type.Name)
            };
            return StatusCode((int)HttpStatusCode.OK, dto);
        }
    }
}

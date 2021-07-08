using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using PokemonAPI.Comunication;
using PokemonAPI.Model;
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
        [HttpGet("GetPokemon")]
        public async Task<IActionResult> GetPokemon(int id)
        {
            Pokemon pokemon = await Pokeapi.GetDataAsync(id);
            return StatusCode((int)HttpStatusCode.OK, pokemon);
        }
    }
}

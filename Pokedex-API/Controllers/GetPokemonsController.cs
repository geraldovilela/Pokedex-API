using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Pokedex_API.Context.Entities;
using Pokedex_API.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pokedex_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GetPokemonsController : ControllerBase
    {
        private PokemonSeed _pokemonseed;

        public GetPokemonsController(PokemonSeed pokemonSeed)
        {
            _pokemonseed = pokemonSeed;
        }
        [HttpGet]
        public async Task<List<Pokemon>> GetList()
        {
            
            var response = await _pokemonseed.GetPokemonData();
            return response;
        }   
     }
}

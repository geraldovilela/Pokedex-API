using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using RestEase;


namespace Pokedex_API.Services
{
    public class PokemonSeed
    {
        public PokemonSeed()
        {
            
        }

        public void GetPokemonData()
        {
            string baseURL = "https://pokeapi.co/api/v2/pokemon";
            //var _client = RestClient.For<Pokemon>(baseURL);
        }
    }
}

using PokeApiNet;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pokedex_API.Services
{
    public class PokemonSeed
    {
        public PokemonSeed()
        {

        }

        public async Task<List<Context.Entities.Pokemon>> GetPokemonData()
        {
            List<Context.Entities.Pokemon> pokemons = new List<Context.Entities.Pokemon>();
            for (int i = 1; i <= 12; i++)
            {
                PokeApiClient client = new PokeApiClient();

                PokeApiNet.Pokemon p = await client.GetResourceAsync<PokeApiNet.Pokemon>(i);

                var newP = new Context.Entities.Pokemon()
                {
                    Id = p.Id,
                    Name = p.Name,
                    Height = p.Height,
                    Weight = p.Weight,
                    BaseExperience = p.BaseExperience,
                    Order = p.Order,
                    FrontMale = p.Sprites.FrontDefault,
                    BackMale = p.Sprites.BackDefault,
                    IsDefault = p.IsDefault,

                };

                pokemons.Add(newP);
            }
            return pokemons;
        }
    }
}

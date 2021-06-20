using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pokedex_API.Context.Entities
{
    public class PokemonStats : BaseClass
    {

        public Pokemon Pokemon { get; set; }
        public int Base_stat { get; set; }
        public int Effort { get; set; }

    }
}

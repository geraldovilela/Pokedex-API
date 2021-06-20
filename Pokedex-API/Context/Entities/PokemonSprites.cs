using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Pokedex_API.Context.Entities
{
    public class PokemonSprites : BaseClass
    {
        [Required]
        public Pokemon Pokemon { get; set; }
        [Required]
        public string UrlSprite { get; set; }
        [Required]
        public int Weight { get; set; }
    }
}

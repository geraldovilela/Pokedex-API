
using System.ComponentModel.DataAnnotations;

namespace Pokedex_API.Context.Entities
{
    public class Pokemon : BaseClass
    {
        [Required]
        public string Name { get; set; }        
        [Required]
        public int PokemonId { get; set; }
    }
}
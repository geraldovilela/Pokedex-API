using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Pokedex_API.Context.Entities
{
    public class BaseClass
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public DateTime Created_at { get; set; }        
        [Timestamp]
        public DateTime Updated_at { get; set; }

    }
}

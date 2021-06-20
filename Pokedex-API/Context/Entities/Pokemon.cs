using System;
using System.ComponentModel.DataAnnotations;


namespace Pokedex_API.Context.Entities
{
    public class Pokemon
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int BaseExperience { get; set; }
        public bool IsDefault { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }
        public int Order { get; set; }
        public string BackMale { get; set; }
        public string FrontMale { get; set; }
        public DateTime Created_at { get; set; }
        [Timestamp]
        public byte[] Updated_at { get; set; }
    }
}
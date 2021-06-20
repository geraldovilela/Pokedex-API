using Microsoft.EntityFrameworkCore;
using Pokedex_API.Context.Entities;
using Pokedex_API.Services;

namespace Pokedex_API.Context
{
    public class AppDBContext : DbContext
    {
        private PokemonSeed _pokemonSeed;

        public DbSet<Pokemon> Pokemons { get; set; }
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {
            _pokemonSeed = new PokemonSeed();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pokemon>()
                .Property(p => p.Created_at)
                .HasDefaultValueSql("getdate()");
            modelBuilder.Entity<Pokemon>()
                .Property(p => p.Updated_at)
                .IsRowVersion();
            modelBuilder.Entity<Pokemon>()
                .HasData(
                new Pokemon()
                {
                    Id= 1,
                    Name= "bulbasaur",
                    BaseExperience= 64,
                    IsDefault= true,
                    Height= 7,
                    Weight= 69,
                    Order= 1,
                    BackMale= "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/1.png",
                    FrontMale= "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/1.png",                   
                },
                new Pokemon()
                {
                    Id= 2,
                    Name= "ivysaur",
                    BaseExperience= 142,
                    IsDefault= true,
                    Height= 10,
                    Weight= 130,
                    Order= 2,
                    BackMale= "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/2.png",
                    FrontMale= "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/2.png",                   
                },
                new Pokemon()
                {
                    Id= 3,
                    Name= "venusaur",
                    BaseExperience= 236,
                    IsDefault= true,
                    Height= 20,
                    Weight= 1000,
                    Order= 3,
                    BackMale= "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/3.png",
                    FrontMale= "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/3.png",                   
                },
                new Pokemon()
                {
                    Id= 4,
                    Name= "charmander",
                    BaseExperience= 62,
                    IsDefault= true,
                    Height= 6,
                    Weight= 85,
                    Order= 5,
                    BackMale= "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/4.png",
                    FrontMale= "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/4.png",                   
                },
                new Pokemon()
                {
                    Id= 5,
                    Name= "charmeleon",
                    BaseExperience= 142,
                    IsDefault= true,
                    Height= 11,
                    Weight= 190,
                    Order= 6,
                    BackMale= "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/5.png",
                    FrontMale= "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/5.png",                   
                }
                ,
                new Pokemon()
                {
                    Id= 6,
                    Name= "charmeleon",
                    BaseExperience= 240,
                    IsDefault= true,
                    Height= 17,
                    Weight= 905,
                    Order= 7,
                    BackMale= "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/6.png",
                    FrontMale= "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/6.png",                   
                }

                ); ;
        }

    }
}

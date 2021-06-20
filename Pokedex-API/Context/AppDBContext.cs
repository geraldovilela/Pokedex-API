using Microsoft.EntityFrameworkCore;
using Pokedex_API.Context.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pokedex_API.Context
{
    public class AppDBContext : DbContext
    {
        public DbSet<Pokemon> Pokemons { get; set; }
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pokemon>()
                .Property(p => p.Created_at)
                .HasDefaultValueSql("getdate()");
            modelBuilder.Entity<PokemonSprites>()
                .Property(p => p.Created_at)
                .HasDefaultValueSql("getdate()");
            modelBuilder.Entity<PokemonStats>()
                .Property(p => p.Created_at)
                .HasDefaultValueSql("getdate()");
            
        }

    }
}

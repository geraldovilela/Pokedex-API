﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Pokedex_API.Context;

namespace Pokedex_API.Migrations
{
    [DbContext(typeof(AppDBContext))]
    partial class AppDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Pokedex_API.Context.Entities.Pokemon", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BackMale")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("BaseExperience")
                        .HasColumnType("int");

                    b.Property<DateTime>("Created_at")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("getdate()");

                    b.Property<string>("FrontMale")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Height")
                        .HasColumnType("int");

                    b.Property<bool>("IsDefault")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Order")
                        .HasColumnType("int");

                    b.Property<byte[]>("Updated_at")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.Property<int>("Weight")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Pokemons");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BackMale = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/1.png",
                            BaseExperience = 64,
                            Created_at = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FrontMale = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/1.png",
                            Height = 7,
                            IsDefault = true,
                            Name = "bulbasaur",
                            Order = 1,
                            Weight = 69
                        },
                        new
                        {
                            Id = 2,
                            BackMale = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/2.png",
                            BaseExperience = 142,
                            Created_at = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FrontMale = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/2.png",
                            Height = 10,
                            IsDefault = true,
                            Name = "ivysaur",
                            Order = 2,
                            Weight = 130
                        },
                        new
                        {
                            Id = 3,
                            BackMale = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/3.png",
                            BaseExperience = 236,
                            Created_at = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FrontMale = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/3.png",
                            Height = 20,
                            IsDefault = true,
                            Name = "venusaur",
                            Order = 3,
                            Weight = 1000
                        },
                        new
                        {
                            Id = 4,
                            BackMale = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/4.png",
                            BaseExperience = 62,
                            Created_at = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FrontMale = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/4.png",
                            Height = 6,
                            IsDefault = true,
                            Name = "charmander",
                            Order = 5,
                            Weight = 85
                        },
                        new
                        {
                            Id = 5,
                            BackMale = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/5.png",
                            BaseExperience = 142,
                            Created_at = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FrontMale = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/5.png",
                            Height = 11,
                            IsDefault = true,
                            Name = "charmeleon",
                            Order = 6,
                            Weight = 190
                        },
                        new
                        {
                            Id = 6,
                            BackMale = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/6.png",
                            BaseExperience = 240,
                            Created_at = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FrontMale = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/6.png",
                            Height = 17,
                            IsDefault = true,
                            Name = "charmeleon",
                            Order = 7,
                            Weight = 905
                        });
                });
#pragma warning restore 612, 618
        }
    }
}

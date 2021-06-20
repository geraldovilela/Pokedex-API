using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Pokedex_API.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pokemons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BaseExperience = table.Column<int>(type: "int", nullable: false),
                    IsDefault = table.Column<bool>(type: "bit", nullable: false),
                    Height = table.Column<int>(type: "int", nullable: false),
                    Weight = table.Column<int>(type: "int", nullable: false),
                    Order = table.Column<int>(type: "int", nullable: false),
                    BackMale = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FrontMale = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Created_at = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getdate()"),
                    Updated_at = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pokemons", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Pokemons",
                columns: new[] { "Id", "BackMale", "BaseExperience", "FrontMale", "Height", "IsDefault", "Name", "Order", "Weight" },
                values: new object[,]
                {
                    { 1, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/1.png", 64, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/1.png", 7, true, "bulbasaur", 1, 69 },
                    { 2, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/2.png", 142, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/2.png", 10, true, "ivysaur", 2, 130 },
                    { 3, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/3.png", 236, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/3.png", 20, true, "venusaur", 3, 1000 },
                    { 4, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/4.png", 62, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/4.png", 6, true, "charmander", 5, 85 },
                    { 5, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/5.png", 142, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/5.png", 11, true, "charmeleon", 6, 190 },
                    { 6, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/6.png", 240, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/6.png", 17, true, "charmeleon", 7, 905 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pokemons");
        }
    }
}

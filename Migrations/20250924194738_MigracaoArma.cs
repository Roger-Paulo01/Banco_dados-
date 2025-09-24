using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RpgApi.Migrations
{
    /// <inheritdoc />
    public partial class MigracaoArma : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TB_ARMA",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false),
                    Dano = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_ARMA", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "TB_ARMA",
                columns: new[] { "Id", "Dano", "Nome" },
                values: new object[,]
                {
                    { 1, 7, "Anel de Sauron" },
                    { 2, 2, "Chicotinho" },
                    { 3, 4, "Cajado do Inferno" },
                    { 4, 3, "Poção de Veneno de serpente" },
                    { 5, 6, "Machado de Thor" },
                    { 6, 1, "Escudo de Escama de Dragão" },
                    { 7, 4, "Espada Forphal" },
                    { 8, 7, "Excalibur" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TB_ARMA");
        }
    }
}

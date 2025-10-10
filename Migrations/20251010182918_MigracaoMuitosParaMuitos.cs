using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RpgApi.Migrations
{
    /// <inheritdoc />
    public partial class MigracaoMuitosParaMuitos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TB_HABILIDADES",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false),
                    Dano = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_HABILIDADES", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TB_PERSONAGENS_HABILIDADES",
                columns: table => new
                {
                    PersonagemId = table.Column<int>(type: "int", nullable: false),
                    HabilidadeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_PERSONAGENS_HABILIDADES", x => new { x.PersonagemId, x.HabilidadeId });
                    table.ForeignKey(
                        name: "FK_TB_PERSONAGENS_HABILIDADES_TB_HABILIDADES_HabilidadeId",
                        column: x => x.HabilidadeId,
                        principalTable: "TB_HABILIDADES",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TB_PERSONAGENS_HABILIDADES_TB_PERSONAGENS_PersonagemId",
                        column: x => x.PersonagemId,
                        principalTable: "TB_PERSONAGENS",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "TB_HABILIDADES",
                columns: new[] { "Id", "Dano", "Nome" },
                values: new object[,]
                {
                    { 1, 39, "Adormecer" },
                    { 2, 41, "Congelar" },
                    { 3, 37, "Hipnotizar" }
                });

            migrationBuilder.UpdateData(
                table: "TB_USUARIOS",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 84, 2, 70, 149, 103, 151, 49, 81, 183, 56, 250, 136, 194, 21, 68, 66, 74, 248, 203, 234, 120, 212, 98, 81, 167, 2, 168, 192, 5, 48, 57, 35, 64, 159, 176, 222, 129, 47, 89, 184, 212, 26, 42, 74, 231, 45, 201, 113, 158, 57, 253, 202, 148, 124, 103, 249, 118, 255, 208, 81, 61, 222, 138, 1 }, new byte[] { 164, 189, 90, 85, 21, 234, 250, 121, 122, 168, 17, 120, 72, 104, 118, 183, 242, 174, 108, 229, 9, 12, 233, 235, 141, 146, 109, 209, 112, 62, 49, 220, 7, 17, 67, 207, 80, 52, 3, 124, 152, 195, 180, 6, 225, 108, 35, 91, 82, 155, 42, 254, 73, 143, 97, 135, 80, 232, 206, 44, 60, 147, 221, 233, 207, 220, 140, 187, 153, 185, 210, 72, 165, 73, 49, 238, 85, 183, 62, 17, 248, 193, 234, 170, 114, 4, 51, 181, 207, 180, 101, 89, 233, 58, 70, 187, 20, 171, 116, 215, 109, 153, 118, 163, 192, 61, 140, 155, 160, 220, 32, 186, 217, 130, 83, 222, 208, 238, 196, 199, 18, 59, 8, 119, 204, 91, 202, 233 } });

            migrationBuilder.InsertData(
                table: "TB_PERSONAGENS_HABILIDADES",
                columns: new[] { "HabilidadeId", "PersonagemId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 },
                    { 2, 2 },
                    { 3, 3 },
                    { 3, 4 },
                    { 2, 5 },
                    { 1, 6 },
                    { 3, 7 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_TB_PERSONAGENS_HABILIDADES_HabilidadeId",
                table: "TB_PERSONAGENS_HABILIDADES",
                column: "HabilidadeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TB_PERSONAGENS_HABILIDADES");

            migrationBuilder.DropTable(
                name: "TB_HABILIDADES");

            migrationBuilder.UpdateData(
                table: "TB_USUARIOS",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 108, 232, 179, 100, 155, 209, 198, 250, 237, 17, 163, 73, 211, 200, 114, 146, 148, 27, 149, 78, 203, 144, 13, 104, 183, 226, 186, 65, 106, 4, 245, 222, 239, 13, 227, 186, 93, 67, 171, 17, 252, 188, 43, 163, 38, 24, 153, 35, 247, 134, 223, 70, 249, 253, 99, 233, 87, 56, 21, 28, 116, 168, 129, 223 }, new byte[] { 146, 241, 27, 96, 86, 233, 83, 230, 202, 199, 127, 67, 160, 41, 190, 37, 73, 31, 190, 202, 50, 140, 226, 11, 247, 134, 233, 151, 240, 198, 30, 229, 192, 14, 6, 206, 43, 141, 156, 149, 71, 192, 71, 245, 36, 97, 223, 225, 4, 108, 15, 114, 159, 253, 133, 161, 23, 138, 134, 179, 205, 7, 50, 78, 165, 216, 236, 98, 8, 80, 190, 194, 9, 226, 8, 166, 217, 95, 47, 91, 190, 241, 71, 69, 58, 191, 217, 66, 140, 14, 154, 235, 158, 14, 131, 110, 24, 144, 26, 218, 123, 104, 179, 86, 82, 51, 41, 189, 70, 170, 31, 222, 31, 6, 164, 194, 55, 244, 186, 183, 85, 56, 56, 193, 206, 255, 43, 30 } });
        }
    }
}

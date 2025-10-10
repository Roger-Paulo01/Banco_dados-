using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RpgApi.Migrations
{
    /// <inheritdoc />
    public partial class MigracaoUmParaUm : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Perfil",
                table: "TB_USUARIOS",
                type: "varchar(200)",
                maxLength: 200,
                nullable: true,
                defaultValue: "Jogador",
                oldClrType: typeof(string),
                oldType: "varchar(200)",
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Derrota",
                table: "TB_PERSONAGENS",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Disputas",
                table: "TB_PERSONAGENS",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Vitorias",
                table: "TB_PERSONAGENS",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PersonagemId",
                table: "TB_ARMA",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "TB_ARMA",
                keyColumn: "Id",
                keyValue: 1,
                column: "PersonagemId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TB_ARMA",
                keyColumn: "Id",
                keyValue: 2,
                column: "PersonagemId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "TB_ARMA",
                keyColumn: "Id",
                keyValue: 3,
                column: "PersonagemId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "TB_ARMA",
                keyColumn: "Id",
                keyValue: 4,
                column: "PersonagemId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "TB_ARMA",
                keyColumn: "Id",
                keyValue: 5,
                column: "PersonagemId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "TB_ARMA",
                keyColumn: "Id",
                keyValue: 6,
                column: "PersonagemId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "TB_ARMA",
                keyColumn: "Id",
                keyValue: 7,
                column: "PersonagemId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "TB_ARMA",
                keyColumn: "Id",
                keyValue: 8,
                column: "PersonagemId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Derrota", "Disputas", "Vitorias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Derrota", "Disputas", "Vitorias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Derrota", "Disputas", "Vitorias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Derrota", "Disputas", "Vitorias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Derrota", "Disputas", "Vitorias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Derrota", "Disputas", "Vitorias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Derrota", "Disputas", "Vitorias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.InsertData(
                table: "TB_PERSONAGENS",
                columns: new[] { "Id", "Classe", "Defesa", "Derrota", "Disputas", "Forca", "FotoPersonagem", "Inteligencia", "Nome", "PontosVida", "UsuarioId", "Vitorias" },
                values: new object[] { 8, 2, 12, 0, 0, 30, null, 30, "Mario", 80, 1, 0 });

            migrationBuilder.UpdateData(
                table: "TB_USUARIOS",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 108, 232, 179, 100, 155, 209, 198, 250, 237, 17, 163, 73, 211, 200, 114, 146, 148, 27, 149, 78, 203, 144, 13, 104, 183, 226, 186, 65, 106, 4, 245, 222, 239, 13, 227, 186, 93, 67, 171, 17, 252, 188, 43, 163, 38, 24, 153, 35, 247, 134, 223, 70, 249, 253, 99, 233, 87, 56, 21, 28, 116, 168, 129, 223 }, new byte[] { 146, 241, 27, 96, 86, 233, 83, 230, 202, 199, 127, 67, 160, 41, 190, 37, 73, 31, 190, 202, 50, 140, 226, 11, 247, 134, 233, 151, 240, 198, 30, 229, 192, 14, 6, 206, 43, 141, 156, 149, 71, 192, 71, 245, 36, 97, 223, 225, 4, 108, 15, 114, 159, 253, 133, 161, 23, 138, 134, 179, 205, 7, 50, 78, 165, 216, 236, 98, 8, 80, 190, 194, 9, 226, 8, 166, 217, 95, 47, 91, 190, 241, 71, 69, 58, 191, 217, 66, 140, 14, 154, 235, 158, 14, 131, 110, 24, 144, 26, 218, 123, 104, 179, 86, 82, 51, 41, 189, 70, 170, 31, 222, 31, 6, 164, 194, 55, 244, 186, 183, 85, 56, 56, 193, 206, 255, 43, 30 } });

            migrationBuilder.CreateIndex(
                name: "IX_TB_ARMA_PersonagemId",
                table: "TB_ARMA",
                column: "PersonagemId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_TB_ARMA_TB_PERSONAGENS_PersonagemId",
                table: "TB_ARMA",
                column: "PersonagemId",
                principalTable: "TB_PERSONAGENS",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TB_ARMA_TB_PERSONAGENS_PersonagemId",
                table: "TB_ARMA");

            migrationBuilder.DropIndex(
                name: "IX_TB_ARMA_PersonagemId",
                table: "TB_ARMA");

            migrationBuilder.DeleteData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DropColumn(
                name: "Derrota",
                table: "TB_PERSONAGENS");

            migrationBuilder.DropColumn(
                name: "Disputas",
                table: "TB_PERSONAGENS");

            migrationBuilder.DropColumn(
                name: "Vitorias",
                table: "TB_PERSONAGENS");

            migrationBuilder.DropColumn(
                name: "PersonagemId",
                table: "TB_ARMA");

            migrationBuilder.AlterColumn<string>(
                name: "Perfil",
                table: "TB_USUARIOS",
                type: "varchar(200)",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(200)",
                oldMaxLength: 200,
                oldNullable: true,
                oldDefaultValue: "Jogador");

            migrationBuilder.UpdateData(
                table: "TB_USUARIOS",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 141, 199, 17, 251, 72, 184, 195, 122, 220, 92, 198, 135, 226, 35, 192, 14, 73, 182, 112, 45, 162, 254, 226, 230, 40, 205, 151, 85, 77, 241, 191, 42, 67, 141, 131, 213, 229, 33, 210, 97, 52, 58, 216, 18, 196, 118, 20, 179, 203, 198, 22, 0, 173, 154, 44, 23, 1, 32, 200, 74, 20, 41, 187, 27 }, new byte[] { 109, 170, 144, 17, 4, 132, 145, 69, 76, 191, 202, 71, 244, 88, 174, 112, 207, 37, 1, 87, 104, 84, 253, 221, 196, 83, 57, 46, 174, 73, 21, 128, 236, 221, 32, 90, 90, 146, 204, 79, 122, 243, 160, 224, 35, 148, 196, 0, 142, 125, 224, 56, 247, 237, 138, 116, 172, 249, 77, 133, 170, 87, 157, 17, 141, 255, 67, 4, 159, 75, 54, 195, 78, 166, 36, 157, 38, 209, 59, 92, 157, 156, 61, 180, 43, 41, 72, 28, 36, 230, 113, 100, 105, 148, 8, 226, 197, 62, 60, 81, 128, 239, 210, 112, 204, 12, 247, 101, 228, 235, 239, 215, 28, 109, 70, 189, 170, 193, 56, 185, 97, 77, 22, 27, 135, 190, 180, 57 } });
        }
    }
}

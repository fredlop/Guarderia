using Microsoft.EntityFrameworkCore.Migrations;

namespace MatriculaOnline.App.Persistencia.Migrations
{
    public partial class generosseed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Generos",
                columns: new[] { "IdGenero", "NombreGenero" },
                values: new object[] { 1, "Masculino" });

            migrationBuilder.InsertData(
                table: "Generos",
                columns: new[] { "IdGenero", "NombreGenero" },
                values: new object[] { 2, "Femenino" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Generos",
                keyColumn: "IdGenero",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Generos",
                keyColumn: "IdGenero",
                keyValue: 2);
        }
    }
}

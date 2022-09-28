using Microsoft.EntityFrameworkCore.Migrations;

namespace MatriculaOnline.App.Persistencia.Migrations
{
    public partial class seedtiposdeidentificacion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "TiposDeIdentificacion",
                columns: new[] { "IdIdentificacion", "NombreIdentificacion" },
                values: new object[,]
                {
                    { 1, "Tarjeta de Identidad" },
                    { 2, "Cedula" },
                    { 3, "Pasaporte" },
                    { 4, "Cedula de extranjeria" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TiposDeIdentificacion",
                keyColumn: "IdIdentificacion",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TiposDeIdentificacion",
                keyColumn: "IdIdentificacion",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TiposDeIdentificacion",
                keyColumn: "IdIdentificacion",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TiposDeIdentificacion",
                keyColumn: "IdIdentificacion",
                keyValue: 4);
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace Guarderia.App.Persistencia.Migrations
{
    public partial class TablaGrados : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Profesor",
                table: "Alumnos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Alumnos",
                table: "Alumnos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Grados",
                columns: table => new
                {
                    IdGrado = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreGrado = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grados", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Grados");

            migrationBuilder.DropColumn(
                name: "Profesor",
                table: "Alumnos");

            migrationBuilder.DropColumn(
                name: "Alumnos",
                table: "Alumnos");
        }
    }
}

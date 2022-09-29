using Microsoft.EntityFrameworkCore.Migrations;

namespace Guarderia.App.Persistencia.Migrations
{
    public partial class TablaAlumnos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Alumnos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fecha_nacimiento = table.Column<int>(type: "nvarchar(max)", nullable: true),
                    Hora_entrada = table.Column<int>(type: "nvarchar(max)", nullable: true),
                    Hora_salida = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Padre = table.Column<int>(type: "nvarchar(max)", nullable: true),
                    Madre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Acudiente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Id_grado = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alumnos", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Alumnos");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace Guarderia.App.Persistencia.Migrations
{
    public partial class nuevastablas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Personas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Apellido = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cedula = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Numero_telefono = table.Column<int>(type: "nvarchar(max)", nullable: true),
                    Correo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Id_grado = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personas", x => x.IdPersona);
                    table.ForeignKey(
                        name: "FK_Persona_Grado_Id",
                        column: x => x.IdGrado,
                        principalTable: "Grados",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Personas_Grado_Id",
                        column: x => x.IdGrado,
                        principalTable: "Grado",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Grados",
                columns: new[] { "Id", "Profesor" },
                values: new object[,]
                {
                    { 1, "Pre-Jardin" },
                    { 2, "jardin" },
                    { 3, "Trancision" }
                });

                migrationBuilder.DeleteData(
                table: "Grados",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Grados",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Grados",
                keyColumn: "Id",
                keyValue: 3);
            
        }
    }
}

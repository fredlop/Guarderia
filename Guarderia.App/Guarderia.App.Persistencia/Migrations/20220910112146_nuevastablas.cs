using Microsoft.EntityFrameworkCore.Migrations;

namespace MatriculaOnline.App.Persistencia.Migrations
{
    public partial class nuevastablas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Profesores",
                columns: table => new
                {
                    IdProfesor = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdUsuario = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Apellido = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdTipoIdeIdentificacion = table.Column<int>(type: "int", nullable: true),
                    NumeroDeIdentificacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdGenero = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profesores", x => x.IdProfesor);
                    table.ForeignKey(
                        name: "FK_Profesores_Generos_IdGenero",
                        column: x => x.IdGenero,
                        principalTable: "Generos",
                        principalColumn: "IdGenero",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Profesores_TiposDeIdentificacion_IdTipoIdeIdentificacion",
                        column: x => x.IdTipoIdeIdentificacion,
                        principalTable: "TiposDeIdentificacion",
                        principalColumn: "IdIdentificacion",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Years",
                columns: table => new
                {
                    IdYear = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreYear = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Years", x => x.IdYear);
                });

            migrationBuilder.CreateTable(
                name: "Materias",
                columns: table => new
                {
                    IdMateria = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreMateria = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdGrado = table.Column<int>(type: "int", nullable: false),
                    IdProfesor = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Materias", x => x.IdMateria);
                    table.ForeignKey(
                        name: "FK_Materias_Grados_IdGrado",
                        column: x => x.IdGrado,
                        principalTable: "Grados",
                        principalColumn: "IdGrado",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Materias_Profesores_IdProfesor",
                        column: x => x.IdProfesor,
                        principalTable: "Profesores",
                        principalColumn: "IdProfesor",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Grados",
                columns: new[] { "IdGrado", "NombreGrado" },
                values: new object[,]
                {
                    { 1, "Primero de primaria" },
                    { 2, "Segundo de de primaria" },
                    { 3, "Tercero de de primaria" },
                    { 4, "Cuarto de de primaria" },
                    { 5, "Quinto de de primaria" }
                });

            migrationBuilder.InsertData(
                table: "Years",
                columns: new[] { "IdYear", "NombreYear" },
                values: new object[,]
                {
                    { 1, "2022" },
                    { 2, "2023" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Materias_IdGrado",
                table: "Materias",
                column: "IdGrado");

            migrationBuilder.CreateIndex(
                name: "IX_Materias_IdProfesor",
                table: "Materias",
                column: "IdProfesor");

            migrationBuilder.CreateIndex(
                name: "IX_Profesores_IdGenero",
                table: "Profesores",
                column: "IdGenero");

            migrationBuilder.CreateIndex(
                name: "IX_Profesores_IdTipoIdeIdentificacion",
                table: "Profesores",
                column: "IdTipoIdeIdentificacion");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Materias");

            migrationBuilder.DropTable(
                name: "Years");

            migrationBuilder.DropTable(
                name: "Profesores");

            migrationBuilder.DeleteData(
                table: "Grados",
                keyColumn: "IdGrado",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Grados",
                keyColumn: "IdGrado",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Grados",
                keyColumn: "IdGrado",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Grados",
                keyColumn: "IdGrado",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Grados",
                keyColumn: "IdGrado",
                keyValue: 5);
        }
    }
}

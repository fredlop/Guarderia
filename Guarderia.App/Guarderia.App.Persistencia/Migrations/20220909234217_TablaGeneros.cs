using Microsoft.EntityFrameworkCore.Migrations;

namespace MatriculaOnline.App.Persistencia.Migrations
{
    public partial class TablaGeneros : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Estudiantes_TiposIdentificacion_TiposIdentificacionIdIdentificacion",
                table: "Estudiantes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TiposIdentificacion",
                table: "TiposIdentificacion");

            migrationBuilder.RenameTable(
                name: "TiposIdentificacion",
                newName: "TiposDeIdentificacion");

            migrationBuilder.RenameColumn(
                name: "Genero",
                table: "Estudiantes",
                newName: "IdGenero");

            migrationBuilder.AddColumn<int>(
                name: "GeneroIdGenero",
                table: "Estudiantes",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_TiposDeIdentificacion",
                table: "TiposDeIdentificacion",
                column: "IdIdentificacion");

            migrationBuilder.CreateTable(
                name: "Generos",
                columns: table => new
                {
                    IdGenero = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreGenero = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Generos", x => x.IdGenero);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Estudiantes_GeneroIdGenero",
                table: "Estudiantes",
                column: "GeneroIdGenero");

            migrationBuilder.AddForeignKey(
                name: "FK_Estudiantes_Generos_GeneroIdGenero",
                table: "Estudiantes",
                column: "GeneroIdGenero",
                principalTable: "Generos",
                principalColumn: "IdGenero",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Estudiantes_TiposDeIdentificacion_TiposIdentificacionIdIdentificacion",
                table: "Estudiantes",
                column: "TiposIdentificacionIdIdentificacion",
                principalTable: "TiposDeIdentificacion",
                principalColumn: "IdIdentificacion",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Estudiantes_Generos_GeneroIdGenero",
                table: "Estudiantes");

            migrationBuilder.DropForeignKey(
                name: "FK_Estudiantes_TiposDeIdentificacion_TiposIdentificacionIdIdentificacion",
                table: "Estudiantes");

            migrationBuilder.DropTable(
                name: "Generos");

            migrationBuilder.DropIndex(
                name: "IX_Estudiantes_GeneroIdGenero",
                table: "Estudiantes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TiposDeIdentificacion",
                table: "TiposDeIdentificacion");

            migrationBuilder.DropColumn(
                name: "GeneroIdGenero",
                table: "Estudiantes");

            migrationBuilder.RenameTable(
                name: "TiposDeIdentificacion",
                newName: "TiposIdentificacion");

            migrationBuilder.RenameColumn(
                name: "IdGenero",
                table: "Estudiantes",
                newName: "Genero");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TiposIdentificacion",
                table: "TiposIdentificacion",
                column: "IdIdentificacion");

            migrationBuilder.AddForeignKey(
                name: "FK_Estudiantes_TiposIdentificacion_TiposIdentificacionIdIdentificacion",
                table: "Estudiantes",
                column: "TiposIdentificacionIdIdentificacion",
                principalTable: "TiposIdentificacion",
                principalColumn: "IdIdentificacion",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

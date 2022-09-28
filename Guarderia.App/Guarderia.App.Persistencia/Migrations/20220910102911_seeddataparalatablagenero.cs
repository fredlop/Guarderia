using Microsoft.EntityFrameworkCore.Migrations;

namespace MatriculaOnline.App.Persistencia.Migrations
{
    public partial class seeddataparalatablagenero : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Estudiantes_Generos_GeneroIdGenero",
                table: "Estudiantes");

            migrationBuilder.DropIndex(
                name: "IX_Estudiantes_GeneroIdGenero",
                table: "Estudiantes");

            migrationBuilder.DropColumn(
                name: "GeneroIdGenero",
                table: "Estudiantes");

            migrationBuilder.CreateIndex(
                name: "IX_Estudiantes_IdGenero",
                table: "Estudiantes",
                column: "IdGenero");

            migrationBuilder.AddForeignKey(
                name: "FK_Estudiantes_Generos_IdGenero",
                table: "Estudiantes",
                column: "IdGenero",
                principalTable: "Generos",
                principalColumn: "IdGenero",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Estudiantes_Generos_IdGenero",
                table: "Estudiantes");

            migrationBuilder.DropIndex(
                name: "IX_Estudiantes_IdGenero",
                table: "Estudiantes");

            migrationBuilder.AddColumn<int>(
                name: "GeneroIdGenero",
                table: "Estudiantes",
                type: "int",
                nullable: true);

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
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace MatriculaOnline.App.Persistencia.Migrations
{
    public partial class tipodeidentificacionupdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Estudiantes_TiposDeIdentificacion_TiposIdentificacionIdIdentificacion",
                table: "Estudiantes");

            migrationBuilder.DropIndex(
                name: "IX_Estudiantes_TiposIdentificacionIdIdentificacion",
                table: "Estudiantes");

            migrationBuilder.DropColumn(
                name: "TiposIdentificacionIdIdentificacion",
                table: "Estudiantes");

            migrationBuilder.CreateIndex(
                name: "IX_Estudiantes_IdTipoIdeIdentificacion",
                table: "Estudiantes",
                column: "IdTipoIdeIdentificacion");

            migrationBuilder.AddForeignKey(
                name: "FK_Estudiantes_TiposDeIdentificacion_IdTipoIdeIdentificacion",
                table: "Estudiantes",
                column: "IdTipoIdeIdentificacion",
                principalTable: "TiposDeIdentificacion",
                principalColumn: "IdIdentificacion",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Estudiantes_TiposDeIdentificacion_IdTipoIdeIdentificacion",
                table: "Estudiantes");

            migrationBuilder.DropIndex(
                name: "IX_Estudiantes_IdTipoIdeIdentificacion",
                table: "Estudiantes");

            migrationBuilder.AddColumn<int>(
                name: "TiposIdentificacionIdIdentificacion",
                table: "Estudiantes",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Estudiantes_TiposIdentificacionIdIdentificacion",
                table: "Estudiantes",
                column: "TiposIdentificacionIdIdentificacion");

            migrationBuilder.AddForeignKey(
                name: "FK_Estudiantes_TiposDeIdentificacion_TiposIdentificacionIdIdentificacion",
                table: "Estudiantes",
                column: "TiposIdentificacionIdIdentificacion",
                principalTable: "TiposDeIdentificacion",
                principalColumn: "IdIdentificacion",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

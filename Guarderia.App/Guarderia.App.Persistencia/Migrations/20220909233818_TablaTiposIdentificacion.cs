using Microsoft.EntityFrameworkCore.Migrations;

namespace MatriculaOnline.App.Persistencia.Migrations
{
    public partial class TablaTiposIdentificacion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TiposIdentificacionIdIdentificacion",
                table: "Estudiantes",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "TiposIdentificacion",
                columns: table => new
                {
                    IdIdentificacion = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreIdentificacion = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposIdentificacion", x => x.IdIdentificacion);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Estudiantes_TiposIdentificacionIdIdentificacion",
                table: "Estudiantes",
                column: "TiposIdentificacionIdIdentificacion");

            migrationBuilder.AddForeignKey(
                name: "FK_Estudiantes_TiposIdentificacion_TiposIdentificacionIdIdentificacion",
                table: "Estudiantes",
                column: "TiposIdentificacionIdIdentificacion",
                principalTable: "TiposIdentificacion",
                principalColumn: "IdIdentificacion",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Estudiantes_TiposIdentificacion_TiposIdentificacionIdIdentificacion",
                table: "Estudiantes");

            migrationBuilder.DropTable(
                name: "TiposIdentificacion");

            migrationBuilder.DropIndex(
                name: "IX_Estudiantes_TiposIdentificacionIdIdentificacion",
                table: "Estudiantes");

            migrationBuilder.DropColumn(
                name: "TiposIdentificacionIdIdentificacion",
                table: "Estudiantes");
        }
    }
}

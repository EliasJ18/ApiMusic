using Microsoft.EntityFrameworkCore.Migrations;

namespace MusicApi.Migrations
{
    public partial class imageAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Canciones_Artistas_ArtistaId",
                table: "Canciones");

            migrationBuilder.DropColumn(
                name: "Genero",
                table: "Canciones");

            migrationBuilder.AlterColumn<int>(
                name: "ArtistaId",
                table: "Canciones",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Artistas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Canciones_Artistas_ArtistaId",
                table: "Canciones",
                column: "ArtistaId",
                principalTable: "Artistas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Canciones_Artistas_ArtistaId",
                table: "Canciones");

            migrationBuilder.DropColumn(
                name: "Image",
                table: "Artistas");

            migrationBuilder.AlterColumn<int>(
                name: "ArtistaId",
                table: "Canciones",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Genero",
                table: "Canciones",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Canciones_Artistas_ArtistaId",
                table: "Canciones",
                column: "ArtistaId",
                principalTable: "Artistas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

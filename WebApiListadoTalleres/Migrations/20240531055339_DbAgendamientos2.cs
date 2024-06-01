using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApiListadoTalleres.Migrations
{
    public partial class DbAgendamientos2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DbTalleres_DbTalleres_TallerId",
                table: "DbTalleres");

            migrationBuilder.DropIndex(
                name: "IX_DbTalleres_TallerId",
                table: "DbTalleres");

            migrationBuilder.DropColumn(
                name: "TallerId",
                table: "DbTalleres");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TallerId",
                table: "DbTalleres",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_DbTalleres_TallerId",
                table: "DbTalleres",
                column: "TallerId");

            migrationBuilder.AddForeignKey(
                name: "FK_DbTalleres_DbTalleres_TallerId",
                table: "DbTalleres",
                column: "TallerId",
                principalTable: "DbTalleres",
                principalColumn: "Id");
        }
    }
}

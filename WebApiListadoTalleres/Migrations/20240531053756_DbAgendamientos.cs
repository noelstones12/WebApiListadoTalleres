using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApiListadoTalleres.Migrations
{
    public partial class DbAgendamientos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TallerId",
                table: "DbTalleres",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "DbAgendamientos",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TallerId = table.Column<int>(type: "int", nullable: false),
                    fecha = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    hora = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DbAgendamientos", x => x.id);
                    table.ForeignKey(
                        name: "FK_DbAgendamientos_DbTalleres_TallerId",
                        column: x => x.TallerId,
                        principalTable: "DbTalleres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DbTalleres_TallerId",
                table: "DbTalleres",
                column: "TallerId");

            migrationBuilder.CreateIndex(
                name: "IX_DbAgendamientos_TallerId",
                table: "DbAgendamientos",
                column: "TallerId");

            migrationBuilder.AddForeignKey(
                name: "FK_DbTalleres_DbTalleres_TallerId",
                table: "DbTalleres",
                column: "TallerId",
                principalTable: "DbTalleres",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DbTalleres_DbTalleres_TallerId",
                table: "DbTalleres");

            migrationBuilder.DropTable(
                name: "DbAgendamientos");

            migrationBuilder.DropIndex(
                name: "IX_DbTalleres_TallerId",
                table: "DbTalleres");

            migrationBuilder.DropColumn(
                name: "TallerId",
                table: "DbTalleres");
        }
    }
}

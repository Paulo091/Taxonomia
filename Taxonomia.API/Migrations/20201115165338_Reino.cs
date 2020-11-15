using Microsoft.EntityFrameworkCore.Migrations;

namespace Taxonomia.API.Migrations
{
    public partial class Reino : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Reinos",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(nullable: true),
                    Descricao = table.Column<string>(nullable: true),
                    DominioID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reinos", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Reinos_Dominios_DominioID",
                        column: x => x.DominioID,
                        principalTable: "Dominios",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Reinos_DominioID",
                table: "Reinos",
                column: "DominioID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reinos");
        }
    }
}

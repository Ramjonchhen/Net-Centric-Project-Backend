using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Net_Centric_Project.Migrations
{
    public partial class foreignkeyfirsttry : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AdminFutsalMappings",
                columns: table => new
                {
                    AdminId = table.Column<int>(type: "int", nullable: false),
                    FutsalId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdminFutsalMappings", x => new { x.AdminId, x.FutsalId });
                    table.ForeignKey(
                        name: "FK_AdminFutsalMappings_Admins_AdminId",
                        column: x => x.AdminId,
                        principalTable: "Admins",
                        principalColumn: "AdminId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AdminFutsalMappings_Futsals_FutsalId",
                        column: x => x.FutsalId,
                        principalTable: "Futsals",
                        principalColumn: "FutsalId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AdminFutsalMappings_FutsalId",
                table: "AdminFutsalMappings",
                column: "FutsalId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdminFutsalMappings");
        }
    }
}

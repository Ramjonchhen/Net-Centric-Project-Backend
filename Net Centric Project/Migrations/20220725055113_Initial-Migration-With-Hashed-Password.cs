using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Net_Centric_Project.Migrations
{
    public partial class InitialMigrationWithHashedPassword : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Password",
                table: "Users",
                newName: "Salt");

            migrationBuilder.RenameColumn(
                name: "Password",
                table: "Admins",
                newName: "Salt");

            migrationBuilder.AddColumn<string>(
                name: "Hash",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Hash",
                table: "Admins",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Hash",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Hash",
                table: "Admins");

            migrationBuilder.RenameColumn(
                name: "Salt",
                table: "Users",
                newName: "Password");

            migrationBuilder.RenameColumn(
                name: "Salt",
                table: "Admins",
                newName: "Password");
        }
    }
}

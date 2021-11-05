using Microsoft.EntityFrameworkCore.Migrations;

namespace OnTime.Migrations
{
    public partial class UserRole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Admin",
                table: "_roles");

            migrationBuilder.DropColumn(
                name: "Cashier",
                table: "_roles");

            migrationBuilder.RenameColumn(
                name: "IT",
                table: "_roles",
                newName: "roleName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "roleName",
                table: "_roles",
                newName: "IT");

            migrationBuilder.AddColumn<string>(
                name: "Admin",
                table: "_roles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Cashier",
                table: "_roles",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}

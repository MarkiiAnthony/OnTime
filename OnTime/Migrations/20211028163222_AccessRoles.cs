using Microsoft.EntityFrameworkCore.Migrations;

namespace OnTime.Migrations
{
    public partial class AccessRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "_roles",
                columns: table => new
                {
                    roleID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Admin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cashier = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IT = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__roles", x => x.roleID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "_roles");
        }
    }
}

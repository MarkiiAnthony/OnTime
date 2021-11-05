using Microsoft.EntityFrameworkCore.Migrations;

namespace OnTime.Migrations
{
    public partial class EmployeePunchLog : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Employee",
                table: "PunchClock",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Employee",
                table: "PunchClock");
        }
    }
}

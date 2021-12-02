using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OnTime.Migrations
{
    public partial class scheduler : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Schedules",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShiftDuration = table.Column<int>(type: "int", nullable: false),
                    startTime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Employee = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShiftType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date = table.Column<int>(type: "int", nullable: false),
                    StartWeek = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndWeek = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EmployeeId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsApproved = table.Column<bool>(type: "bit", nullable: false),
                    ManagerId = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Schedules", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Schedules");
        }
    }
}

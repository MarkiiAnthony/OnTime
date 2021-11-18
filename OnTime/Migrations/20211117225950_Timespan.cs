using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OnTime.Migrations
{
    public partial class Timespan : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<TimeSpan>(
                name: "HoursWorked",
                table: "PunchClock",
                type: "time",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0));

            migrationBuilder.AddColumn<int>(
                name: "HoursWorked",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HoursWorked",
                table: "PunchClock");

            migrationBuilder.DropColumn(
                name: "HoursWorked",
                table: "AspNetUsers");
        }
    }
}

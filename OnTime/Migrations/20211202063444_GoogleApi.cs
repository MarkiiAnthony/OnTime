using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OnTime.Migrations
{
    public partial class GoogleApi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EndWeek",
                table: "Schedules");

            migrationBuilder.DropColumn(
                name: "IsApproved",
                table: "Schedules");

            migrationBuilder.DropColumn(
                name: "ShiftDate",
                table: "Schedules");

            migrationBuilder.DropColumn(
                name: "ShiftDateEnd",
                table: "Schedules");

            migrationBuilder.DropColumn(
                name: "ShiftDuration",
                table: "Schedules");

            migrationBuilder.DropColumn(
                name: "StartWeek",
                table: "Schedules");

            migrationBuilder.RenameColumn(
                name: "ManagerId",
                table: "Schedules",
                newName: "EndTime");

            migrationBuilder.RenameColumn(
                name: "EmployeeId",
                table: "Schedules",
                newName: "CreatedBy");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "EndTime",
                table: "Schedules",
                newName: "ManagerId");

            migrationBuilder.RenameColumn(
                name: "CreatedBy",
                table: "Schedules",
                newName: "EmployeeId");

            migrationBuilder.AddColumn<DateTime>(
                name: "EndWeek",
                table: "Schedules",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "IsApproved",
                table: "Schedules",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "ShiftDate",
                table: "Schedules",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "ShiftDateEnd",
                table: "Schedules",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "ShiftDuration",
                table: "Schedules",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "StartWeek",
                table: "Schedules",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}

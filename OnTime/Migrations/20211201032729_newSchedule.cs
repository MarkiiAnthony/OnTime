using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OnTime.Migrations
{
    public partial class newSchedule : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Date",
                table: "Schedules",
                newName: "ShiftDuration7");

            migrationBuilder.AddColumn<DateTime>(
                name: "ShiftDate",
                table: "Schedules",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "ShiftDate2",
                table: "Schedules",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "ShiftDate3",
                table: "Schedules",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "ShiftDate4",
                table: "Schedules",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "ShiftDate5",
                table: "Schedules",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "ShiftDate6",
                table: "Schedules",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "ShiftDate7",
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

            migrationBuilder.AddColumn<DateTime>(
                name: "ShiftDateEnd2",
                table: "Schedules",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "ShiftDateEnd3",
                table: "Schedules",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "ShiftDateEnd4",
                table: "Schedules",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "ShiftDateEnd5",
                table: "Schedules",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "ShiftDateEnd6",
                table: "Schedules",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "ShiftDateEnd7",
                table: "Schedules",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "ShiftDuration2",
                table: "Schedules",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ShiftDuration3",
                table: "Schedules",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ShiftDuration4",
                table: "Schedules",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ShiftDuration5",
                table: "Schedules",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ShiftDuration6",
                table: "Schedules",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ShiftType2",
                table: "Schedules",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ShiftType3",
                table: "Schedules",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ShiftType4",
                table: "Schedules",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ShiftType5",
                table: "Schedules",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ShiftType6",
                table: "Schedules",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ShiftType7",
                table: "Schedules",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "startTime2",
                table: "Schedules",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "startTime3",
                table: "Schedules",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "startTime4",
                table: "Schedules",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "startTime5",
                table: "Schedules",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "startTime6",
                table: "Schedules",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "startTime7",
                table: "Schedules",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ShiftDate",
                table: "Schedules");

            migrationBuilder.DropColumn(
                name: "ShiftDate2",
                table: "Schedules");

            migrationBuilder.DropColumn(
                name: "ShiftDate3",
                table: "Schedules");

            migrationBuilder.DropColumn(
                name: "ShiftDate4",
                table: "Schedules");

            migrationBuilder.DropColumn(
                name: "ShiftDate5",
                table: "Schedules");

            migrationBuilder.DropColumn(
                name: "ShiftDate6",
                table: "Schedules");

            migrationBuilder.DropColumn(
                name: "ShiftDate7",
                table: "Schedules");

            migrationBuilder.DropColumn(
                name: "ShiftDateEnd",
                table: "Schedules");

            migrationBuilder.DropColumn(
                name: "ShiftDateEnd2",
                table: "Schedules");

            migrationBuilder.DropColumn(
                name: "ShiftDateEnd3",
                table: "Schedules");

            migrationBuilder.DropColumn(
                name: "ShiftDateEnd4",
                table: "Schedules");

            migrationBuilder.DropColumn(
                name: "ShiftDateEnd5",
                table: "Schedules");

            migrationBuilder.DropColumn(
                name: "ShiftDateEnd6",
                table: "Schedules");

            migrationBuilder.DropColumn(
                name: "ShiftDateEnd7",
                table: "Schedules");

            migrationBuilder.DropColumn(
                name: "ShiftDuration2",
                table: "Schedules");

            migrationBuilder.DropColumn(
                name: "ShiftDuration3",
                table: "Schedules");

            migrationBuilder.DropColumn(
                name: "ShiftDuration4",
                table: "Schedules");

            migrationBuilder.DropColumn(
                name: "ShiftDuration5",
                table: "Schedules");

            migrationBuilder.DropColumn(
                name: "ShiftDuration6",
                table: "Schedules");

            migrationBuilder.DropColumn(
                name: "ShiftType2",
                table: "Schedules");

            migrationBuilder.DropColumn(
                name: "ShiftType3",
                table: "Schedules");

            migrationBuilder.DropColumn(
                name: "ShiftType4",
                table: "Schedules");

            migrationBuilder.DropColumn(
                name: "ShiftType5",
                table: "Schedules");

            migrationBuilder.DropColumn(
                name: "ShiftType6",
                table: "Schedules");

            migrationBuilder.DropColumn(
                name: "ShiftType7",
                table: "Schedules");

            migrationBuilder.DropColumn(
                name: "startTime2",
                table: "Schedules");

            migrationBuilder.DropColumn(
                name: "startTime3",
                table: "Schedules");

            migrationBuilder.DropColumn(
                name: "startTime4",
                table: "Schedules");

            migrationBuilder.DropColumn(
                name: "startTime5",
                table: "Schedules");

            migrationBuilder.DropColumn(
                name: "startTime6",
                table: "Schedules");

            migrationBuilder.DropColumn(
                name: "startTime7",
                table: "Schedules");

            migrationBuilder.RenameColumn(
                name: "ShiftDuration7",
                table: "Schedules",
                newName: "Date");
        }
    }
}

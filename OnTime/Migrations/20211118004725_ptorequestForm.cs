using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OnTime.Migrations
{
    public partial class ptorequestForm : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "_Ptorequests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PtoType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HoursRequested = table.Column<int>(type: "int", nullable: false),
                    PtoStartDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Ptorequests", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "_Ptorequests");
        }
    }
}

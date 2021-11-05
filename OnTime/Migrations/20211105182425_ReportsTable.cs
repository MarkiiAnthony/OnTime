using Microsoft.EntityFrameworkCore.Migrations;

namespace OnTime.Migrations
{
    public partial class ReportsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ReportsID",
                table: "Atten",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "_Reports",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Atten_ReportsID",
                table: "Atten",
                column: "ReportsID");

            migrationBuilder.CreateIndex(
                name: "IX__Reports_Name",
                table: "_Reports",
                column: "Name");

            migrationBuilder.AddForeignKey(
                name: "FK__Reports_AspNetUsers_Name",
                table: "_Reports",
                column: "Name",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Atten__Reports_ReportsID",
                table: "Atten",
                column: "ReportsID",
                principalTable: "_Reports",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK__Reports_AspNetUsers_Name",
                table: "_Reports");

            migrationBuilder.DropForeignKey(
                name: "FK_Atten__Reports_ReportsID",
                table: "Atten");

            migrationBuilder.DropIndex(
                name: "IX_Atten_ReportsID",
                table: "Atten");

            migrationBuilder.DropIndex(
                name: "IX__Reports_Name",
                table: "_Reports");

            migrationBuilder.DropColumn(
                name: "ReportsID",
                table: "Atten");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "_Reports");
        }
    }
}

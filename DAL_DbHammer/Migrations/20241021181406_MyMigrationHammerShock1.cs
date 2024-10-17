using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL_DbHammer.Migrations
{
    public partial class MyMigrationHammerShock1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DateTimeCalib",
                table: "CalibInfo",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "path",
                table: "CalibInfo",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateTimeCalib",
                table: "CalibInfo");

            migrationBuilder.DropColumn(
                name: "path",
                table: "CalibInfo");
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL_DbHammer.Migrations
{
    public partial class MyMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ManufactureNames",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Manufacture = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ManufactureNames", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "masses",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    mass = table.Column<double>(nullable: false),
                    dimension = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_masses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "refAccelerometers",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Manufacture = table.Column<string>(nullable: false),
                    SerialNumber = table.Column<string>(nullable: true),
                    Model = table.Column<string>(nullable: false),
                    PulseTimeMs = table.Column<double>(nullable: false),
                    AmplitudeImpuls = table.Column<double>(nullable: false),
                    Сoefficient = table.Column<double>(nullable: false),
                    dimension = table.Column<string>(nullable: true),
                    TypeAcs = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_refAccelerometers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "samples",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    ManufactureId = table.Column<Guid>(nullable: true),
                    model = table.Column<string>(nullable: false),
                    LowLevelMeasurement = table.Column<int>(nullable: false),
                    HighLevelMeasurement = table.Column<int>(nullable: false),
                    Сoefficient = table.Column<double>(nullable: false),
                    dimension = table.Column<string>(nullable: true),
                    TypeHammer = table.Column<string>(nullable: true),
                    PermissibleCoefficientDeviation = table.Column<double>(nullable: false),
                    linearity = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_samples", x => x.Id);
                    table.ForeignKey(
                        name: "FK_samples_ManufactureNames_ManufactureId",
                        column: x => x.ManufactureId,
                        principalTable: "ManufactureNames",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CalibHummers",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    SerialNumber = table.Column<string>(nullable: true),
                    SampleId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CalibHummers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CalibHummers_samples_SampleId",
                        column: x => x.SampleId,
                        principalTable: "samples",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CalibInfo",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CalibHummerId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CalibInfo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CalibInfo_CalibHummers_CalibHummerId",
                        column: x => x.CalibHummerId,
                        principalTable: "CalibHummers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CalibHummers_SampleId",
                table: "CalibHummers",
                column: "SampleId");

            migrationBuilder.CreateIndex(
                name: "IX_CalibInfo_CalibHummerId",
                table: "CalibInfo",
                column: "CalibHummerId");

            migrationBuilder.CreateIndex(
                name: "IX_samples_ManufactureId",
                table: "samples",
                column: "ManufactureId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CalibInfo");

            migrationBuilder.DropTable(
                name: "masses");

            migrationBuilder.DropTable(
                name: "refAccelerometers");

            migrationBuilder.DropTable(
                name: "CalibHummers");

            migrationBuilder.DropTable(
                name: "samples");

            migrationBuilder.DropTable(
                name: "ManufactureNames");
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL_DbHammer.Migrations
{
    public partial class MigrationHammer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CalibHummers_samples_SampleId",
                table: "CalibHummers");

            migrationBuilder.DropForeignKey(
                name: "FK_CalibInfo_CalibHummers_CalibHummerId",
                table: "CalibInfo");

            migrationBuilder.DropIndex(
                name: "IX_CalibInfo_CalibHummerId",
                table: "CalibInfo");

            migrationBuilder.DropColumn(
                name: "CalibHummerId",
                table: "CalibInfo");

            migrationBuilder.DropColumn(
                name: "SerialNumber",
                table: "CalibHummers");

            migrationBuilder.RenameColumn(
                name: "SampleId",
                table: "CalibHummers",
                newName: "sampleId");

            migrationBuilder.RenameIndex(
                name: "IX_CalibHummers_SampleId",
                table: "CalibHummers",
                newName: "IX_CalibHummers_sampleId");

            migrationBuilder.AddColumn<Guid>(
                name: "calibHammerId",
                table: "CalibInfo",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SerialNumbers",
                table: "CalibHummers",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_CalibInfo_calibHammerId",
                table: "CalibInfo",
                column: "calibHammerId");

            migrationBuilder.AddForeignKey(
                name: "FK_CalibHummers_samples_sampleId",
                table: "CalibHummers",
                column: "sampleId",
                principalTable: "samples",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CalibInfo_CalibHummers_calibHammerId",
                table: "CalibInfo",
                column: "calibHammerId",
                principalTable: "CalibHummers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CalibHummers_samples_sampleId",
                table: "CalibHummers");

            migrationBuilder.DropForeignKey(
                name: "FK_CalibInfo_CalibHummers_calibHammerId",
                table: "CalibInfo");

            migrationBuilder.DropIndex(
                name: "IX_CalibInfo_calibHammerId",
                table: "CalibInfo");

            migrationBuilder.DropColumn(
                name: "calibHammerId",
                table: "CalibInfo");

            migrationBuilder.DropColumn(
                name: "SerialNumbers",
                table: "CalibHummers");

            migrationBuilder.RenameColumn(
                name: "sampleId",
                table: "CalibHummers",
                newName: "SampleId");

            migrationBuilder.RenameIndex(
                name: "IX_CalibHummers_sampleId",
                table: "CalibHummers",
                newName: "IX_CalibHummers_SampleId");

            migrationBuilder.AddColumn<Guid>(
                name: "CalibHummerId",
                table: "CalibInfo",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SerialNumber",
                table: "CalibHummers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_CalibInfo_CalibHummerId",
                table: "CalibInfo",
                column: "CalibHummerId");

            migrationBuilder.AddForeignKey(
                name: "FK_CalibHummers_samples_SampleId",
                table: "CalibHummers",
                column: "SampleId",
                principalTable: "samples",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CalibInfo_CalibHummers_CalibHummerId",
                table: "CalibInfo",
                column: "CalibHummerId",
                principalTable: "CalibHummers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

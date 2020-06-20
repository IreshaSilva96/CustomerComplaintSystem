using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CustomerComplaintSystem.Migrations
{
    public partial class ComplaintEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CategoryID",
                table: "AccountHolder");

            migrationBuilder.DropColumn(
                name: "ComplaintLoggedDate",
                table: "AccountHolder");

            migrationBuilder.DropColumn(
                name: "CustomerTypeID",
                table: "AccountHolder");

            migrationBuilder.DropColumn(
                name: "DateOfComplaint",
                table: "AccountHolder");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "AccountHolder");

            migrationBuilder.DropColumn(
                name: "StatusID",
                table: "AccountHolder");

            migrationBuilder.AddColumn<int>(
                name: "GenderID",
                table: "AccountHolder",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GenderID",
                table: "AccountHolder");

            migrationBuilder.AddColumn<int>(
                name: "CategoryID",
                table: "AccountHolder",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "ComplaintLoggedDate",
                table: "AccountHolder",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "CustomerTypeID",
                table: "AccountHolder",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfComplaint",
                table: "AccountHolder",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "AccountHolder",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StatusID",
                table: "AccountHolder",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}

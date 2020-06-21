using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CustomerComplaintSystem.Migrations
{
    public partial class AddToDatabase11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ComplainedDate",
                table: "Complaint");

            migrationBuilder.DropColumn(
                name: "ComplaintDate",
                table: "Complaint");

            migrationBuilder.DropColumn(
                name: "ConntactNumber",
                table: "Complaint");

            migrationBuilder.DropColumn(
                name: "CustomerTypeID",
                table: "Complaint");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Complaint",
                maxLength: 500,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "ComplaintStatus",
                table: "Complaint",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Branch",
                table: "Complaint",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<DateTime>(
                name: "ComplaintLoggedDate",
                table: "Complaint",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ContactNumber",
                table: "Complaint",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CustomerType",
                table: "Complaint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfComplaint",
                table: "Complaint",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Complaint",
                maxLength: 50,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ComplaintLoggedDate",
                table: "Complaint");

            migrationBuilder.DropColumn(
                name: "ContactNumber",
                table: "Complaint");

            migrationBuilder.DropColumn(
                name: "CustomerType",
                table: "Complaint");

            migrationBuilder.DropColumn(
                name: "DateOfComplaint",
                table: "Complaint");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Complaint");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Complaint",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 500);

            migrationBuilder.AlterColumn<int>(
                name: "ComplaintStatus",
                table: "Complaint",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Branch",
                table: "Complaint",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ComplainedDate",
                table: "Complaint",
                type: "datetime2",
                maxLength: 20,
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "ComplaintDate",
                table: "Complaint",
                type: "datetime2",
                maxLength: 20,
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ConntactNumber",
                table: "Complaint",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "CustomerTypeID",
                table: "Complaint",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}

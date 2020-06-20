using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CustomerComplaintSystem.Migrations
{
    public partial class complaintEtityadd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Complaint",
                columns: table => new
                {
                    AccountHolderID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(maxLength: 20, nullable: false),
                    LastName = table.Column<string>(maxLength: 20, nullable: false),
                    NIC = table.Column<string>(maxLength: 20, nullable: true),
                    ContactNumber = table.Column<int>(maxLength: 20, nullable: false),
                    Address = table.Column<string>(maxLength: 50, nullable: true),
                    Email = table.Column<string>(maxLength: 30, nullable: true),
                    Description = table.Column<string>(maxLength: 500, nullable: true),
                    DateOfComplaint = table.Column<DateTime>(nullable: false),
                    ComplaintLoggedDate = table.Column<DateTime>(nullable: false),
                    CustomerTypeID = table.Column<int>(nullable: false),
                    AccountID = table.Column<int>(nullable: false),
                    CategoryID = table.Column<int>(nullable: false),
                    StatusID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Complaint", x => x.AccountHolderID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Complaint");
        }
    }
}

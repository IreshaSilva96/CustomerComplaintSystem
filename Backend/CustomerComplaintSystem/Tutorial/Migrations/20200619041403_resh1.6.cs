using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CustomerComplaintSystem.Migrations
{
    public partial class resh16 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Complaint");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Complaint",
                columns: table => new
                {
                    ComplaintID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccountHolder = table.Column<int>(type: "int", nullable: true),
                    AccountHolderID = table.Column<int>(type: "int", nullable: false),
                    AccountID = table.Column<int>(type: "int", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    BranchID = table.Column<int>(type: "int", nullable: false),
                    CategoryID = table.Column<int>(type: "int", nullable: false),
                    ComplaintLoggedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ComplaintStatusID = table.Column<int>(type: "int", nullable: false),
                    ContactNumber = table.Column<int>(type: "int", maxLength: 20, nullable: false),
                    CustomerTypeID = table.Column<int>(type: "int", nullable: false),
                    DateOfComplaint = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    NIC = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Complaint", x => x.ComplaintID);
                    table.ForeignKey(
                        name: "FK_Complaint_AccountHolder_AccountHolder",
                        column: x => x.AccountHolder,
                        principalTable: "AccountHolder",
                        principalColumn: "AccountHolderID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Complaint_Account_AccountID",
                        column: x => x.AccountID,
                        principalTable: "Account",
                        principalColumn: "AccountID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Complaint_Branch_BranchID",
                        column: x => x.BranchID,
                        principalTable: "Branch",
                        principalColumn: "BranchID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Complaint_CategoryOfComplaint_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "CategoryOfComplaint",
                        principalColumn: "CategoryOfComplaintID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Complaint_ComplaintStatus_ComplaintStatusID",
                        column: x => x.ComplaintStatusID,
                        principalTable: "ComplaintStatus",
                        principalColumn: "ComplaintStatusID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Complaint_CustomerType_CustomerTypeID",
                        column: x => x.CustomerTypeID,
                        principalTable: "CustomerType",
                        principalColumn: "CustomerTypeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Complaint_AccountHolder",
                table: "Complaint",
                column: "AccountHolder");

            migrationBuilder.CreateIndex(
                name: "IX_Complaint_AccountID",
                table: "Complaint",
                column: "AccountID");

            migrationBuilder.CreateIndex(
                name: "IX_Complaint_BranchID",
                table: "Complaint",
                column: "BranchID");

            migrationBuilder.CreateIndex(
                name: "IX_Complaint_CategoryID",
                table: "Complaint",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Complaint_ComplaintStatusID",
                table: "Complaint",
                column: "ComplaintStatusID");

            migrationBuilder.CreateIndex(
                name: "IX_Complaint_CustomerTypeID",
                table: "Complaint",
                column: "CustomerTypeID");
        }
    }
}

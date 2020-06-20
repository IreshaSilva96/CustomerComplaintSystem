using Microsoft.EntityFrameworkCore.Migrations;

namespace CustomerComplaintSystem.Migrations
{
    public partial class resh14 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AccountHolder",
                table: "Complaint",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AccountHolderID",
                table: "Complaint",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AccountID",
                table: "Complaint",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BranchID",
                table: "Complaint",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CategoryID",
                table: "Complaint",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ComplaintStatusID",
                table: "Complaint",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CustomerTypeID",
                table: "Complaint",
                nullable: false,
                defaultValue: 0);

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

            migrationBuilder.AddForeignKey(
                name: "FK_Complaint_AccountHolder_AccountHolder",
                table: "Complaint",
                column: "AccountHolder",
                principalTable: "AccountHolder",
                principalColumn: "AccountHolderID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Complaint_Account_AccountID",
                table: "Complaint",
                column: "AccountID",
                principalTable: "Account",
                principalColumn: "AccountID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Complaint_Branch_BranchID",
                table: "Complaint",
                column: "BranchID",
                principalTable: "Branch",
                principalColumn: "BranchID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Complaint_CategoryOfComplaint_CategoryID",
                table: "Complaint",
                column: "CategoryID",
                principalTable: "CategoryOfComplaint",
                principalColumn: "CategoryOfComplaintID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Complaint_ComplaintStatus_ComplaintStatusID",
                table: "Complaint",
                column: "ComplaintStatusID",
                principalTable: "ComplaintStatus",
                principalColumn: "ComplaintStatusID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Complaint_CustomerType_CustomerTypeID",
                table: "Complaint",
                column: "CustomerTypeID",
                principalTable: "CustomerType",
                principalColumn: "CustomerTypeID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Complaint_AccountHolder_AccountHolder",
                table: "Complaint");

            migrationBuilder.DropForeignKey(
                name: "FK_Complaint_Account_AccountID",
                table: "Complaint");

            migrationBuilder.DropForeignKey(
                name: "FK_Complaint_Branch_BranchID",
                table: "Complaint");

            migrationBuilder.DropForeignKey(
                name: "FK_Complaint_CategoryOfComplaint_CategoryID",
                table: "Complaint");

            migrationBuilder.DropForeignKey(
                name: "FK_Complaint_ComplaintStatus_ComplaintStatusID",
                table: "Complaint");

            migrationBuilder.DropForeignKey(
                name: "FK_Complaint_CustomerType_CustomerTypeID",
                table: "Complaint");

            migrationBuilder.DropIndex(
                name: "IX_Complaint_AccountHolder",
                table: "Complaint");

            migrationBuilder.DropIndex(
                name: "IX_Complaint_AccountID",
                table: "Complaint");

            migrationBuilder.DropIndex(
                name: "IX_Complaint_BranchID",
                table: "Complaint");

            migrationBuilder.DropIndex(
                name: "IX_Complaint_CategoryID",
                table: "Complaint");

            migrationBuilder.DropIndex(
                name: "IX_Complaint_ComplaintStatusID",
                table: "Complaint");

            migrationBuilder.DropIndex(
                name: "IX_Complaint_CustomerTypeID",
                table: "Complaint");

            migrationBuilder.DropColumn(
                name: "AccountHolder",
                table: "Complaint");

            migrationBuilder.DropColumn(
                name: "AccountHolderID",
                table: "Complaint");

            migrationBuilder.DropColumn(
                name: "AccountID",
                table: "Complaint");

            migrationBuilder.DropColumn(
                name: "BranchID",
                table: "Complaint");

            migrationBuilder.DropColumn(
                name: "CategoryID",
                table: "Complaint");

            migrationBuilder.DropColumn(
                name: "ComplaintStatusID",
                table: "Complaint");

            migrationBuilder.DropColumn(
                name: "CustomerTypeID",
                table: "Complaint");
        }
    }
}

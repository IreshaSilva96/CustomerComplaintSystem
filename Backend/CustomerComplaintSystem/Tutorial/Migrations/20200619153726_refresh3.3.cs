using Microsoft.EntityFrameworkCore.Migrations;

namespace CustomerComplaintSystem.Migrations
{
    public partial class refresh33 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ConntactNumber",
                table: "Complaint");

            migrationBuilder.AddColumn<int>(
                name: "AccountID",
                table: "Complaint",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AgentID",
                table: "Complaint",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BranchID",
                table: "Complaint",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CategoryOfComplaintID",
                table: "Complaint",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ComplaintStatusID",
                table: "Complaint",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ContactNumber",
                table: "Complaint",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "CustomerTypeID",
                table: "Complaint",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "GenderID",
                table: "Complaint",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NatureOfComplaintID",
                table: "Agent",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Complaint_AccountID",
                table: "Complaint",
                column: "AccountID");

            migrationBuilder.CreateIndex(
                name: "IX_Complaint_AgentID",
                table: "Complaint",
                column: "AgentID");

            migrationBuilder.CreateIndex(
                name: "IX_Complaint_BranchID",
                table: "Complaint",
                column: "BranchID");

            migrationBuilder.CreateIndex(
                name: "IX_Complaint_CategoryOfComplaintID",
                table: "Complaint",
                column: "CategoryOfComplaintID");

            migrationBuilder.CreateIndex(
                name: "IX_Complaint_ComplaintStatusID",
                table: "Complaint",
                column: "ComplaintStatusID");

            migrationBuilder.CreateIndex(
                name: "IX_Complaint_CustomerTypeID",
                table: "Complaint",
                column: "CustomerTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Complaint_GenderID",
                table: "Complaint",
                column: "GenderID");

            migrationBuilder.CreateIndex(
                name: "IX_Agent_NatureOfComplaintID",
                table: "Agent",
                column: "NatureOfComplaintID");

            migrationBuilder.AddForeignKey(
                name: "FK_Agent_NatureOfComplaint_NatureOfComplaintID",
                table: "Agent",
                column: "NatureOfComplaintID",
                principalTable: "NatureOfComplaint",
                principalColumn: "NatureOfComplaintID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Complaint_Account_AccountID",
                table: "Complaint",
                column: "AccountID",
                principalTable: "Account",
                principalColumn: "AccountID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Complaint_Agent_AgentID",
                table: "Complaint",
                column: "AgentID",
                principalTable: "Agent",
                principalColumn: "AgentID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Complaint_Branch_BranchID",
                table: "Complaint",
                column: "BranchID",
                principalTable: "Branch",
                principalColumn: "BranchID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Complaint_CategoryOfComplaint_CategoryOfComplaintID",
                table: "Complaint",
                column: "CategoryOfComplaintID",
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

            migrationBuilder.AddForeignKey(
                name: "FK_Complaint_Gender_GenderID",
                table: "Complaint",
                column: "GenderID",
                principalTable: "Gender",
                principalColumn: "GenderID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Agent_NatureOfComplaint_NatureOfComplaintID",
                table: "Agent");

            migrationBuilder.DropForeignKey(
                name: "FK_Complaint_Account_AccountID",
                table: "Complaint");

            migrationBuilder.DropForeignKey(
                name: "FK_Complaint_Agent_AgentID",
                table: "Complaint");

            migrationBuilder.DropForeignKey(
                name: "FK_Complaint_Branch_BranchID",
                table: "Complaint");

            migrationBuilder.DropForeignKey(
                name: "FK_Complaint_CategoryOfComplaint_CategoryOfComplaintID",
                table: "Complaint");

            migrationBuilder.DropForeignKey(
                name: "FK_Complaint_ComplaintStatus_ComplaintStatusID",
                table: "Complaint");

            migrationBuilder.DropForeignKey(
                name: "FK_Complaint_CustomerType_CustomerTypeID",
                table: "Complaint");

            migrationBuilder.DropForeignKey(
                name: "FK_Complaint_Gender_GenderID",
                table: "Complaint");

            migrationBuilder.DropIndex(
                name: "IX_Complaint_AccountID",
                table: "Complaint");

            migrationBuilder.DropIndex(
                name: "IX_Complaint_AgentID",
                table: "Complaint");

            migrationBuilder.DropIndex(
                name: "IX_Complaint_BranchID",
                table: "Complaint");

            migrationBuilder.DropIndex(
                name: "IX_Complaint_CategoryOfComplaintID",
                table: "Complaint");

            migrationBuilder.DropIndex(
                name: "IX_Complaint_ComplaintStatusID",
                table: "Complaint");

            migrationBuilder.DropIndex(
                name: "IX_Complaint_CustomerTypeID",
                table: "Complaint");

            migrationBuilder.DropIndex(
                name: "IX_Complaint_GenderID",
                table: "Complaint");

            migrationBuilder.DropIndex(
                name: "IX_Agent_NatureOfComplaintID",
                table: "Agent");

            migrationBuilder.DropColumn(
                name: "AccountID",
                table: "Complaint");

            migrationBuilder.DropColumn(
                name: "AgentID",
                table: "Complaint");

            migrationBuilder.DropColumn(
                name: "BranchID",
                table: "Complaint");

            migrationBuilder.DropColumn(
                name: "CategoryOfComplaintID",
                table: "Complaint");

            migrationBuilder.DropColumn(
                name: "ComplaintStatusID",
                table: "Complaint");

            migrationBuilder.DropColumn(
                name: "ContactNumber",
                table: "Complaint");

            migrationBuilder.DropColumn(
                name: "CustomerTypeID",
                table: "Complaint");

            migrationBuilder.DropColumn(
                name: "GenderID",
                table: "Complaint");

            migrationBuilder.DropColumn(
                name: "NatureOfComplaintID",
                table: "Agent");

            migrationBuilder.AddColumn<string>(
                name: "ConntactNumber",
                table: "Complaint",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");
        }
    }
}

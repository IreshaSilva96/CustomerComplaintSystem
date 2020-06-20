using Microsoft.EntityFrameworkCore.Migrations;

namespace CustomerComplaintSystem.Migrations
{
    public partial class resh12 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GenderID",
                table: "Employee");

            migrationBuilder.CreateIndex(
                name: "IX_ProductAndService_CategoryOfComplaintID",
                table: "ProductAndService",
                column: "CategoryOfComplaintID");

            migrationBuilder.CreateIndex(
                name: "IX_NatureOfComplaint_ProductAndServiceID",
                table: "NatureOfComplaint",
                column: "ProductAndServiceID");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_BranchID",
                table: "Employee",
                column: "BranchID");

            migrationBuilder.CreateIndex(
                name: "IX_ComplaintStatus_AgentID",
                table: "ComplaintStatus",
                column: "AgentID");

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

            migrationBuilder.CreateIndex(
                name: "IX_Complaint_GenderID",
                table: "Complaint",
                column: "GenderID");

            migrationBuilder.CreateIndex(
                name: "IX_Agent_AgentTypeID",
                table: "Agent",
                column: "AgentTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Agent_EmployeeID",
                table: "Agent",
                column: "EmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_AccountHolder_AccountID",
                table: "AccountHolder",
                column: "AccountID");

            migrationBuilder.CreateIndex(
                name: "IX_AccountHolder_GenderID",
                table: "AccountHolder",
                column: "GenderID");

            migrationBuilder.CreateIndex(
                name: "IX_Account_AccountHolderID",
                table: "Account",
                column: "AccountHolderID");

            migrationBuilder.CreateIndex(
                name: "IX_Account_AccountTypeID",
                table: "Account",
                column: "AccountTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Account_BranchID",
                table: "Account",
                column: "BranchID");

            migrationBuilder.AddForeignKey(
                name: "FK_Account_AccountHolder_AccountHolderID",
                table: "Account",
                column: "AccountHolderID",
                principalTable: "AccountHolder",
                principalColumn: "AccountHolderID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Account_Account_AccountTypeID",
                table: "Account",
                column: "AccountTypeID",
                principalTable: "Account",
                principalColumn: "AccountID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Account_Branch_BranchID",
                table: "Account",
                column: "BranchID",
                principalTable: "Branch",
                principalColumn: "BranchID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AccountHolder_Account_AccountID",
                table: "AccountHolder",
                column: "AccountID",
                principalTable: "Account",
                principalColumn: "AccountID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AccountHolder_Gender_GenderID",
                table: "AccountHolder",
                column: "GenderID",
                principalTable: "Gender",
                principalColumn: "GenderID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Agent_Agent_AgentTypeID",
                table: "Agent",
                column: "AgentTypeID",
                principalTable: "Agent",
                principalColumn: "AgentID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Agent_Employee_EmployeeID",
                table: "Agent",
                column: "EmployeeID",
                principalTable: "Employee",
                principalColumn: "EmployeeID",
                onDelete: ReferentialAction.Cascade);

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

            migrationBuilder.AddForeignKey(
                name: "FK_Complaint_Gender_GenderID",
                table: "Complaint",
                column: "GenderID",
                principalTable: "Gender",
                principalColumn: "GenderID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ComplaintStatus_Agent_AgentID",
                table: "ComplaintStatus",
                column: "AgentID",
                principalTable: "Agent",
                principalColumn: "AgentID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_Branch_BranchID",
                table: "Employee",
                column: "BranchID",
                principalTable: "Branch",
                principalColumn: "BranchID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_NatureOfComplaint_ProductAndService_ProductAndServiceID",
                table: "NatureOfComplaint",
                column: "ProductAndServiceID",
                principalTable: "ProductAndService",
                principalColumn: "ProductAndServiceID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductAndService_CategoryOfComplaint_CategoryOfComplaintID",
                table: "ProductAndService",
                column: "CategoryOfComplaintID",
                principalTable: "CategoryOfComplaint",
                principalColumn: "CategoryOfComplaintID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Account_AccountHolder_AccountHolderID",
                table: "Account");

            migrationBuilder.DropForeignKey(
                name: "FK_Account_Account_AccountTypeID",
                table: "Account");

            migrationBuilder.DropForeignKey(
                name: "FK_Account_Branch_BranchID",
                table: "Account");

            migrationBuilder.DropForeignKey(
                name: "FK_AccountHolder_Account_AccountID",
                table: "AccountHolder");

            migrationBuilder.DropForeignKey(
                name: "FK_AccountHolder_Gender_GenderID",
                table: "AccountHolder");

            migrationBuilder.DropForeignKey(
                name: "FK_Agent_Agent_AgentTypeID",
                table: "Agent");

            migrationBuilder.DropForeignKey(
                name: "FK_Agent_Employee_EmployeeID",
                table: "Agent");

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

            migrationBuilder.DropForeignKey(
                name: "FK_Complaint_Gender_GenderID",
                table: "Complaint");

            migrationBuilder.DropForeignKey(
                name: "FK_ComplaintStatus_Agent_AgentID",
                table: "ComplaintStatus");

            migrationBuilder.DropForeignKey(
                name: "FK_Employee_Branch_BranchID",
                table: "Employee");

            migrationBuilder.DropForeignKey(
                name: "FK_NatureOfComplaint_ProductAndService_ProductAndServiceID",
                table: "NatureOfComplaint");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductAndService_CategoryOfComplaint_CategoryOfComplaintID",
                table: "ProductAndService");

            migrationBuilder.DropIndex(
                name: "IX_ProductAndService_CategoryOfComplaintID",
                table: "ProductAndService");

            migrationBuilder.DropIndex(
                name: "IX_NatureOfComplaint_ProductAndServiceID",
                table: "NatureOfComplaint");

            migrationBuilder.DropIndex(
                name: "IX_Employee_BranchID",
                table: "Employee");

            migrationBuilder.DropIndex(
                name: "IX_ComplaintStatus_AgentID",
                table: "ComplaintStatus");

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

            migrationBuilder.DropIndex(
                name: "IX_Complaint_GenderID",
                table: "Complaint");

            migrationBuilder.DropIndex(
                name: "IX_Agent_AgentTypeID",
                table: "Agent");

            migrationBuilder.DropIndex(
                name: "IX_Agent_EmployeeID",
                table: "Agent");

            migrationBuilder.DropIndex(
                name: "IX_AccountHolder_AccountID",
                table: "AccountHolder");

            migrationBuilder.DropIndex(
                name: "IX_AccountHolder_GenderID",
                table: "AccountHolder");

            migrationBuilder.DropIndex(
                name: "IX_Account_AccountHolderID",
                table: "Account");

            migrationBuilder.DropIndex(
                name: "IX_Account_AccountTypeID",
                table: "Account");

            migrationBuilder.DropIndex(
                name: "IX_Account_BranchID",
                table: "Account");

            migrationBuilder.AddColumn<int>(
                name: "GenderID",
                table: "Employee",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}

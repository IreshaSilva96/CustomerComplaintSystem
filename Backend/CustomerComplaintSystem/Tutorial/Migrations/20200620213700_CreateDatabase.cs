using Microsoft.EntityFrameworkCore.Migrations;

namespace CustomerComplaintSystem.Migrations
{
    public partial class CreateDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AccountHolder_Gender_GenderID",
                table: "AccountHolder");

            migrationBuilder.DropForeignKey(
                name: "FK_Complaint_Agent_AgentID",
                table: "Complaint");

            migrationBuilder.DropForeignKey(
                name: "FK_Complaint_Branch_BranchID",
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

            migrationBuilder.DropTable(
                name: "Gender");

            migrationBuilder.DropIndex(
                name: "IX_Complaint_AgentID",
                table: "Complaint");

            migrationBuilder.DropIndex(
                name: "IX_Complaint_BranchID",
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
                name: "IX_AccountHolder_GenderID",
                table: "AccountHolder");

            migrationBuilder.DropColumn(
                name: "AgentID",
                table: "Complaint");

            migrationBuilder.DropColumn(
                name: "BranchID",
                table: "Complaint");

            migrationBuilder.DropColumn(
                name: "ComplaintStatusID",
                table: "Complaint");

            migrationBuilder.DropColumn(
                name: "ContactNumber",
                table: "Complaint");

            migrationBuilder.DropColumn(
                name: "GenderID",
                table: "Complaint");

            migrationBuilder.DropColumn(
                name: "GenderID",
                table: "AccountHolder");

            migrationBuilder.AddColumn<int>(
                name: "Branch",
                table: "Complaint",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ComplaintStatus",
                table: "Complaint",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ConntactNumber",
                table: "Complaint",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "AccountNumber",
                table: "Account",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Branch",
                table: "Complaint");

            migrationBuilder.DropColumn(
                name: "ComplaintStatus",
                table: "Complaint");

            migrationBuilder.DropColumn(
                name: "ConntactNumber",
                table: "Complaint");

            migrationBuilder.DropColumn(
                name: "AccountNumber",
                table: "Account");

            migrationBuilder.AddColumn<int>(
                name: "AgentID",
                table: "Complaint",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BranchID",
                table: "Complaint",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ComplaintStatusID",
                table: "Complaint",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ContactNumber",
                table: "Complaint",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "GenderID",
                table: "Complaint",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "GenderID",
                table: "AccountHolder",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Gender",
                columns: table => new
                {
                    GenderID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GenderName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gender", x => x.GenderID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Complaint_AgentID",
                table: "Complaint",
                column: "AgentID");

            migrationBuilder.CreateIndex(
                name: "IX_Complaint_BranchID",
                table: "Complaint",
                column: "BranchID");

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
                name: "IX_AccountHolder_GenderID",
                table: "AccountHolder",
                column: "GenderID");

            migrationBuilder.AddForeignKey(
                name: "FK_AccountHolder_Gender_GenderID",
                table: "AccountHolder",
                column: "GenderID",
                principalTable: "Gender",
                principalColumn: "GenderID",
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
    }
}

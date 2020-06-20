using Microsoft.EntityFrameworkCore.Migrations;

namespace CustomerComplaintSystem.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Account_Account_AccountTypeID",
                table: "Account");

            migrationBuilder.DropForeignKey(
                name: "FK_AccountHolder_Account_AccountID",
                table: "AccountHolder");

            migrationBuilder.DropForeignKey(
                name: "FK_Agent_Agent_AgentTypeID",
                table: "Agent");

            migrationBuilder.DropIndex(
                name: "IX_AccountHolder_AccountID",
                table: "AccountHolder");

            migrationBuilder.DropColumn(
                name: "AccountID",
                table: "AccountHolder");

            migrationBuilder.AddForeignKey(
                name: "FK_Account_AccountType_AccountTypeID",
                table: "Account",
                column: "AccountTypeID",
                principalTable: "AccountType",
                principalColumn: "AccountTypeID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Agent_AgentType_AgentTypeID",
                table: "Agent",
                column: "AgentTypeID",
                principalTable: "AgentType",
                principalColumn: "AgentTypeID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Account_AccountType_AccountTypeID",
                table: "Account");

            migrationBuilder.DropForeignKey(
                name: "FK_Agent_AgentType_AgentTypeID",
                table: "Agent");

            migrationBuilder.AddColumn<int>(
                name: "AccountID",
                table: "AccountHolder",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_AccountHolder_AccountID",
                table: "AccountHolder",
                column: "AccountID");

            migrationBuilder.AddForeignKey(
                name: "FK_Account_Account_AccountTypeID",
                table: "Account",
                column: "AccountTypeID",
                principalTable: "Account",
                principalColumn: "AccountID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AccountHolder_Account_AccountID",
                table: "AccountHolder",
                column: "AccountID",
                principalTable: "Account",
                principalColumn: "AccountID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Agent_Agent_AgentTypeID",
                table: "Agent",
                column: "AgentTypeID",
                principalTable: "Agent",
                principalColumn: "AgentID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

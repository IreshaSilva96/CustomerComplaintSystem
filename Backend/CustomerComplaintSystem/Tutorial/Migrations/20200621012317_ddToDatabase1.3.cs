using Microsoft.EntityFrameworkCore.Migrations;

namespace CustomerComplaintSystem.Migrations
{
    public partial class ddToDatabase13 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Complaint_Account_AccountID",
                table: "Complaint");

            migrationBuilder.DropIndex(
                name: "IX_Complaint_AccountID",
                table: "Complaint");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Complaint_AccountID",
                table: "Complaint",
                column: "AccountID");

            migrationBuilder.AddForeignKey(
                name: "FK_Complaint_Account_AccountID",
                table: "Complaint",
                column: "AccountID",
                principalTable: "Account",
                principalColumn: "AccountID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace CustomerComplaintSystem.Migrations
{
    public partial class refresh32 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ComplaintStatus_Agent_AgentID",
                table: "ComplaintStatus");

            migrationBuilder.DropIndex(
                name: "IX_ComplaintStatus_AgentID",
                table: "ComplaintStatus");

            migrationBuilder.DropColumn(
                name: "AgentID",
                table: "ComplaintStatus");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AgentID",
                table: "ComplaintStatus",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_ComplaintStatus_AgentID",
                table: "ComplaintStatus",
                column: "AgentID");

            migrationBuilder.AddForeignKey(
                name: "FK_ComplaintStatus_Agent_AgentID",
                table: "ComplaintStatus",
                column: "AgentID",
                principalTable: "Agent",
                principalColumn: "AgentID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

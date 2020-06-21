using Microsoft.EntityFrameworkCore.Migrations;

namespace CustomerComplaintSystem.Migrations
{
    public partial class ddToDatabase15 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Complaint_NatureOfComplaint_NatureOfComplaintID",
                table: "Complaint");

            migrationBuilder.DropForeignKey(
                name: "FK_Complaint_ProductAndService_ProductAndServiceID",
                table: "Complaint");

            migrationBuilder.DropIndex(
                name: "IX_Complaint_NatureOfComplaintID",
                table: "Complaint");

            migrationBuilder.DropIndex(
                name: "IX_Complaint_ProductAndServiceID",
                table: "Complaint");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Complaint_NatureOfComplaintID",
                table: "Complaint",
                column: "NatureOfComplaintID");

            migrationBuilder.CreateIndex(
                name: "IX_Complaint_ProductAndServiceID",
                table: "Complaint",
                column: "ProductAndServiceID");

            migrationBuilder.AddForeignKey(
                name: "FK_Complaint_NatureOfComplaint_NatureOfComplaintID",
                table: "Complaint",
                column: "NatureOfComplaintID",
                principalTable: "NatureOfComplaint",
                principalColumn: "NatureOfComplaintID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Complaint_ProductAndService_ProductAndServiceID",
                table: "Complaint",
                column: "ProductAndServiceID",
                principalTable: "ProductAndService",
                principalColumn: "ProductAndServiceID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

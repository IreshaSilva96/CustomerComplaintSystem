using Microsoft.EntityFrameworkCore.Migrations;

namespace CustomerComplaintSystem.Migrations
{
    public partial class Refresh : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Complaint",
                table: "Complaint");

            migrationBuilder.AddColumn<int>(
                name: "GenderID",
                table: "Employee",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "AccountHolderID",
                table: "Complaint",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "ComplaintID",
                table: "Complaint",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "GenderID",
                table: "Complaint",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Complaint",
                table: "Complaint",
                column: "ComplaintID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Complaint",
                table: "Complaint");

            migrationBuilder.DropColumn(
                name: "GenderID",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "ComplaintID",
                table: "Complaint");

            migrationBuilder.DropColumn(
                name: "GenderID",
                table: "Complaint");

            migrationBuilder.AlterColumn<int>(
                name: "AccountHolderID",
                table: "Complaint",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldMaxLength: 30)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Complaint",
                table: "Complaint",
                column: "AccountHolderID");
        }
    }
}

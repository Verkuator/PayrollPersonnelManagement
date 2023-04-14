using Microsoft.EntityFrameworkCore.Migrations;

namespace PayrollPersonnelManagement.Infasrtucture.Migrations
{
    public partial class AddIsDelete : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "Subdivision",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "Post",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "PhisicalFace",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "OneAccrual",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "Employee",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "Subdivision");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "Post");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "PhisicalFace");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "OneAccrual");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "Employee");
        }
    }
}

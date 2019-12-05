using Microsoft.EntityFrameworkCore.Migrations;

namespace ManagementApp.Data.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PermissionID",
                table: "Permissions");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Permissions",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Permissions");

            migrationBuilder.AddColumn<int>(
                name: "PermissionID",
                table: "Permissions",
                nullable: false,
                defaultValue: 0);
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace MyOwnApp.Migrations
{
    public partial class edittableUserProfile : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AboutMe",
                table: "tbl_UserProfiles");

            migrationBuilder.DropColumn(
                name: "Age",
                table: "tbl_UserProfiles");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AboutMe",
                table: "tbl_UserProfiles",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Age",
                table: "tbl_UserProfiles",
                nullable: false,
                defaultValue: 0);
        }
    }
}

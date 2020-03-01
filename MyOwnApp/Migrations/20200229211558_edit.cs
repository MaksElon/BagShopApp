using Microsoft.EntityFrameworkCore.Migrations;

namespace MyOwnApp.Migrations
{
    public partial class edit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AvailableCount",
                table: "tbl_Product",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AvailableCount",
                table: "tbl_Product");
        }
    }
}

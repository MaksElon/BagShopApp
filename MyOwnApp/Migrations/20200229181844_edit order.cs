using Microsoft.EntityFrameworkCore.Migrations;

namespace MyOwnApp.Migrations
{
    public partial class editorder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "tbl_Orders");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "tbl_Orders");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "tbl_Orders");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "tbl_Orders");

            migrationBuilder.DropColumn(
                name: "Phone",
                table: "tbl_Orders");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "tbl_Orders",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "tbl_Orders",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "tbl_Orders",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "tbl_Orders",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "tbl_Orders",
                nullable: true);
        }
    }
}

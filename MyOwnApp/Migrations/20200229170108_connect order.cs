using Microsoft.EntityFrameworkCore.Migrations;

namespace MyOwnApp.Migrations
{
    public partial class connectorder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "tbl_Orders",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "FileModels",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Path = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FileModels", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Orders_UserId",
                table: "tbl_Orders",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Orders_AspNetUsers_UserId",
                table: "tbl_Orders",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Orders_AspNetUsers_UserId",
                table: "tbl_Orders");

            migrationBuilder.DropTable(
                name: "FileModels");

            migrationBuilder.DropIndex(
                name: "IX_tbl_Orders_UserId",
                table: "tbl_Orders");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "tbl_Orders");
        }
    }
}

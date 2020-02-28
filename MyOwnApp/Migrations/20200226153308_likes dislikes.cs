using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyOwnApp.Migrations
{
    public partial class likesdislikes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Dislikes",
                table: "tbl_Product");

            migrationBuilder.DropColumn(
                name: "Likes",
                table: "tbl_Product");

            migrationBuilder.CreateTable(
                name: "tbl_Dislikes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ProductId = table.Column<int>(nullable: false),
                    UserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Dislikes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_Dislikes_tbl_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "tbl_Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tbl_Dislikes_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "tbl_Likes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ProductId = table.Column<int>(nullable: false),
                    UserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Likes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_Likes_tbl_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "tbl_Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tbl_Likes_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Dislikes_ProductId",
                table: "tbl_Dislikes",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Dislikes_UserId",
                table: "tbl_Dislikes",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Likes_ProductId",
                table: "tbl_Likes",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Likes_UserId",
                table: "tbl_Likes",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbl_Dislikes");

            migrationBuilder.DropTable(
                name: "tbl_Likes");

            migrationBuilder.AddColumn<int>(
                name: "Dislikes",
                table: "tbl_Product",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Likes",
                table: "tbl_Product",
                nullable: false,
                defaultValue: 0);
        }
    }
}

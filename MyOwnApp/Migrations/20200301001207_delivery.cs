using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyOwnApp.Migrations
{
    public partial class delivery : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DeliveryId",
                table: "tbl_Orders",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "tbl_Deliveries",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Price = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Deliveries", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Orders_DeliveryId",
                table: "tbl_Orders",
                column: "DeliveryId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Orders_tbl_Deliveries_DeliveryId",
                table: "tbl_Orders",
                column: "DeliveryId",
                principalTable: "tbl_Deliveries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Orders_tbl_Deliveries_DeliveryId",
                table: "tbl_Orders");

            migrationBuilder.DropTable(
                name: "tbl_Deliveries");

            migrationBuilder.DropIndex(
                name: "IX_tbl_Orders_DeliveryId",
                table: "tbl_Orders");

            migrationBuilder.DropColumn(
                name: "DeliveryId",
                table: "tbl_Orders");
        }
    }
}

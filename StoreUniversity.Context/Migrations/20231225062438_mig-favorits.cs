using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StoreUniversity.Context.Migrations
{
    /// <inheritdoc />
    public partial class migfavorits : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Favorits",
                columns: table => new
                {
                    UserFavoritId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Favorits", x => x.UserFavoritId);
                    table.ForeignKey(
                        name: "FK_Favorits_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Favorits_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Favorits_ProductId",
                table: "Favorits",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Favorits_UserId",
                table: "Favorits",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Favorits");
        }
    }
}

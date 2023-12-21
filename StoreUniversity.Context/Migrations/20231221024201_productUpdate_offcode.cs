using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StoreUniversity.Context.Migrations
{
    /// <inheritdoc />
    public partial class productUpdate_offcode : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Offcodes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Percent = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Offcodes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductsTOOffcodes",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    OffCodeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductsTOOffcodes", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ProductsTOOffcodes_Offcodes_OffCodeId",
                        column: x => x.OffCodeId,
                        principalTable: "Offcodes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductsTOOffcodes_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductsTOOffcodes_OffCodeId",
                table: "ProductsTOOffcodes",
                column: "OffCodeId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductsTOOffcodes_ProductId",
                table: "ProductsTOOffcodes",
                column: "ProductId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductsTOOffcodes");

            migrationBuilder.DropTable(
                name: "Offcodes");

            migrationBuilder.DropColumn(
                name: "Image",
                table: "Products");
        }
    }
}

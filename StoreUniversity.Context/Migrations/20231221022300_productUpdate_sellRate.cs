using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StoreUniversity.Context.Migrations
{
    /// <inheritdoc />
    public partial class productUpdate_sellRate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SellRate",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SellRate",
                table: "Products");
        }
    }
}

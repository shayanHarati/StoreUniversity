using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StoreUniversity.Context.Migrations
{
    /// <inheritdoc />
    public partial class OffCodeUpdated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Offcodes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Offcodes");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace Oasis.Migrations
{
    public partial class UpdatedShoppingCart : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "ShoppingCart",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ItemDescription",
                table: "ShoppingCart",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Price",
                table: "ShoppingCart",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "ShoppingCart");

            migrationBuilder.DropColumn(
                name: "ItemDescription",
                table: "ShoppingCart");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "ShoppingCart");
        }
    }
}
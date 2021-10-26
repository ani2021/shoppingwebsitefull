using Microsoft.EntityFrameworkCore.Migrations;

namespace Oasis.Migrations
{
	public partial class ItemTracker : Migration
	{
		protected override void Up(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.CreateTable(
					name: "ItemsTracker",
					columns: table => new
					{
						Id = table.Column<int>(nullable: false)
									.Annotation("Sqlite:Autoincrement", true),
						TotalViewed = table.Column<int>(nullable: false),
						TotalPurchased = table.Column<int>(nullable: false),
						ItemName = table.Column<string>(nullable: true)
					},
					constraints: table =>
					{
						table.PrimaryKey("PK_ItemsTracker", x => x.Id);
					});
		}

		protected override void Down(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.DropTable(
					name: "ItemsTracker");
		}
	}
}
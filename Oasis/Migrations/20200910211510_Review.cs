using Microsoft.EntityFrameworkCore.Migrations;

namespace Oasis.Migrations
{
	public partial class Review : Migration
	{
		protected override void Up(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.CreateTable(
					name: "Reviews",
					columns: table => new
					{
						ReviewId = table.Column<int>(nullable: false)
									.Annotation("Sqlite:Autoincrement", true),
						ReviewMessage = table.Column<string>(nullable: true),
						ReviewerEmail = table.Column<string>(nullable: true),
						ReviewItem = table.Column<string>(nullable: true)
					},
					constraints: table =>
					{
						table.PrimaryKey("PK_Reviews", x => x.ReviewId);
					});
		}

		protected override void Down(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.DropTable(
					name: "Reviews");
		}
	}
}
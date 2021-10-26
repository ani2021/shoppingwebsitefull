using Microsoft.EntityFrameworkCore.Migrations;

namespace Oasis.Migrations
{
	public partial class GraphType : Migration
	{
		protected override void Up(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.AddColumn<string>(
					name: "GraphType",
					table: "Graphs",
					nullable: true);
		}

		protected override void Down(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.DropColumn(
					name: "GraphType",
					table: "Graphs");
		}
	}
}
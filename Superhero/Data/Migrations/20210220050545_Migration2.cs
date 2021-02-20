using Microsoft.EntityFrameworkCore.Migrations;

namespace Superhero.Data.Migrations
{
    public partial class Migration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AlterEgo",
                table: "Superheroes",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AlterEgo",
                table: "Superheroes");
        }
    }
}

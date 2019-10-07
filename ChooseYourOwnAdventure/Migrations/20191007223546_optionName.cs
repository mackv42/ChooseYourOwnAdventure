using Microsoft.EntityFrameworkCore.Migrations;

namespace ChooseYourOwnAdventure.Migrations
{
    public partial class optionName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Options",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Options");
        }
    }
}

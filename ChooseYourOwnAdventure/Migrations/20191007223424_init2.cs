using Microsoft.EntityFrameworkCore.Migrations;

namespace ChooseYourOwnAdventure.Migrations
{
    public partial class init2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PageReference",
                table: "Options");

            migrationBuilder.AddColumn<int>(
                name: "BelongsToId",
                table: "Options",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Options_BelongsToId",
                table: "Options",
                column: "BelongsToId");

            migrationBuilder.AddForeignKey(
                name: "FK_Options_Pages_BelongsToId",
                table: "Options",
                column: "BelongsToId",
                principalTable: "Pages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Options_Pages_BelongsToId",
                table: "Options");

            migrationBuilder.DropIndex(
                name: "IX_Options_BelongsToId",
                table: "Options");

            migrationBuilder.DropColumn(
                name: "BelongsToId",
                table: "Options");

            migrationBuilder.AddColumn<int>(
                name: "PageReference",
                table: "Options",
                nullable: false,
                defaultValue: 0);
        }
    }
}

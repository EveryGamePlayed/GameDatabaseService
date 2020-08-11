using Microsoft.EntityFrameworkCore.Migrations;

namespace Models.Migrations
{
    public partial class AddingPorts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "GameId",
                table: "Games",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SortTitle",
                table: "Games",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Games_GameId",
                table: "Games",
                column: "GameId");

            migrationBuilder.AddForeignKey(
                name: "FK_Games_Games_GameId",
                table: "Games",
                column: "GameId",
                principalTable: "Games",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Games_Games_GameId",
                table: "Games");

            migrationBuilder.DropIndex(
                name: "IX_Games_GameId",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "GameId",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "SortTitle",
                table: "Games");
        }
    }
}

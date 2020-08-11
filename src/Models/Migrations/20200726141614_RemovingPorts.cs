using Microsoft.EntityFrameworkCore.Migrations;

namespace Models.Migrations
{
    public partial class RemovingPorts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "GameId",
                table: "Games",
                type: "int",
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
    }
}

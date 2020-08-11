using Microsoft.EntityFrameworkCore.Migrations;

namespace Models.Migrations
{
    public partial class AddingVersioningInformation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Approved",
                table: "Series",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "Version",
                table: "Series",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "Approved",
                table: "Publishers",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "Version",
                table: "Publishers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "Approved",
                table: "Platforms",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "Version",
                table: "Platforms",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "Approved",
                table: "Genres",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "Version",
                table: "Genres",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "Approved",
                table: "Games",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "Version",
                table: "Games",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "Approved",
                table: "Developers",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "Version",
                table: "Developers",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Approved",
                table: "Series");

            migrationBuilder.DropColumn(
                name: "Version",
                table: "Series");

            migrationBuilder.DropColumn(
                name: "Approved",
                table: "Publishers");

            migrationBuilder.DropColumn(
                name: "Version",
                table: "Publishers");

            migrationBuilder.DropColumn(
                name: "Approved",
                table: "Platforms");

            migrationBuilder.DropColumn(
                name: "Version",
                table: "Platforms");

            migrationBuilder.DropColumn(
                name: "Approved",
                table: "Genres");

            migrationBuilder.DropColumn(
                name: "Version",
                table: "Genres");

            migrationBuilder.DropColumn(
                name: "Approved",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "Version",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "Approved",
                table: "Developers");

            migrationBuilder.DropColumn(
                name: "Version",
                table: "Developers");
        }
    }
}

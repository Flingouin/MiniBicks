using Microsoft.EntityFrameworkCore.Migrations;

namespace MiniBicks.DataContext.Migrations
{
    public partial class CorrectifRue : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Adrese",
                table: "Adresses");

            migrationBuilder.AddColumn<string>(
                name: "Rue",
                table: "Adresses",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Rue",
                table: "Adresses");

            migrationBuilder.AddColumn<string>(
                name: "Adrese",
                table: "Adresses",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}

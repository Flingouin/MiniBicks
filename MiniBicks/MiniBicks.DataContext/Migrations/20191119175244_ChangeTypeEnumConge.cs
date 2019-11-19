using Microsoft.EntityFrameworkCore.Migrations;

namespace MiniBicks.DataContext.Migrations
{
    public partial class ChangeTypeEnumConge : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EstValide",
                table: "Conges");

            migrationBuilder.AddColumn<int>(
                name: "CongeValiditeEnum",
                table: "Conges",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CongeValiditeEnum",
                table: "Conges");

            migrationBuilder.AddColumn<bool>(
                name: "EstValide",
                table: "Conges",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}

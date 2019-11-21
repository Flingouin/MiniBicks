using Microsoft.EntityFrameworkCore.Migrations;

namespace MiniBicks.DataContext.Migrations
{
    public partial class addValidateEnumFraisModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CongeValiditeEnum",
                table: "Conges");

            migrationBuilder.AddColumn<int>(
                name: "ValidateEnum",
                table: "Frais",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ValiditeEnum",
                table: "Conges",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ValidateEnum",
                table: "Frais");

            migrationBuilder.DropColumn(
                name: "ValiditeEnum",
                table: "Conges");

            migrationBuilder.AddColumn<int>(
                name: "CongeValiditeEnum",
                table: "Conges",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MiniBicks.DataContext.Migrations
{
    public partial class ajoutFKUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "ID_Adresse",
                table: "Users",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "ID_Responsable",
                table: "Users",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ID_Adresse",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "ID_Responsable",
                table: "Users");
        }
    }
}

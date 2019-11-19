using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MiniBicks.DataContext.Migrations
{
    public partial class addFKConge : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "ID_User",
                table: "Conges",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Conges_ID_User",
                table: "Conges",
                column: "ID_User");

            migrationBuilder.AddForeignKey(
                name: "FK_Conges_Users_ID_User",
                table: "Conges",
                column: "ID_User",
                principalTable: "Users",
                principalColumn: "ID_User",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Conges_Users_ID_User",
                table: "Conges");

            migrationBuilder.DropIndex(
                name: "IX_Conges_ID_User",
                table: "Conges");

            migrationBuilder.DropColumn(
                name: "ID_User",
                table: "Conges");
        }
    }
}

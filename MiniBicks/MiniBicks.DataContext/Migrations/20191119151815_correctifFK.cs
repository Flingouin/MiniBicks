using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MiniBicks.DataContext.Migrations
{
    public partial class correctifFK : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Adresses_AdresseID_Adresse",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_AdresseID_Adresse",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "AdresseID_Adresse",
                table: "Users");

            migrationBuilder.CreateIndex(
                name: "IX_Users_ID_Adresse",
                table: "Users",
                column: "ID_Adresse");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Adresses_ID_Adresse",
                table: "Users",
                column: "ID_Adresse",
                principalTable: "Adresses",
                principalColumn: "ID_Adresse",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Adresses_ID_Adresse",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_ID_Adresse",
                table: "Users");

            migrationBuilder.AddColumn<Guid>(
                name: "AdresseID_Adresse",
                table: "Users",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_AdresseID_Adresse",
                table: "Users",
                column: "AdresseID_Adresse");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Adresses_AdresseID_Adresse",
                table: "Users",
                column: "AdresseID_Adresse",
                principalTable: "Adresses",
                principalColumn: "ID_Adresse",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

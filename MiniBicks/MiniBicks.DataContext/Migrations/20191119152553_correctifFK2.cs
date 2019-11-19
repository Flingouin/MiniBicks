using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MiniBicks.DataContext.Migrations
{
    public partial class correctifFK2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Users_ResponsableID_User",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_ResponsableID_User",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "ResponsableID_User",
                table: "Users");

            migrationBuilder.CreateIndex(
                name: "IX_Users_ID_Responsable",
                table: "Users",
                column: "ID_Responsable");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Users_ID_Responsable",
                table: "Users",
                column: "ID_Responsable",
                principalTable: "Users",
                principalColumn: "ID_User",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Users_ID_Responsable",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_ID_Responsable",
                table: "Users");

            migrationBuilder.AddColumn<Guid>(
                name: "ResponsableID_User",
                table: "Users",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_ResponsableID_User",
                table: "Users",
                column: "ResponsableID_User");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Users_ResponsableID_User",
                table: "Users",
                column: "ResponsableID_User",
                principalTable: "Users",
                principalColumn: "ID_User",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

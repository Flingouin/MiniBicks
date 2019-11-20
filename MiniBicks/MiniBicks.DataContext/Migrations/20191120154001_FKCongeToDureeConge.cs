using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MiniBicks.DataContext.Migrations
{
    public partial class FKCongeToDureeConge : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "ID_DureeConge",
                table: "Conges",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Conges_ID_DureeConge",
                table: "Conges",
                column: "ID_DureeConge");

            migrationBuilder.AddForeignKey(
                name: "FK_Conges_DureeConges_ID_DureeConge",
                table: "Conges",
                column: "ID_DureeConge",
                principalTable: "DureeConges",
                principalColumn: "ID_DureeConge",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Conges_DureeConges_ID_DureeConge",
                table: "Conges");

            migrationBuilder.DropIndex(
                name: "IX_Conges_ID_DureeConge",
                table: "Conges");

            migrationBuilder.DropColumn(
                name: "ID_DureeConge",
                table: "Conges");
        }
    }
}

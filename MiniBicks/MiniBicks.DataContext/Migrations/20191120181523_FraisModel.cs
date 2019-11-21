using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MiniBicks.DataContext.Migrations
{
    public partial class FraisModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Frais",
                columns: table => new
                {
                    ID_Frai = table.Column<Guid>(nullable: false),
                    FraiEnum = table.Column<int>(nullable: false),
                    MontantTTC = table.Column<decimal>(nullable: false),
                    TVA = table.Column<decimal>(nullable: false),
                    ID_User = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Frais", x => x.ID_Frai);
                    table.ForeignKey(
                        name: "FK_Frais_Users_ID_User",
                        column: x => x.ID_User,
                        principalTable: "Users",
                        principalColumn: "ID_User",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Frais_ID_User",
                table: "Frais",
                column: "ID_User");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Frais");
        }
    }
}

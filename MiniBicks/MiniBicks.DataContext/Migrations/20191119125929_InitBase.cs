using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MiniBicks.DataContext.Migrations
{
    public partial class InitBase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Adresses",
                columns: table => new
                {
                    ID_Adresse = table.Column<Guid>(nullable: false),
                    NumeroRue = table.Column<int>(nullable: false),
                    Adrese = table.Column<string>(nullable: true),
                    CodePostal = table.Column<int>(nullable: false),
                    Ville = table.Column<string>(nullable: true),
                    PaysEnum = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adresses", x => x.ID_Adresse);
                });

            migrationBuilder.CreateTable(
                name: "Conges",
                columns: table => new
                {
                    ID_Conge = table.Column<Guid>(nullable: false),
                    EstValide = table.Column<bool>(nullable: false),
                    TypeCongeEnum = table.Column<int>(nullable: false),
                    DateDebut = table.Column<DateTime>(nullable: false),
                    DateFin = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Conges", x => x.ID_Conge);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    ID_User = table.Column<Guid>(nullable: false),
                    Nom = table.Column<string>(nullable: true),
                    Prenom = table.Column<string>(nullable: true),
                    AdresseID_Adresse = table.Column<Guid>(nullable: true),
                    RoleEnum = table.Column<int>(nullable: false),
                    ResponsableID_User = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.ID_User);
                    table.ForeignKey(
                        name: "FK_Users_Adresses_AdresseID_Adresse",
                        column: x => x.AdresseID_Adresse,
                        principalTable: "Adresses",
                        principalColumn: "ID_Adresse",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Users_Users_ResponsableID_User",
                        column: x => x.ResponsableID_User,
                        principalTable: "Users",
                        principalColumn: "ID_User",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Users_AdresseID_Adresse",
                table: "Users",
                column: "AdresseID_Adresse");

            migrationBuilder.CreateIndex(
                name: "IX_Users_ResponsableID_User",
                table: "Users",
                column: "ResponsableID_User");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Conges");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Adresses");
        }
    }
}

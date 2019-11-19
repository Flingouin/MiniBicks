using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MiniBicks.DataContext.Migrations
{
    public partial class AddDureeConge : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DureeConges",
                columns: table => new
                {
                    ID_DureeConge = table.Column<Guid>(nullable: false),
                    TypeCongeEnum = table.Column<int>(nullable: false),
                    PaysEnum = table.Column<int>(nullable: false),
                    Duree = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DureeConges", x => x.ID_DureeConge);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DureeConges");
        }
    }
}

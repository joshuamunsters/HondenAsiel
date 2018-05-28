using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace HondenAsiel.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ras",
                columns: table => new
                {
                    RasId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Beschrijving = table.Column<string>(nullable: true),
                    Rasnaam = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ras", x => x.RasId);
                });

            migrationBuilder.CreateTable(
                name: "honden",
                columns: table => new
                {
                    HondId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Aantalbeschikbaar = table.Column<int>(nullable: false),
                    Gewild = table.Column<bool>(nullable: false),
                    Kbeschrijving = table.Column<int>(nullable: false),
                    Lbeschrijving = table.Column<int>(nullable: false),
                    Naam = table.Column<string>(nullable: true),
                    PicURL = table.Column<string>(nullable: true),
                    Prijs = table.Column<decimal>(nullable: false),
                    RasId = table.Column<int>(nullable: false),
                    Thumbnail = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_honden", x => x.HondId);
                    table.ForeignKey(
                        name: "FK_honden_ras_RasId",
                        column: x => x.RasId,
                        principalTable: "ras",
                        principalColumn: "RasId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_honden_RasId",
                table: "honden",
                column: "RasId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "honden");

            migrationBuilder.DropTable(
                name: "ras");
        }
    }
}

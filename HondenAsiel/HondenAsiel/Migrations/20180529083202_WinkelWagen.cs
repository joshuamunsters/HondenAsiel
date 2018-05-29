using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace HondenAsiel.Migrations
{
    public partial class WinkelWagen : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "WinkelWagenItems",
                columns: table => new
                {
                    WinkelWagenItemId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Hoeveelheid = table.Column<int>(nullable: false),
                    HondenHondId = table.Column<int>(nullable: true),
                    WinkelWagenId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WinkelWagenItems", x => x.WinkelWagenItemId);
                    table.ForeignKey(
                        name: "FK_WinkelWagenItems_honden_HondenHondId",
                        column: x => x.HondenHondId,
                        principalTable: "honden",
                        principalColumn: "HondId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_WinkelWagenItems_HondenHondId",
                table: "WinkelWagenItems",
                column: "HondenHondId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WinkelWagenItems");
        }
    }
}

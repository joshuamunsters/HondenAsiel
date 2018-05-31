using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace HondenAsiel.Migrations
{
    public partial class Order : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "orders",
                columns: table => new
                {
                    OrderId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Achternaam = table.Column<string>(nullable: true),
                    Adress = table.Column<int>(nullable: false),
                    Adress2 = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Land = table.Column<string>(nullable: true),
                    OrderTotaal = table.Column<decimal>(nullable: false),
                    Ordergeplaatst = table.Column<DateTime>(nullable: false),
                    Postcode = table.Column<string>(nullable: true),
                    TelefoonNummer = table.Column<string>(nullable: true),
                    Voornaam = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_orders", x => x.OrderId);
                });

            migrationBuilder.CreateTable(
                name: "orderdetails",
                columns: table => new
                {
                    OrderDetailsId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Hoeveelheid = table.Column<int>(nullable: false),
                    HondenId = table.Column<int>(nullable: false),
                    OrderId = table.Column<int>(nullable: false),
                    Prijs = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_orderdetails", x => x.OrderDetailsId);
                    table.ForeignKey(
                        name: "FK_orderdetails_honden_HondenId",
                        column: x => x.HondenId,
                        principalTable: "honden",
                        principalColumn: "HondId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_orderdetails_orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "orders",
                        principalColumn: "OrderId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_orderdetails_HondenId",
                table: "orderdetails",
                column: "HondenId");

            migrationBuilder.CreateIndex(
                name: "IX_orderdetails_OrderId",
                table: "orderdetails",
                column: "OrderId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "orderdetails");

            migrationBuilder.DropTable(
                name: "orders");
        }
    }
}

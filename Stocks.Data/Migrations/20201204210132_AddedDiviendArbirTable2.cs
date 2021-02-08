using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Stocks.Data.Migrations
{
    public partial class AddedDiviendArbirTable2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DividendCalendarEntities2",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Created = table.Column<DateTimeOffset>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    Label = table.Column<string>(nullable: true),
                    AdjDividend = table.Column<decimal>(nullable: false),
                    Symbol = table.Column<string>(nullable: true),
                    Dividend = table.Column<decimal>(nullable: false),
                    RecordDate = table.Column<DateTime>(nullable: true),
                    PaymentDate = table.Column<DateTime>(nullable: true),
                    DeclarationDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DividendCalendarEntities2", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StockPriceEntities",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Symbol = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: false),
                    Volume = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StockPriceEntities", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DividendCalendarEntities2");

            migrationBuilder.DropTable(
                name: "StockPriceEntities");
        }
    }
}

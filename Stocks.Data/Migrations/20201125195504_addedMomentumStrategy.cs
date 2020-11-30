using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Stocks.Data.Migrations
{
    public partial class addedMomentumStrategy : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "StockPriceHistoricEntities",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Created = table.Column<DateTimeOffset>(nullable: false),
                    Symbol = table.Column<string>(maxLength: 30, nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    Open = table.Column<decimal>(nullable: false),
                    High = table.Column<decimal>(nullable: false),
                    Low = table.Column<decimal>(nullable: false),
                    Close = table.Column<decimal>(nullable: false),
                    AdjClose = table.Column<decimal>(nullable: false),
                    Volume = table.Column<long>(nullable: false),
                    UnadjustedVolume = table.Column<long>(nullable: false),
                    Change = table.Column<decimal>(nullable: false),
                    ChangePercent = table.Column<decimal>(nullable: false),
                    Vwap = table.Column<decimal>(nullable: false),
                    Label = table.Column<string>(nullable: true),
                    ChangeOverTime = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StockPriceHistoricEntities", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StockPriceHistoricEntities");
        }
    }
}

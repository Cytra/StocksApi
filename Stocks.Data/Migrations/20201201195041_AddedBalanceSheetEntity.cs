using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Stocks.Data.Migrations
{
    public partial class AddedBalanceSheetEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BalanceSheetEntities",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Created = table.Column<DateTimeOffset>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    Symbol = table.Column<string>(nullable: true),
                    FillingDate = table.Column<DateTime>(nullable: true),
                    AcceptedDate = table.Column<DateTime>(nullable: true),
                    Period = table.Column<string>(nullable: true),
                    CashAndCashEquivalents = table.Column<long>(nullable: false),
                    ShortTermInvestments = table.Column<long>(nullable: false),
                    CashAndShortTermInvestments = table.Column<long>(nullable: false),
                    NetReceivables = table.Column<long>(nullable: false),
                    Inventory = table.Column<long>(nullable: false),
                    OtherCurrentAssets = table.Column<long>(nullable: false),
                    TotalCurrentAssets = table.Column<long>(nullable: false),
                    PropertyPlantEquipmentNet = table.Column<long>(nullable: false),
                    Goodwill = table.Column<long>(nullable: false),
                    IntangibleAssets = table.Column<long>(nullable: false),
                    GoodwillAndIntangibleAssets = table.Column<long>(nullable: false),
                    LongTermInvestments = table.Column<long>(nullable: false),
                    TaxAssets = table.Column<long>(nullable: false),
                    OtherNonCurrentAssets = table.Column<long>(nullable: false),
                    TotalNonCurrentAssets = table.Column<long>(nullable: false),
                    OtherAssets = table.Column<long>(nullable: false),
                    TotalAssets = table.Column<long>(nullable: false),
                    AccountPayables = table.Column<long>(nullable: false),
                    ShortTermDebt = table.Column<long>(nullable: false),
                    TaxPayables = table.Column<long>(nullable: false),
                    DeferredRevenue = table.Column<long>(nullable: false),
                    OtherCurrentLiabilities = table.Column<long>(nullable: false),
                    TotalCurrentLiabilities = table.Column<long>(nullable: false),
                    LongTermDebt = table.Column<long>(nullable: false),
                    DeferredRevenueNonCurrent = table.Column<long>(nullable: false),
                    DeferredTaxLiabilitiesNonCurrent = table.Column<long>(nullable: false),
                    OtherNonCurrentLiabilities = table.Column<long>(nullable: false),
                    TotalNonCurrentLiabilities = table.Column<long>(nullable: false),
                    OtherLiabilities = table.Column<long>(nullable: false),
                    TotalLiabilities = table.Column<long>(nullable: false),
                    CommonStock = table.Column<long>(nullable: false),
                    RetainedEarnings = table.Column<long>(nullable: false),
                    AccumulatedOtherComprehensiveIncomeLoss = table.Column<long>(nullable: false),
                    OthertotalStockholdersEquity = table.Column<long>(nullable: false),
                    TotalStockholdersEquity = table.Column<long>(nullable: false),
                    TotalLiabilitiesAndStockholdersEquity = table.Column<long>(nullable: false),
                    TotalInvestments = table.Column<long>(nullable: false),
                    TotalDebt = table.Column<long>(nullable: false),
                    NetDebt = table.Column<long>(nullable: false),
                    Link = table.Column<string>(nullable: true),
                    FinalLink = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BalanceSheetEntities", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BalanceSheetEntities");
        }
    }
}

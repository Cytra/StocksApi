using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Stocks.Data.Migrations
{
    public partial class AddedIncomeStatementTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "IncomeStatementEntities",
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
                    NetIncome = table.Column<long>(nullable: false),
                    DepreciationAndAmortization = table.Column<long>(nullable: false),
                    DeferredIncomeTax = table.Column<long>(nullable: false),
                    StockBasedCompensation = table.Column<long>(nullable: false),
                    ChangeInWorkingCapital = table.Column<long>(nullable: false),
                    AccountsReceivables = table.Column<long>(nullable: false),
                    Inventory = table.Column<long>(nullable: false),
                    AccountsPayables = table.Column<long>(nullable: false),
                    OtherWorkingCapital = table.Column<long>(nullable: false),
                    OtherNonCashItems = table.Column<long>(nullable: false),
                    NetCashProvidedByOperatingActivities = table.Column<long>(nullable: false),
                    InvestmentsInPropertyPlantAndEquipment = table.Column<long>(nullable: false),
                    AcquisitionsNet = table.Column<long>(nullable: false),
                    PurchasesOfInvestments = table.Column<long>(nullable: false),
                    SalesMaturitiesOfInvestments = table.Column<long>(nullable: false),
                    OtherInvestingActivites = table.Column<long>(nullable: false),
                    NetCashUsedForInvestingActivites = table.Column<long>(nullable: false),
                    DebtRepayment = table.Column<long>(nullable: false),
                    CommonStockIssued = table.Column<long>(nullable: false),
                    CommonStockRepurchased = table.Column<long>(nullable: false),
                    DividendsPaid = table.Column<long>(nullable: false),
                    OtherFinancingActivites = table.Column<long>(nullable: false),
                    NetCashUsedProvidedByFinancingActivities = table.Column<long>(nullable: false),
                    EffectOfForexChangesOnCash = table.Column<long>(nullable: false),
                    NetChangeInCash = table.Column<long>(nullable: false),
                    CashAtEndOfPeriod = table.Column<long>(nullable: false),
                    CashAtBeginningOfPeriod = table.Column<long>(nullable: false),
                    OperatingCashFlow = table.Column<long>(nullable: false),
                    CapitalExpenditure = table.Column<long>(nullable: false),
                    FreeCashFlow = table.Column<long>(nullable: false),
                    Link = table.Column<string>(nullable: true),
                    FinalLink = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IncomeStatementEntities", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IncomeStatementEntities");
        }
    }
}

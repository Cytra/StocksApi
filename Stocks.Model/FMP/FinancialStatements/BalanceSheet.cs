using System;

namespace Stocks.Model.FMP.FinancialStatements
{
    public class BalanceSheet
    {
        public DateTime Date { get; set; }
        public string Symbol { get; set; }
        public DateTime? FillingDate { get; set; }
        public DateTime? AcceptedDate { get; set; }
        public string Period { get; set; }
        public Int64? CashAndCashEquivalents { get; set; }
        public Int64? ShortTermInvestments { get; set; }
        public Int64? CashAndShortTermInvestments { get; set; }
        public Int64? NetReceivables { get; set; }
        public Int64? Inventory { get; set; }
        public Int64? OtherCurrentAssets { get; set; }
        public Int64? TotalCurrentAssets { get; set; }
        public Int64? PropertyPlantEquipmentNet { get; set; }
        public Int64? Goodwill { get; set; }
        public Int64? IntangibleAssets { get; set; }
        public Int64? GoodwillAndIntangibleAssets { get; set; }
        public Int64? LongTermInvestments { get; set; }
        public Int64? TaxAssets { get; set; }
        public Int64? OtherNonCurrentAssets { get; set; }
        public Int64? TotalNonCurrentAssets { get; set; }
        public Int64? OtherAssets { get; set; }
        public Int64? TotalAssets { get; set; }
        public Int64? AccountPayables { get; set; }
        public Int64? ShortTermDebt { get; set; }
        public Int64? TaxPayables { get; set; }
        public Int64? DeferredRevenue { get; set; }
        public Int64? OtherCurrentLiabilities { get; set; }
        public Int64? TotalCurrentLiabilities { get; set; }
        public Int64? LongTermDebt { get; set; }
        public Int64? DeferredRevenueNonCurrent { get; set; }
        public Int64? DeferredTaxLiabilitiesNonCurrent { get; set; }
        public Int64? OtherNonCurrentLiabilities { get; set; }
        public Int64? TotalNonCurrentLiabilities { get; set; }
        public Int64? OtherLiabilities { get; set; }
        public Int64? TotalLiabilities { get; set; }
        public Int64? CommonStock { get; set; }
        public Int64? RetainedEarnings { get; set; }
        public Int64? AccumulatedOtherComprehensiveIncomeLoss { get; set; }
        public Int64? OthertotalStockholdersEquity { get; set; }
        public Int64? TotalStockholdersEquity { get; set; }
        public Int64? TotalLiabilitiesAndStockholdersEquity { get; set; }
        public Int64? TotalInvestments { get; set; }
        public Int64? TotalDebt { get; set; }
        public Int64? NetDebt { get; set; }
        public string Link { get; set; }
        public string FinalLink { get; set; }
    }
}

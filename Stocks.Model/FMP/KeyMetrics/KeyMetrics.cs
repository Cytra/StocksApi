using System;

namespace Stocks.Model.Fmp.KeyMetrics
{
    public class KeyMetrics
    {
        public string symbol { get; set; }
        public DateTime date { get; set; }
        public string period { get; set; }
        public float? revenuePerShare { get; set; }
        public float? netIncomePerShare { get; set; }
        public float? operatingCashFlowPerShare { get; set; }
        public float? freeCashFlowPerShare { get; set; }
        public float? cashPerShare { get; set; }
        public float? bookValuePerShare { get; set; }
        public float? tangibleBookValuePerShare { get; set; }
        public float? shareholdersEquityPerShare { get; set; }
        public float? interestDebtPerShare { get; set; }
        public float? marketCap { get; set; }
        public float? enterpriseValue { get; set; }
        public float? peRatio { get; set; }
        public float? priceToSalesRatio { get; set; }
        public float? pocfratio { get; set; }
        public float? pfcfRatio { get; set; }
        public float? pbRatio { get; set; }
        public float? ptbRatio { get; set; }
        public float? evToSales { get; set; }
        public float? enterpriseValueOverEBITDA { get; set; }
        public float? evToOperatingCashFlow { get; set; }
        public float? evToFreeCashFlow { get; set; }
        public float? earningsYield { get; set; }
        public float? freeCashFlowYield { get; set; }
        public float? debtToEquity { get; set; }
        public float? debtToAssets { get; set; }
        public float? netDebtToEBITDA { get; set; }
        public float? currentRatio { get; set; }
        public float? interestCoverage { get; set; }
        public float? incomeQuality { get; set; }
        public float? dividendYield { get; set; }
        public float? payoutRatio { get; set; }
        public float? salesGeneralAndAdministrativeToRevenue { get; set; }
        public float? researchAndDdevelopementToRevenue { get; set; }
        public float? intangiblesToTotalAssets { get; set; }
        public float? capexToOperatingCashFlow { get; set; }
        public float? capexToRevenue { get; set; }
        public float? capexToDepreciation { get; set; }
        public float? stockBasedCompensationToRevenue { get; set; }
        public float? grahamNumber { get; set; }
        public float? roic { get; set; }
        public float? returnOnTangibleAssets { get; set; }
        public float? grahamNetNet { get; set; }
        public long? workingCapital { get; set; }
        public long? tangibleAssetValue { get; set; }
        public long? netCurrentAssetValue { get; set; }
        public long? investedCapital { get; set; }
        public long? averageReceivables { get; set; }
        public long? averagePayables { get; set; }
        public long? averageInventory { get; set; }
        public float? daysSalesOutstanding { get; set; }
        public float? daysPayablesOutstanding { get; set; }
        public float? daysOfInventoryOnHand { get; set; }
        public float? receivablesTurnover { get; set; }
        public float? payablesTurnover { get; set; }
        public float? inventoryTurnover { get; set; }
        public float? roe { get; set; }
        public float? capexPerShare { get; set; }
    }

}

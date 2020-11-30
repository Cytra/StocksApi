using System;

namespace Stocks.Data.Entities.FinancialStatements
{
    public class IncomeStatementEntity : EntityBase
    {
        public IncomeStatementEntity()
        {
            Created = DateTimeOffset.Now;
        }
        public DateTime Date { get; set; }
        public string Symbol { get; set; }
        public DateTime? FillingDate { get; set; }
        public DateTime? AcceptedDate { get; set; }
        public string Period { get; set; }
        public Int64 NetIncome { get; set; }
        public Int64 DepreciationAndAmortization { get; set; }
        public Int64 DeferredIncomeTax { get; set; }
        public Int64 StockBasedCompensation { get; set; }
        public Int64 ChangeInWorkingCapital { get; set; }
        public Int64 AccountsReceivables { get; set; }
        public Int64 Inventory { get; set; }
        public Int64 AccountsPayables { get; set; }
        public Int64 OtherWorkingCapital { get; set; }
        public Int64 OtherNonCashItems { get; set; }
        public Int64 NetCashProvidedByOperatingActivities { get; set; }
        public Int64 InvestmentsInPropertyPlantAndEquipment { get; set; }
        public Int64 AcquisitionsNet { get; set; }
        public Int64 PurchasesOfInvestments { get; set; }
        public Int64 SalesMaturitiesOfInvestments { get; set; }
        public Int64 OtherInvestingActivites { get; set; }
        public Int64 NetCashUsedForInvestingActivites { get; set; }
        public Int64 DebtRepayment { get; set; }
        public Int64 CommonStockIssued { get; set; }
        public Int64 CommonStockRepurchased { get; set; }
        public Int64 DividendsPaid { get; set; }
        public Int64 OtherFinancingActivites { get; set; }
        public Int64 NetCashUsedProvidedByFinancingActivities { get; set; }
        public Int64 EffectOfForexChangesOnCash { get; set; }
        public Int64 NetChangeInCash { get; set; }
        public Int64 CashAtEndOfPeriod { get; set; }
        public Int64 CashAtBeginningOfPeriod { get; set; }
        public Int64 OperatingCashFlow { get; set; }
        public Int64 CapitalExpenditure { get; set; }
        public Int64 FreeCashFlow { get; set; }
        public string Link { get; set; }
        public string FinalLink { get; set; }
    }
}

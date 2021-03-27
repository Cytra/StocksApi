using System;
using System.Collections.Generic;
using System.Text;

namespace Stocks.Model.CompanyOutlook
{

    public class CompanyOutlookModel
    {
        public Profile profile { get; set; }
        public Insidetrade[] insideTrades { get; set; }
        public Keyexecutive[] keyExecutives { get; set; }
        public Splithistory[] splitHistory { get; set; }
        public Stockdividend[] stockDividend { get; set; }
        public Stocknew[] stockNews { get; set; }
        public Financialsannual financialsAnnual { get; set; }
        public Financialsquarter financialsQuarter { get; set; }
    }

    public class Profile
    {
        public string symbol { get; set; }
        public decimal price { get; set; }
        public decimal beta { get; set; }
        public int volAvg { get; set; }
        public long mktCap { get; set; }
        public decimal lastDiv { get; set; }
        public string range { get; set; }
        public decimal changes { get; set; }
        public string companyName { get; set; }
        public string currency { get; set; }
        public string cik { get; set; }
        public string isin { get; set; }
        public string cusip { get; set; }
        public string exchange { get; set; }
        public string exchangeShortName { get; set; }
        public string industry { get; set; }
        public string website { get; set; }
        public string description { get; set; }
        public string ceo { get; set; }
        public string sector { get; set; }
        public string country { get; set; }
        public string fullTimeEmployees { get; set; }
        public string phone { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string zip { get; set; }
        public decimal? dcfDiff { get; set; }
        public decimal dcf { get; set; }
        public string image { get; set; }
        public string ipoDate { get; set; }
        public bool defaultImage { get; set; }
        public bool isEtf { get; set; }
        public bool isActivelyTrading { get; set; }
    }

    public class Financialsannual
    {
        public Income[] income { get; set; }
        public Balance[] balance { get; set; }
        public Cash[] cash { get; set; }
    }

    public class Income
    {
        public string date { get; set; }
        public string symbol { get; set; }
        public string reportedCurrency { get; set; }
        public string fillingDate { get; set; }
        public string acceptedDate { get; set; }
        public string period { get; set; }
        public decimal revenue { get; set; }
        public decimal costOfRevenue { get; set; }
        public decimal grossProfit { get; set; }
        public decimal grossProfitRatio { get; set; }
        public decimal researchAndDevelopmentExpenses { get; set; }
        public decimal generalAndAdministrativeExpenses { get; set; }
        public decimal sellingAndMarketingExpenses { get; set; }
        public decimal otherExpenses { get; set; }
        public decimal operatingExpenses { get; set; }
        public decimal costAndExpenses { get; set; }
        public decimal interestExpense { get; set; }
        public decimal depreciationAndAmortization { get; set; }
        public decimal ebitda { get; set; }
        public decimal ebitdaratio { get; set; }
        public decimal operatingIncome { get; set; }
        public decimal operatingIncomeRatio { get; set; }
        public decimal totalOtherIncomeExpensesNet { get; set; }
        public decimal incomeBeforeTax { get; set; }
        public decimal incomeBeforeTaxRatio { get; set; }
        public decimal incomeTaxExpense { get; set; }
        public decimal netIncome { get; set; }
        public decimal netIncomeRatio { get; set; }
        public decimal eps { get; set; }
        public decimal epsdiluted { get; set; }
        public decimal weightedAverageShsOut { get; set; }
        public decimal weightedAverageShsOutDil { get; set; }
        public string link { get; set; }
        public string finalLink { get; set; }
    }

    public class Balance
    {
        public string date { get; set; }
        public string symbol { get; set; }
        public string reportedCurrency { get; set; }
        public string fillingDate { get; set; }
        public string acceptedDate { get; set; }
        public string period { get; set; }
        public decimal cashAndCashEquivalents { get; set; }
        public decimal shortTermInvestments { get; set; }
        public decimal cashAndShortTermInvestments { get; set; }
        public decimal netReceivables { get; set; }
        public decimal inventory { get; set; }
        public decimal otherCurrentAssets { get; set; }
        public decimal totalCurrentAssets { get; set; }
        public decimal propertyPlantEquipmentNet { get; set; }
        public decimal goodwill { get; set; }
        public decimal intangibleAssets { get; set; }
        public decimal goodwillAndIntangibleAssets { get; set; }
        public decimal longTermInvestments { get; set; }
        public decimal taxAssets { get; set; }
        public decimal otherNonCurrentAssets { get; set; }
        public decimal totalNonCurrentAssets { get; set; }
        public decimal otherAssets { get; set; }
        public decimal totalAssets { get; set; }
        public decimal accountPayables { get; set; }
        public decimal shortTermDebt { get; set; }
        public decimal taxPayables { get; set; }
        public decimal deferredRevenue { get; set; }
        public decimal otherCurrentLiabilities { get; set; }
        public decimal totalCurrentLiabilities { get; set; }
        public decimal longTermDebt { get; set; }
        public decimal deferredRevenueNonCurrent { get; set; }
        public decimal deferredTaxLiabilitiesNonCurrent { get; set; }
        public decimal otherNonCurrentLiabilities { get; set; }
        public decimal totalNonCurrentLiabilities { get; set; }
        public decimal otherLiabilities { get; set; }
        public decimal totalLiabilities { get; set; }
        public decimal commonStock { get; set; }
        public decimal retainedEarnings { get; set; }
        public decimal accumulatedOtherComprehensiveIncomeLoss { get; set; }
        public decimal othertotalStockholdersEquity { get; set; }
        public decimal totalStockholdersEquity { get; set; }
        public decimal totalLiabilitiesAndStockholdersEquity { get; set; }
        public decimal totalInvestments { get; set; }
        public decimal totalDebt { get; set; }
        public decimal netDebt { get; set; }
        public string link { get; set; }
        public string finalLink { get; set; }
    }

    public class Cash
    {
        public string date { get; set; }
        public string symbol { get; set; }
        public string reportedCurrency { get; set; }
        public string fillingDate { get; set; }
        public string acceptedDate { get; set; }
        public string period { get; set; }
        public long netIncome { get; set; }
        public long depreciationAndAmortization { get; set; }
        public long deferredIncomeTax { get; set; }
        public long stockBasedCompensation { get; set; }
        public long changeInWorkingCapital { get; set; }
        public long accountsReceivables { get; set; }
        public long inventory { get; set; }
        public long accountsPayables { get; set; }
        public long otherWorkingCapital { get; set; }
        public long otherNonCashItems { get; set; }
        public long netCashProvidedByOperatingActivities { get; set; }
        public long investmentsInPropertyPlantAndEquipment { get; set; }
        public decimal acquisitionsNet { get; set; }
        public long purchasesOfInvestments { get; set; }
        public long salesMaturitiesOfInvestments { get; set; }
        public long otherInvestingActivites { get; set; }
        public long netCashUsedForInvestingActivites { get; set; }
        public long debtRepayment { get; set; }
        public decimal commonStockIssued { get; set; }
        public long commonStockRepurchased { get; set; }
        public long dividendsPaid { get; set; }
        public long otherFinancingActivites { get; set; }
        public long netCashUsedProvidedByFinancingActivities { get; set; }
        public decimal effectOfForexChangesOnCash { get; set; }
        public long netChangeInCash { get; set; }
        public long cashAtEndOfPeriod { get; set; }
        public long cashAtBeginningOfPeriod { get; set; }
        public long operatingCashFlow { get; set; }
        public long capitalExpenditure { get; set; }
        public long freeCashFlow { get; set; }
        public string link { get; set; }
        public string finalLink { get; set; }
    }

    public class Financialsquarter
    {
        public Income1[] income { get; set; }
        public Balance1[] balance { get; set; }
        public Cash1[] cash { get; set; }
    }

    public class Income1
    {
        public string date { get; set; }
        public string symbol { get; set; }
        public string reportedCurrency { get; set; }
        public string fillingDate { get; set; }
        public string acceptedDate { get; set; }
        public string period { get; set; }
        public long revenue { get; set; }
        public long costOfRevenue { get; set; }
        public long grossProfit { get; set; }
        public decimal grossProfitRatio { get; set; }
        public long researchAndDevelopmentExpenses { get; set; }
        public long generalAndAdministrativeExpenses { get; set; }
        public decimal sellingAndMarketingExpenses { get; set; }
        public decimal otherExpenses { get; set; }
        public long operatingExpenses { get; set; }
        public long costAndExpenses { get; set; }
        public decimal interestExpense { get; set; }
        public long depreciationAndAmortization { get; set; }
        public long ebitda { get; set; }
        public decimal ebitdaratio { get; set; }
        public long operatingIncome { get; set; }
        public decimal operatingIncomeRatio { get; set; }
        public decimal totalOtherIncomeExpensesNet { get; set; }
        public long incomeBeforeTax { get; set; }
        public decimal incomeBeforeTaxRatio { get; set; }
        public long incomeTaxExpense { get; set; }
        public long netIncome { get; set; }
        public decimal netIncomeRatio { get; set; }
        public decimal eps { get; set; }
        public decimal epsdiluted { get; set; }
        public long weightedAverageShsOut { get; set; }
        public long weightedAverageShsOutDil { get; set; }
        public string link { get; set; }
        public string finalLink { get; set; }
    }

    public class Balance1
    {
        public string date { get; set; }
        public string symbol { get; set; }
        public string reportedCurrency { get; set; }
        public string fillingDate { get; set; }
        public string acceptedDate { get; set; }
        public string period { get; set; }
        public long cashAndCashEquivalents { get; set; }
        public long shortTermInvestments { get; set; }
        public long cashAndShortTermInvestments { get; set; }
        public long netReceivables { get; set; }
        public long inventory { get; set; }
        public long otherCurrentAssets { get; set; }
        public long totalCurrentAssets { get; set; }
        public long propertyPlantEquipmentNet { get; set; }
        public decimal goodwill { get; set; }
        public decimal intangibleAssets { get; set; }
        public decimal goodwillAndIntangibleAssets { get; set; }
        public long longTermInvestments { get; set; }
        public decimal taxAssets { get; set; }
        public long otherNonCurrentAssets { get; set; }
        public long totalNonCurrentAssets { get; set; }
        public long otherAssets { get; set; }
        public long totalAssets { get; set; }
        public long accountPayables { get; set; }
        public long shortTermDebt { get; set; }
        public decimal taxPayables { get; set; }
        public long deferredRevenue { get; set; }
        public long otherCurrentLiabilities { get; set; }
        public long totalCurrentLiabilities { get; set; }
        public long longTermDebt { get; set; }
        public decimal deferredRevenueNonCurrent { get; set; }
        public decimal deferredTaxLiabilitiesNonCurrent { get; set; }
        public long otherNonCurrentLiabilities { get; set; }
        public long totalNonCurrentLiabilities { get; set; }
        public long otherLiabilities { get; set; }
        public long totalLiabilities { get; set; }
        public long commonStock { get; set; }
        public long retainedEarnings { get; set; }
        public long accumulatedOtherComprehensiveIncomeLoss { get; set; }
        public decimal othertotalStockholdersEquity { get; set; }
        public long totalStockholdersEquity { get; set; }
        public long totalLiabilitiesAndStockholdersEquity { get; set; }
        public long totalInvestments { get; set; }
        public long totalDebt { get; set; }
        public long netDebt { get; set; }
        public string link { get; set; }
        public string finalLink { get; set; }
    }

    public class Cash1
    {
        public string date { get; set; }
        public string symbol { get; set; }
        public string reportedCurrency { get; set; }
        public string fillingDate { get; set; }
        public string acceptedDate { get; set; }
        public string period { get; set; }
        public long netIncome { get; set; }
        public long depreciationAndAmortization { get; set; }
        public decimal deferredIncomeTax { get; set; }
        public decimal stockBasedCompensation { get; set; }
        public long changeInWorkingCapital { get; set; }
        public long accountsReceivables { get; set; }
        public decimal inventory { get; set; }
        public long accountsPayables { get; set; }
        public long otherWorkingCapital { get; set; }
        public decimal otherNonCashItems { get; set; }
        public long netCashProvidedByOperatingActivities { get; set; }
        public decimal investmentsInPropertyPlantAndEquipment { get; set; }
        public decimal acquisitionsNet { get; set; }
        public long purchasesOfInvestments { get; set; }
        public long salesMaturitiesOfInvestments { get; set; }
        public long otherInvestingActivites { get; set; }
        public long netCashUsedForInvestingActivites { get; set; }
        public decimal debtRepayment { get; set; }
        public decimal commonStockIssued { get; set; }
        public long commonStockRepurchased { get; set; }
        public long dividendsPaid { get; set; }
        public long otherFinancingActivites { get; set; }
        public long netCashUsedProvidedByFinancingActivities { get; set; }
        public decimal effectOfForexChangesOnCash { get; set; }
        public long netChangeInCash { get; set; }
        public long cashAtEndOfPeriod { get; set; }
        public long cashAtBeginningOfPeriod { get; set; }
        public long operatingCashFlow { get; set; }
        public long capitalExpenditure { get; set; }
        public long freeCashFlow { get; set; }
        public string link { get; set; }
        public string finalLink { get; set; }
    }

    public class Insidetrade
    {
        public string symbol { get; set; }
        public string transactionDate { get; set; }
        public string reportingCik { get; set; }
        public string transactionType { get; set; }
        public decimal securitiesOwned { get; set; }
        public string companyCik { get; set; }
        public string reportingName { get; set; }
        public string typeOfOwner { get; set; }
        public string acquistionOrDisposition { get; set; }
        public string formType { get; set; }
        public decimal securitiesTransacted { get; set; }
        public decimal? price { get; set; }
        public string securityName { get; set; }
        public string link { get; set; }
    }

    public class Keyexecutive
    {
        public string title { get; set; }
        public string name { get; set; }
        public string gender { get; set; }
        public int? pay { get; set; }
        public string currencyPay { get; set; }
    }

    public class Splithistory
    {
        public string date { get; set; }
        public string label { get; set; }
        public decimal numerator { get; set; }
        public decimal denominator { get; set; }
    }

    public class Stockdividend
    {
        public string date { get; set; }
        public string label { get; set; }
        public decimal adjDividend { get; set; }
        public decimal dividend { get; set; }
        public string recordDate { get; set; }
        public string paymentDate { get; set; }
        public string declarationDate { get; set; }
    }

    public class Stocknew
    {
        public string symbol { get; set; }
        public string publishedDate { get; set; }
        public string title { get; set; }
        public string image { get; set; }
        public string site { get; set; }
        public string text { get; set; }
        public string url { get; set; }
    }

}

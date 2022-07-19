namespace Stocks.Model.FMP.Screener
{
    public class StockScreenerResponseList : ListModelBase<StockScreenerResponse>
    {

    }
    public class StockScreenerResponse
    {
        public string symbol { get; set; }
        public string companyName { get; set; }
        public float marketCap { get; set; }
        public string sector { get; set; }
        public string industry { get; set; }    
        public float beta { get; set; }
        public float price { get; set; }
        public float lastAnnualDividend { get; set; }
        public decimal DividendYield { get; set; }
        public int volume { get; set; }
        public string exchange { get; set; }
        public string exchangeShortName { get; set; }
        public string country { get; set; }
        public bool isEtf { get; set; }
        public bool isActivelyTrading { get; set; }
    }
}

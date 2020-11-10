using System;

namespace Stocks.Model.FMP.Requests.StockList
{
    public class StockScreenListItem
    {
        public string Symbol { get; set; }
        public string CompanyName { get; set; }
        public long MarketCap { get; set; }
        public string Sector { get; set; }
        public string Industry { get; set; }
        public decimal Beta { get; set; }
        public decimal Price { get; set; }
        public decimal LastAnnualDividend { get; set; }
        public long Volume { get; set; }
        public string Exchange { get; set; }
        public string ExchangeShortName { get; set; }
    }
}

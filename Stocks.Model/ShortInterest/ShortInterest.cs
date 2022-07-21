using Stocks.Model.Fmp.StockPrice;

namespace Stocks.Model.ShortInterest
{
    public class ShortInterest
    {
        public string Ticker { get; set; }
        public string Company { get; set; }
        public string Exchange { get; set; }
        public decimal ShortInt { get; set; }
        public string Float { get; set; }
        public string OutStd { get; set; }
        public string Industry { get; set; }
        public StockPricesForUi Prices { get; set; }
        public long? MarketCap { get; set; }

    }
}

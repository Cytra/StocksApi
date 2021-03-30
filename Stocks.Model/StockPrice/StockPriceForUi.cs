using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Stocks.Model.StockPrice
{
    public class StockPricesForUi
    {
        public string Ticker { get; set; }
        public StockPriceForUi Day { get; set; } = new StockPriceForUi();
        public StockPriceForUi TwoDay { get; set; } = new StockPriceForUi();
        public StockPriceForUi ThreeDay { get; set; } = new StockPriceForUi();
        public StockPriceForUi Week { get; set; } = new StockPriceForUi();
        public StockPriceForUi Month { get; set; } = new StockPriceForUi();
        public StockPriceForUi ThreeMonths { get; set; } = new StockPriceForUi();
    }
    public class StockPriceForUi
    {
        public decimal Performance { get; set; }
    }

    public class StockPricesForUiRequest
    {
        public List<string> Tickers { get; set; }
    }

}

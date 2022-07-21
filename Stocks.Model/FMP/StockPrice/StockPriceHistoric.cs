using System.Collections.Generic;

namespace Stocks.Model.Fmp.StockPrice
{
    public class StockPriceHistoric
    {
        public string Symbol { get; set; }
        public List<StockPriceHistoricItem> Historical { get; set; }
    }
}

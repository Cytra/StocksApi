using System.Collections.Generic;

namespace Stocks.Model.FMP.StockPrice
{
    public class StockPriceHistoricSimple
    {
        public string Symbol { get; set; }
        public List<StockPriceHistoricSimpleItem> Historical { get; set; }
    }
}

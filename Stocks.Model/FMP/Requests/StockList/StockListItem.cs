namespace Stocks.Model.FMP.Requests.StockList
{
    public class StockListItem
    {
        public string Symbol { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Exchange { get; set; }
    }
}

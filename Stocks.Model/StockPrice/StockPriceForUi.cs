namespace Stocks.Model.StockPrice
{
    public class StockPricesForUi
    {
        public StockPriceForUi Day { get; set; } = new StockPriceForUi();
        public StockPriceForUi Week { get; set; } = new StockPriceForUi();
        public StockPriceForUi Month { get; set; } = new StockPriceForUi();
        public StockPriceForUi ThreeMonths { get; set; } = new StockPriceForUi();
    }
    public class StockPriceForUi
    {
        public string Performance { get; set; }
    }

}

using System;

namespace Stocks.Model.Fmp.StockPrice
{
    public class StockPriceHistoricItem
    {
        public DateTime Date { get; set; }
        public decimal Open { get; set; }
        public decimal High { get; set; }
        public decimal Low { get; set; }
        public decimal Close { get; set; }
        public decimal AdjClose { get; set; }
        public Int64 Volume { get; set; }
        public Int64 UnadjustedVolume { get; set; }
        public decimal Change { get; set; }
        public decimal ChangePercent { get; set; }
        public decimal Vwap { get; set; }
        public string Label { get; set; }
        public decimal ChangeOverTime { get; set; }
    }
}

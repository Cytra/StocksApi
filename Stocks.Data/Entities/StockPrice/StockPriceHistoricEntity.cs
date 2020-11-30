using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Stocks.Data.Entities.StockPrice
{
    public class StockPriceHistoricEntity : EntityBase
    {
        public StockPriceHistoricEntity()
        {
            Created = DateTimeOffset.Now;
        }

        [StringLength(30)]
        public string Symbol { get; set; }
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

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
        [Column(TypeName = "decimal(15,2)")]
        public decimal Open { get; set; }
        [Column(TypeName = "decimal(15,2)")]
        public decimal High { get; set; }
        [Column(TypeName = "decimal(15,2)")]
        public decimal Low { get; set; }
        [Column(TypeName = "decimal(15,2)")]
        public decimal Close { get; set; }
        [Column(TypeName = "decimal(15,2)")]
        public decimal AdjClose { get; set; }
        public Int64 Volume { get; set; }
        public Int64 UnadjustedVolume { get; set; }
        [Column(TypeName = "decimal(15,2)")]
        public decimal Change { get; set; }
        [Column(TypeName = "decimal(15,2)")]
        public decimal ChangePercent { get; set; }
        [Column(TypeName = "decimal(15,2)")]
        public decimal Vwap { get; set; }
        public string Label { get; set; }
        [Column(TypeName = "decimal(15,2)")]
        public decimal ChangeOverTime { get; set; }
    }
}

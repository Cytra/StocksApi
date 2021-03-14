using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Stocks.Data.Entities.DCF
{
    public class Historical_discounted_cash_flow_Entity : EntityBase
    {
        public Historical_discounted_cash_flow_Entity()
        {
            Created = DateTimeOffset.Now;
        }
        [StringLength(10)]
        public string Symbol { get; set; }
        public DateTime Date { get; set; }
        [JsonProperty("Stock Price")]
        [Column(TypeName = "decimal(15,2)")]
        public decimal StockPrice { get; set; }
        [Column(TypeName = "decimal(15,2)")]
        public decimal DCF { get; set; }
    }
}

using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;

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
        public decimal StockPrice { get; set; }
        public decimal DCF { get; set; }
    }
}

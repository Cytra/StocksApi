using System;
using Newtonsoft.Json;

namespace Stocks.Model.Fmp.DCF
{
    public class Historical_discounted_cash_flow_Model
    {
        public DateTime Date { get; set; }
        [JsonProperty("Stock Price")]
        public decimal? StockPrice { get; set; }
        public decimal? DCF { get; set; }
        public decimal? Ratio { get; set; }
    }
}

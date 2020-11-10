using Newtonsoft.Json;
using System;

namespace Stocks.Model.FMP.Requests.DCF
{
    public class Historical_discounted_cash_flow_Model
    {
        public DateTime Date { get; set; }
        [JsonProperty("Stock Price")]
        public decimal StockPrice { get; set; }
        public decimal DCF { get; set; }
    }
}

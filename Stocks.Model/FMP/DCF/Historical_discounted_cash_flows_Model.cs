using System.Collections.Generic;

namespace Stocks.Model.Fmp.DCF
{
    public class Historical_discounted_cash_flows_Model
    {
        public string symbol { get; set; }
        public List<Historical_discounted_cash_flow_Model> historicalDCF { get; set; }
    }
}

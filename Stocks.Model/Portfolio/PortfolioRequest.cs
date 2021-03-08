using System;
using System.Collections.Generic;
using System.Text;

namespace Stocks.Model.Portfolio
{
    public class PortfolioRequest
    {
        public string Ticker { get; set; }
        public decimal Amount { get; set; }
        public decimal BuyPrice { get; set; }
    }
}

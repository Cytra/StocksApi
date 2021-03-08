using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Stocks.Model.Portfolio
{
    public class PortfolioItem
    {
        public string Ticker { get; set; }
        public decimal BuyPrice { get; set; }
        public decimal Amount { get; set; }
        public decimal CurrentPrice { get; set; }
        [RegularExpression(@"^\d+\.\d{0,2}$")]
        public string Change { get; set; }
        public Guid StockId { get; set; }
        public DateTimeOffset? Deleted { get; set; }
    }
}

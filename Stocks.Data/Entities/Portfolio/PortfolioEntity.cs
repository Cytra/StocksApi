using System;
using System.ComponentModel.DataAnnotations;

namespace Stocks.Data.Entities.Portfolio
{
    public class PortfolioEntity : EntityBase
    {
        [StringLength(10)]
        public string Ticker { get; set; }
        public decimal Amount { get; set; }
        public decimal BuyPrice { get; set; }
        public Guid StockId { get; set; }
        public DateTimeOffset? Deleted { get; set; }
    }
}

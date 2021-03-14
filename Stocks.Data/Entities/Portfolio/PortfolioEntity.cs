using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Stocks.Data.Entities.Portfolio
{
    public class PortfolioEntity : EntityBase
    {
        [StringLength(10)]
        public string Ticker { get; set; }
        [Column(TypeName = "decimal(15,2)")]
        public decimal Amount { get; set; }
        [Column(TypeName = "decimal(15,2)")]
        public decimal BuyPrice { get; set; }
        public Guid StockId { get; set; }
        public DateTimeOffset? Deleted { get; set; }
    }
}

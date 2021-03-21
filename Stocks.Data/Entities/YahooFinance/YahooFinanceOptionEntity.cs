using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Stocks.Model.YahooFinance;

namespace Stocks.Data.Entities.YahooFinance
{
    public class YahooFinanceOptionEntity : EntityBase
    {
        [StringLength(20)]
        public string Ticker { get; set; }
        [StringLength(30)]
        public string OptionName { get; set; }
        [Column(TypeName = "decimal(15,2)")]
        public decimal StrikePrice { get; set; }
        public int OpenInterest { get; set; }
        public OptionType Type { get; set; }
    }
}

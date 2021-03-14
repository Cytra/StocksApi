using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Stocks.Data.Entities.Dividend
{
    public class DividendCalendarEntity : EntityBase
    {
        public DividendCalendarEntity()
        {
            Created = DateTimeOffset.Now;
        }
        public DateTime Date { get; set; }
        public string Label { get; set; }
        [Column(TypeName = "decimal(15,2)")]
        public decimal AdjDividend { get; set; }
        public string Symbol { get; set; }
        [Column(TypeName = "decimal(15,2)")]
        public decimal Dividend { get; set; }
        public DateTime? RecordDate { get; set; }
        public DateTime? PaymentDate { get; set; }
        public DateTime? DeclarationDate { get; set; }
        [Column(TypeName = "decimal(15,2)")]
        public decimal Price { get; set; }
    }
}

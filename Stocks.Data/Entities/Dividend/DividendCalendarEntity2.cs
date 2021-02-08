using System;
using System.Collections.Generic;
using System.Text;

namespace Stocks.Data.Entities.Dividend
{
    public class DividendCalendarEntity2 : EntityBase
    {
        public DividendCalendarEntity2()
        {
            Created = DateTimeOffset.Now;
        }
        public DateTime Date { get; set; }
        public string Label { get; set; }
        public decimal AdjDividend { get; set; }
        public string Symbol { get; set; }
        public decimal Dividend { get; set; }
        public DateTime? RecordDate { get; set; }
        public DateTime? PaymentDate { get; set; }
        public DateTime? DeclarationDate { get; set; }
    }
}

using System;

namespace Stocks.Model.Fmp.Dividend
{
    public class DividendCalendarItem
    {
        public DateTime Date { get; set; }
        public string Label { get; set; }
        public decimal? AdjDividend { get; set; }    
        public string Symbol { get; set; }
        public decimal? Dividend { get; set; }   
        public DateTime? RecordDate { get; set; }
        public DateTime? PaymentDate { get; set; }
        public DateTime? DeclarationDate { get; set; }
        public decimal? Price { get; set; }
    }
}

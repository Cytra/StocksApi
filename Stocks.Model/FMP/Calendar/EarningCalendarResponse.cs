using System;

namespace Stocks.Model.Fmp.Calendar
{
    public class EarningCalendarResponseItem
    {
        public DateTime date { get; set; }
        public string symbol { get; set; }
        public decimal? eps { get; set; }
        public decimal? epsEstimated { get; set; }
        public string time { get; set; }
        public decimal? revenue { get; set; }
        public decimal? revenueEstimated { get; set; }
    }
}

using System;

namespace Stocks.Model.Calendar
{
    public class EarningCalendarResponseItem
    {
        public DateTime date { get; set; }
        public string symbol { get; set; }
        public float? eps { get; set; }
        public float? epsEstimated { get; set; }
        public string time { get; set; }
        public float revenue { get; set; }
        public float revenueEstimated { get; set; }
    }
}

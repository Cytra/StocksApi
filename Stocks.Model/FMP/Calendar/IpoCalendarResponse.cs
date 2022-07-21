using System;

namespace Stocks.Model.Fmp.Calendar
{
    public class IpoCalendarResponse
    {
        public DateTime date { get; set; }
        public string company { get; set; }
        public string symbol { get; set; }
        public string exchange { get; set; }
        public string actions { get; set; }
        public int? shares { get; set; }
        public string priceRange { get; set; }
        public float? marketCap { get; set; }
    }
}

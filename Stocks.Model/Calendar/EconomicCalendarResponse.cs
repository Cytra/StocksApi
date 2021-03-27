using System;
using System.Collections.Generic;
using System.Text;

namespace Stocks.Model.Calendar
{
    public class EconomicCalendarResponse
    {
        public string _event { get; set; }
        public string date { get; set; }
        public string country { get; set; }
        public float? actual { get; set; }
        public float? previous { get; set; }
        public float? change { get; set; }
        public float? changePercentage { get; set; }
        public float? estimate { get; set; }
    }
}

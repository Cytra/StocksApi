using System;
using Newtonsoft.Json;

namespace Stocks.Model.Fmp.Calendar
{
    public class EconomicCalendarResponse
    {
        [JsonProperty("event")]
        public string _event { get; set; }
        public DateTime date { get; set; }
        public string country { get; set; }
        public float? actual { get; set; }
        public float? previous { get; set; }
        public float? change { get; set; }
        public float? changePercentage { get; set; }
        public float? estimate { get; set; }
    }
}

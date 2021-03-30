using System;

namespace Stocks.Model.EarningSurprice
{
    public class EarningSurprice
    {
        public DateTime date { get; set; }
        public string symbol { get; set; }
        public float? actualEarningResult { get; set; }
        public float? estimatedEarning { get; set; }
        public float? Dif { get; set; }
    }
}

using System;

namespace Stocks.Model.Fmp.PressReleases
{
    public class PressReleases
    {
        public string symbol { get; set; }
        public DateTime date { get; set; }
        public string title { get; set; }
        public string text { get; set; }
    }
}

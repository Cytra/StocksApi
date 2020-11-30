using System;

namespace Stocks.Model.Strategy
{
    public class StrategyRequest
    {
        public int Dividend { get; set; }
        public long MarketCapMoreThan { get; set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; }
        public string Sector { get; set; }
        public long VolumeMoreThan { get; set; }
    }
}

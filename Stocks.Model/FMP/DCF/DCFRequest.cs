using System;

namespace Stocks.Model.FMP.DCF
{
    public class DCFRequest
    {
        public string Sector { get; set; }
        public Int64 MarketCapMoreThan { get; set; }
        public Int64 VolumeMoreThan { get; set; }
        public int DividendMoreThan { get; set; }
    }
}

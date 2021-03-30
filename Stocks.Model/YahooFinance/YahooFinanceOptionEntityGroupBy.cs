using System;
using System.Collections.Generic;
using System.Text;

namespace Stocks.Model.YahooFinance
{
    public class YahooFinanceOptionEntityGroupBy
    {
        public string Ticker { get; set; }
        public DateTimeOffset Created { get; set; }
        public string DayOfWeek { get; set; }
        public int OpenInterestPut { get; set; }
        public int OpenInterestCall { get; set; }
        public decimal CallPutRatio { get; set; }
    }

    public class YahooFinanceOptionEntityGroupByItem
    {
        public DateTimeOffset Created { get; set; }
        public int OpenInterest { get; set; }
        public OptionType Type { get; set; }
    }

    public enum OptionType : byte
    {
        Call,
        Put
    }
}

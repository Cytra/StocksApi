using System;
using System.Collections.Generic;
using System.Text;

namespace Stocks.Core.Helpers
{
    public static class StockLists
    {
        public static List<string> OptionOpenInterestStockList = new List<string>()
        {
            "GME", "AMC", "ATOS","RKT", "DIS", "NOK", "EVFM"
        };

        public static List<string> TickerBlackList = new List<string>()
        {
            "OUT", "BE", "DD", "HOLD", "ALL", "ETFM", "FOR", "ARE", 
            "WELL", "GNUS", "FTOC", "RH" , "USA", "ITRM", "INSG",
            "VSTO", "ITM", "ATM", "LOVE", "TOUR", "MOON" ,"ANDA", "NOW",
            "SOS", "INVE", "ALUS"
        };

    }
}

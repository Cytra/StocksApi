using System;
using System.Collections.Generic;
using System.Text;

namespace Stocks.Model.SecFillings
{
    public class SecFillings
    {
        public string symbol { get; set; }
        public DateTime fillingDate { get; set; }
        public DateTime acceptedDate { get; set; }
        public string cik { get; set; }
        public string type { get; set; }
        public string link { get; set; }
        public string finalLink { get; set; }
    }
}

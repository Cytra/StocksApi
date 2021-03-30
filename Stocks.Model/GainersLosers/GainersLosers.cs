using System;
using System.Collections.Generic;
using System.Text;

namespace Stocks.Model.GainersLosers
{
    public class GainersLosers
    {
        public string ticker { get; set; }
        public float changes { get; set; }
        public string price { get; set; }
        public string changesPercentage { get; set; }
        public string companyName { get; set; }
    }
}

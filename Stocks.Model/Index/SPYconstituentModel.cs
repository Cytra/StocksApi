using System;

namespace Stocks.Model.Index
{
    public class SPYconstituentModel
    {
        public string DateAdded { get; set; }
        public string AddedSecurity { get; set; }
        public string RemovedTicker { get; set; }
        public string RemovedSecurity { get; set; }
        public DateTime Date { get; set; }
        public string Reason { get; set; }
        public string Symbol { get; set; }
    }
}

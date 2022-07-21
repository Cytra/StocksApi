namespace Stocks.Model.Fmp.GainersLosers
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

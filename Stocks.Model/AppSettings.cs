namespace Stocks.Model
{
    public class AppSettings
    {
        public string SqlConnectionString { get; set; }
        public string ApiToken { get; set; }
        public string MsTeamsWebHook { get; set; }
        public string ShortSqueezeCronExpression { get; set; }
    }
}

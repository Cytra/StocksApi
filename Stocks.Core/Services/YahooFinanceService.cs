using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Stocks.Core.Services
{
    public interface IYahooFinanceService
    {
        Task<string> GetStockOptionData(string ticker, string date);
    }

    public class YahooFinanceService : IYahooFinanceService
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public YahooFinanceService(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<string> GetStockOptionData(string ticker, string date)
        {
            var client = _httpClientFactory.CreateClient("yahooFinance");
            var httpRequest = new HttpRequestMessage(HttpMethod.Get, string.IsNullOrWhiteSpace(date) ? GetUrl(ticker) : GetUrl(ticker,date));
            using var response = await client.SendAsync(httpRequest, HttpCompletionOption.ResponseHeadersRead);
            var result = await response.Content.ReadAsStringAsync();
            return result;
        }

        private string GetUrl(string ticker)
        {
            return $"https://finance.yahoo.com/quote/{ticker}/options?p={ticker}";
        }

        private string GetUrl(string ticker, string date)
        {
            return $"https://finance.yahoo.com/quote/{ticker}/options?p={ticker}&date={date}";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Stocks.Model.Portfolio;
using Stocks.Model.Shared;
using Stocks.Model.YahooFinance;

namespace Stocks.Blazor.Services
{
    public class YahooFinanceOtherProvider : IYahooFinanceOtherProvider
    {
        private readonly HttpClient _httpClient;

        public YahooFinanceOtherProvider(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<List<YahooFinanceOptionEntityGroupBy>> GetOpenInterest(string ticker)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, $"/api/YahooFinance/OpenInterest?ticker={ticker}");
            using var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead);
            var result = await response.Content.ReadAsAsync<List<YahooFinanceOptionEntityGroupBy>>();
            return result;
        }

        public async Task<List<string>> GetOpenInterestStockList()
        {
            var request = new HttpRequestMessage(HttpMethod.Get, $"/api/YahooFinance/OpenInterestStocks");
            using var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead);
            var result = await response.Content.ReadAsAsync<List<string>>();
            return result;
        }
    }
}

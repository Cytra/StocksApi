using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Stocks.Model.Profile;

namespace Stocks.UI.Services
{
    public interface IUIStockService
    {
        Task<List<StockProfile>> GetStockProfile(string symbol);
    }
    public class IuiStockService : IUIStockService
    {
        private readonly HttpClient _httpClient;

        public IuiStockService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<StockProfile>> GetStockProfile(string symbol)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, $"/api/Stock/Profile?stock={symbol}");
            using var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead);
            var result = await response.Content.ReadAsAsync<List<StockProfile>>();
            return result;
        }
    }
}

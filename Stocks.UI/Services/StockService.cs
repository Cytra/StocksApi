using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Stocks.Model.Dividend;
using Stocks.Model.Portfolio;
using Stocks.Model.Profile;
using Stocks.Model.Shared;

namespace Stocks.UI.Services
{
    public class IuiStockService : IUIStockService
    {
        private readonly HttpClient _httpClient;

        public IuiStockService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<StockProfile>> GetStockProfile(string symbol)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, $"/api/Profile?stock={symbol}");
            using var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead);
            var result = await response.Content.ReadAsAsync<List<StockProfile>>();
            return result;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Stocks.Model.Profile;
using Stocks.Model.Screener;
using Stocks.Model.Shared;

namespace Stocks.Blazor.Services
{
    public class StockScreenerPrivider : IStockScreenerPrivider
    {
        private readonly HttpClient _httpClient;

        public StockScreenerPrivider(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<StockScreenerResponseList> GetStocks(StockScreenerRequest payload)
        {
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, "/api/Screen/Screen");
            request.Content = new StringContent(JsonConvert.SerializeObject(payload), Encoding.UTF8, "application/json");
            using var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead);
            var result = await response.Content.ReadAsAsync<StockScreenerResponseList>();
            return result;
        }
    }
}

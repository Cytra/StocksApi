using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Stocks.Model.FMP.StockPrice;
using Stocks.Model.Shared;

namespace Stocks.Blazor.Services
{
    public class StockPriceProvider : IStockPriceProvider
    {
        private readonly HttpClient _httpClient;

        public StockPriceProvider(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public Task<List<StockPriceItem>> GetStockPrices(List<string> symbols)
        {
            throw new NotImplementedException();
        }

        public async Task<List<StockPricesForUi>> GetPricesForUi(StockPricesForUiRequest payload)
        {
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, "/api/Price/StockPriceForUi");
            request.Content = new StringContent(JsonConvert.SerializeObject(payload), Encoding.UTF8, "application/json");
            using var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead);
            var result = await response.Content.ReadAsAsync<List<StockPricesForUi>>();
            return result;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Stocks.Model.FMP.StockPrice;
using Stocks.Model.Shared;

namespace Stocks.Blazor.Services
{
    public class StockPriceService : IStockPriceService
    {

        private readonly HttpClient _httpClient;

        public StockPriceService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public Task<List<StockPriceItem>> GetStockPrices(string symbol)
        {
            throw new NotImplementedException();
        }

        public Task<StockPriceHistoricSimple> GetHistoricSimplePrices(string symbol)
        {
            throw new NotImplementedException();
        }

        public Task<StockPriceHistoricList> GetHistoricPrices(string symbol, DateTime @from, DateTime to)
        {
            throw new NotImplementedException();
        }

        public async Task<StockPriceHistoric> GetHistoricPrices(string symbol)
        {
            var request = new HttpRequestMessage(HttpMethod.Post, $"/api/Price/StockPrice?ticker={symbol}");
            using var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead);
            var result = await response.Content.ReadAsAsync<StockPriceHistoric>();
            return result;
        }
    }
}

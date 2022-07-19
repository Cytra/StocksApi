using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using Stocks.Model;
using Stocks.Model.FMP.StockPrice;
using Stocks.Model.Shared;

namespace Stocks.Core.Services.StockPrice
{
    public class StockPriceService : IStockPriceService
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly AppSettings _settings;
        public StockPriceService(IHttpClientFactory httpClientFactory, IOptions<AppSettings> settings)
        {
            _httpClientFactory = httpClientFactory;
            _settings = settings.Value;
        }
        public async Task<List<StockPriceItem>> GetStockPrices(string symbol)
        {
            var httpClient = _httpClientFactory.CreateClient();
            var request = new HttpRequestMessage(HttpMethod.Get, GetStockPriceUrl(symbol));
            request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            using var response = await httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead);
            var stream = await response.Content.ReadAsStreamAsync();
            using StreamReader reader = new StreamReader(stream);
            using JsonTextReader jsonReader = new JsonTextReader(reader);
            JsonSerializer ser = new JsonSerializer();
            var result = ser.Deserialize<List<StockPriceItem>>(jsonReader);
            return result;
        }

        public async Task<StockPriceHistoricSimple> GetHistoricSimplePrices(string symbol)
        {
            var httpClient = _httpClientFactory.CreateClient();
            var request = new HttpRequestMessage(HttpMethod.Get, GetHistoricSimpleUrl(symbol));
            request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            using var response = await httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead);
            var stream = await response.Content.ReadAsStreamAsync();
            using StreamReader reader = new StreamReader(stream);
            using JsonTextReader jsonReader = new JsonTextReader(reader);
            JsonSerializer ser = new JsonSerializer();
            var result = ser.Deserialize<StockPriceHistoricSimple>(jsonReader);
            return result;
        }

        public async Task<StockPriceHistoricList> GetHistoricPrices(string symbol, DateTime from, DateTime to)
        {
            var httpClient = _httpClientFactory.CreateClient();
            var request = new HttpRequestMessage(HttpMethod.Get, GetHistoricUrl(symbol, from, to));
            request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            using var response = await httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead);
            var stream = await response.Content.ReadAsStreamAsync();
            using StreamReader reader = new StreamReader(stream);
            using JsonTextReader jsonReader = new JsonTextReader(reader);
            JsonSerializer ser = new JsonSerializer();
            var result = ser.Deserialize<StockPriceHistoricList>(jsonReader);
            return result;
        }

        public async Task<StockPriceHistoric> GetHistoricPrices(string symbol)
        {
            var httpClient = _httpClientFactory.CreateClient();
            var request = new HttpRequestMessage(HttpMethod.Get, GetHistoricSimpleUrl(symbol));
            request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            using var response = await httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead);
            var stream = await response.Content.ReadAsStreamAsync();
            using StreamReader reader = new StreamReader(stream);
            using JsonTextReader jsonReader = new JsonTextReader(reader);
            JsonSerializer ser = new JsonSerializer();
            var result = ser.Deserialize<StockPriceHistoric>(jsonReader);
            return result;
        }

        private string GetHistoricUrl(string symbol, in DateTime @from, in DateTime to)
        {
            var toDate = to.ToString("yyyy-MM-dd");
            var fromDate = @from.ToString("yyyy-MM-dd");
            var result = $"https://financialmodelingprep.com/api/v3/historical-price-full/{symbol}?from={fromDate}&to={toDate}&apikey={_settings.ApiToken}";
            return result;
        }

        private string GetStockPriceUrl(string symbol)
        {
            var result = $"https://financialmodelingprep.com/api/v3/quote-short/{symbol}?apikey={_settings.ApiToken}";
            return result;
        }

        private string GetHistoricSimpleUrl(string symbol)
        {
            var result = $"https://financialmodelingprep.com/api/v3/historical-price-full/{symbol}?apikey={_settings.ApiToken}";
            return result;
        }
    }
}

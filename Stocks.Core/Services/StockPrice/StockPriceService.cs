using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using Stocks.Model;
using Stocks.Model.StockPrice;

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

        private string GetStockPriceUrl(string symbol)
        {
            var result = $"https://financialmodelingprep.com/api/v3/quote-short/{symbol}?apikey={_settings.ApiToken}";
            return result;
        }
    }
}

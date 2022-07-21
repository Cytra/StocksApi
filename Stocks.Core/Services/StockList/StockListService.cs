using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using Stocks.Model;
using Stocks.Model.Fmp.DCF;
using Stocks.Model.Fmp.StockList;

namespace Stocks.Core.Services.StockList
{
    public class StockListService : IStockListService
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly AppSettings _settings;
        public StockListService(IHttpClientFactory httpClientFactory, IOptions<AppSettings> settings)
        {
            _httpClientFactory = httpClientFactory;
            _settings = settings.Value;
        }
        public async Task<List<StockScreenListItem>> GetSortedStocks(DCFRequest input)
        {
            var httpClient = _httpClientFactory.CreateClient();
            var request = new HttpRequestMessage(HttpMethod.Get, GetSortedStocksUrl(input));
            request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            using var response = await httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead);
            var stream = await response.Content.ReadAsStreamAsync();
            using StreamReader reader = new StreamReader(stream);
            using JsonTextReader jsonReader = new JsonTextReader(reader);
            JsonSerializer ser = new JsonSerializer();
            var result = ser.Deserialize<List<StockScreenListItem>>(jsonReader);
            return result;
        }

        private string GetSortedStocksUrl(DCFRequest input)
        {
            var result = "https://financialmodelingprep.com/api/v3/";
            result += $"stock-screener?marketCapMoreThan={input.MarketCapMoreThan.ToString()}";
            result += $"&betaMoreThan=1&volumeMoreThan={input.VolumeMoreThan}";
            if (!string.IsNullOrWhiteSpace(input.Sector))
            {
                result += $"&sector={input.Sector}";
            }
            result += $"&dividendMoreThan={input.DividendMoreThan.ToString()}";
            result += $"&apikey={_settings.ApiToken}";
            return result;
        }

        public async Task<List<StockListItem>> GetStockList()
        {
            var httpClient = _httpClientFactory.CreateClient();
            var request = new HttpRequestMessage(HttpMethod.Get, GetStockListUrl());
            request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            using var response = await httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead);
            var stream = await response.Content.ReadAsStreamAsync();
            using StreamReader reader = new StreamReader(stream);
            using JsonTextReader jsonReader = new JsonTextReader(reader);
            JsonSerializer ser = new JsonSerializer();
            var result = ser.Deserialize<List<StockListItem>>(jsonReader);
            return result;
        }

        private string GetStockListUrl()
        {
            var result = $"https://financialmodelingprep.com/api/v3/stock/list?apikey=" + _settings.ApiToken;
            return result;
        }
    }
}

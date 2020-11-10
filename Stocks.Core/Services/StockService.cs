using System.Collections.Generic;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using System.IO;
using Stocks.Model.FMP.Requests.StockList;
using Stocks.Model.Requests;

namespace Stocks.Core.Services
{
    public class StockService : IStockService
    {
        private const string Token1 = "3102ef91f3e039d1d49f03cb0537acab";

        private readonly IHttpClientFactory _httpClientFactory;
        public StockService(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
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
            var result = $"https://financialmodelingprep.com/api/v3/stock/list?apikey=" + Token1;
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
            result += $"&apikey={Token1}";
            return result;
        }
    }
}

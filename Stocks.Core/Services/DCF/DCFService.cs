using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using Stocks.Model;
using Stocks.Model.FMP.Dividend;

namespace Stocks.Core.Services.DCF
{
    public interface IDCFService
    {
        Task<List<DividendCalendarItem2>> GetDividendCalendar2(string symbol);
    }
    public class DCFService : IDCFService
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly AppSettings _settings;
        public DCFService(IHttpClientFactory httpClientFactory, IOptions<AppSettings> settings)
        {
            _httpClientFactory = httpClientFactory;
            _settings = settings.Value;
        }

        public async Task<List<DividendCalendarItem2>> GetDividendCalendar2(string symbol)
        {
            var httpClient = _httpClientFactory.CreateClient();
            var request = new HttpRequestMessage(HttpMethod.Get, GetStockDividendCalendar(symbol));
            request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            using var response = await httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead);
            var stream = await response.Content.ReadAsStreamAsync();
            using StreamReader reader = new StreamReader(stream);
            using JsonTextReader jsonReader = new JsonTextReader(reader);
            JsonSerializer ser = new JsonSerializer();
            var result = ser.Deserialize<List<DividendCalendarItem2>>(jsonReader);
            return result;
        }

        private string GetStockDividendCalendar(string symbol)
        {
            var result = $"https://financialmodelingprep.com/api/v3/historical-daily-discounted-cash-flow/{symbol}?limit=500&apikey={_settings.ApiToken}";
            return result;
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using Stocks.Model;
using Stocks.Model.Fmp.Dividend;

namespace Stocks.Core.Services.Dividend
{
    public class DividendCalendarService : IDividendCalendarService
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly AppSettings _settings;
        public DividendCalendarService(IHttpClientFactory httpClientFactory, IOptions<AppSettings> settings)
        {
            _httpClientFactory = httpClientFactory;
            _settings = settings.Value;
        }
        public async Task<List<DividendCalendarItem>> GetDividendCalendar(DividendCalendarRequest input)
        {
            var httpClient = _httpClientFactory.CreateClient();
            var request = new HttpRequestMessage(HttpMethod.Get, GetStockDividendCalendar(input));
            request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            using var response = await httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead);
            var stream = await response.Content.ReadAsStreamAsync();
            using StreamReader reader = new StreamReader(stream);
            using JsonTextReader jsonReader = new JsonTextReader(reader);
            JsonSerializer ser = new JsonSerializer();
            var result = ser.Deserialize<List<DividendCalendarItem>>(jsonReader);
            return result;
        }

        public async Task<List<DividendCalendarItem2>> GetDividendCalendar2(DividendCalendarRequest input)
        {
            var httpClient = _httpClientFactory.CreateClient();
            var request = new HttpRequestMessage(HttpMethod.Get, GetStockDividendCalendar(input));
            request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            using var response = await httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead);
            var stream = await response.Content.ReadAsStreamAsync();
            using StreamReader reader = new StreamReader(stream);
            using JsonTextReader jsonReader = new JsonTextReader(reader);
            JsonSerializer ser = new JsonSerializer();
            var result = ser.Deserialize<List<DividendCalendarItem2>>(jsonReader);
            return result;
        }

        private string GetStockDividendCalendar(DividendCalendarRequest input)
        {
            var result = $"https://financialmodelingprep.com/api/v3/stock_dividend_calendar?from={input.From.ToString("yyyy-MM-dd")}&to={input.To.ToString("yyyy-MM-dd")}&apikey={_settings.ApiToken}";
            return result;
        }
    }
}

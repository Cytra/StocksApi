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
using Stocks.Model.FinancialStatements;

namespace Stocks.Core.Services.FinancialStatements
{
    public class BalanceSheetService : IBalanceSheetService
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly AppSettings _settings;
        public BalanceSheetService(IHttpClientFactory httpClientFactory, IOptions<AppSettings> settings)
        {
            _httpClientFactory = httpClientFactory;
            _settings = settings.Value;
        }
        public async Task<List<BalanceSheet>> GetBalanceSheets(string symbol)
        {
            var httpClient = _httpClientFactory.CreateClient();
            var request = new HttpRequestMessage(HttpMethod.Get, GetUrl(symbol));
            request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            using var response = await httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead);
            var stream = await response.Content.ReadAsStreamAsync();
            using StreamReader reader = new StreamReader(stream);
            using JsonTextReader jsonReader = new JsonTextReader(reader);
            JsonSerializer ser = new JsonSerializer();
            var result = ser.Deserialize<List<BalanceSheet>>(jsonReader);
            return result;
        }

        private string GetUrl(string symbol)
        {
            var result = $"https://financialmodelingprep.com/api/v3/balance-sheet-statement/{symbol}?limit=10&apikey={_settings.ApiToken}";
            return result;
        }
    }
}

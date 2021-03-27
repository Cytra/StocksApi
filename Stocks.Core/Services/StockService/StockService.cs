using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;
using Stocks.Model;
using Stocks.Model.CompanyOutlook;
using Stocks.Model.Profile;
using Stocks.Model.Shared;

namespace Stocks.Core.Services.StockService
{
    public class StockService : IStockService
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly AppSettings _settings;
        public StockService(IHttpClientFactory httpClientFactory, IOptions<AppSettings> settings)
        {
            _httpClientFactory = httpClientFactory;
            _settings = settings.Value;
        }

        public async Task<List<StockProfile>> GetStockProfile(string symbol)
        {
            var httpClient = _httpClientFactory.CreateClient();
            var request = new HttpRequestMessage(HttpMethod.Get, GetUrlProfile(symbol));
            request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            using var response = await httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead);
            var result = await response.Content.ReadAsAsync<List<StockProfile>>();
            return result;
        }

        private string GetUrlProfile(string symbol)
        {
            var result = $"https://financialmodelingprep.com/api/v3/profile/{symbol}?apikey={_settings.ApiToken}";
            return result;
        }

        public async Task<CompanyOutlookModel> GetCompanyOutlook(string symbol)
        {
            var httpClient = _httpClientFactory.CreateClient();
            var request = new HttpRequestMessage(HttpMethod.Get, GetUrl(symbol));
            request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            using var response = await httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead);
            var result = await response.Content.ReadAsAsync<CompanyOutlookModel>();
            return result;
        }

        private string GetUrl(string symbol)
        {
            var result = $"https://financialmodelingprep.com/api/v4/company-outlook?symbol={symbol}&apikey={_settings.ApiToken}";
            return result;
        }
    }
}

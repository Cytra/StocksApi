using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;
using Stocks.Model;
using Stocks.Model.Fmp.CompanyOutlook;
using Stocks.Model.Fmp.DCF;
using Stocks.Model.Fmp.EarningSurprice;
using Stocks.Model.Fmp.GainersLosers;
using Stocks.Model.Fmp.KeyMetrics;
using Stocks.Model.Fmp.PressReleases;
using Stocks.Model.Fmp.Profile;
using Stocks.Model.Fmp.Rating;
using Stocks.Model.Fmp.SecFillings;
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

        public async Task<List<KeyMetrics>> GetKeyMetrics(string symbol)
        {
            var httpClient = _httpClientFactory.CreateClient();
            var request = new HttpRequestMessage(HttpMethod.Get, GetUrlKeyMetrics(symbol));
            request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            using var response = await httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead);
            var result = await response.Content.ReadAsAsync<List<KeyMetrics>>();
            return result;
        }

        public async Task<List<PressReleases>> GetPressReleases(string symbol)
        {
            var httpClient = _httpClientFactory.CreateClient();
            var request = new HttpRequestMessage(HttpMethod.Get, GetUrlPressReleases(symbol));
            request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            using var response = await httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead);
            var result = await response.Content.ReadAsAsync<List<PressReleases>>();
            return result;
        }

        public async Task<List<SecFillings>> GetSecFillings(string symbol)
        {
            var httpClient = _httpClientFactory.CreateClient();
            var request = new HttpRequestMessage(HttpMethod.Get, GetUrlSecFillings(symbol));
            request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            using var response = await httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead);
            var result = await response.Content.ReadAsAsync<List<SecFillings>>();
            return result;
        }

        public async Task<List<Historical_discounted_cash_flows_Model>> GetDCF(string symbol)
        {
            var httpClient = _httpClientFactory.CreateClient();
            var request = new HttpRequestMessage(HttpMethod.Get, GetUrlDCF(symbol));
            request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            using var response = await httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead);
            var result = await response.Content.ReadAsAsync<List<Historical_discounted_cash_flows_Model>>();
            return result;
        }

        public async Task<List<RatingHistoric>> Rating(string symbol)
        {
            var httpClient = _httpClientFactory.CreateClient();
            var request = new HttpRequestMessage(HttpMethod.Get, GetUrlRating(symbol));
            request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            using var response = await httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead);
            var result = await response.Content.ReadAsAsync<List<RatingHistoric>>();
            return result;
        }

        public async Task<List<EarningSurprice>> EarningsSurprises(string symbol)
        {
            var httpClient = _httpClientFactory.CreateClient();
            var request = new HttpRequestMessage(HttpMethod.Get, GetUrlEarningsSurprises(symbol));
            request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            using var response = await httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead);
            var result = await response.Content.ReadAsAsync<List<EarningSurprice>>();
            return result;
        }

        public async Task<List<Stocknew>> StockNews(string symbol)
        {
            var httpClient = _httpClientFactory.CreateClient();
            var request = new HttpRequestMessage(HttpMethod.Get, GetUrlNews(symbol));
            request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            using var response = await httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead);
            var result = await response.Content.ReadAsAsync<List<Stocknew>>();
            return result;
        }

        public async Task<List<GainersLosers>> Gainers()
        {
            var httpClient = _httpClientFactory.CreateClient();
            var request = new HttpRequestMessage(HttpMethod.Get, $"https://financialmodelingprep.com/api/v3/gainers?apikey={_settings.ApiToken}");
            request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            using var response = await httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead);
            var result = await response.Content.ReadAsAsync<List<GainersLosers>>();
            return result;
        }

        public async Task<List<GainersLosers>> Losers()
        {
            var httpClient = _httpClientFactory.CreateClient();
            var request = new HttpRequestMessage(HttpMethod.Get, $"https://financialmodelingprep.com/api/v3/losers?apikey={_settings.ApiToken}");
            request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            using var response = await httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead);
            var result = await response.Content.ReadAsAsync<List<GainersLosers>>();
            return result;
        }

        private string GetUrlNews(string symbol)
        {
            var result = $"https://financialmodelingprep.com/api/v3/stock_news?tickers={symbol}&limit=50&apikey={_settings.ApiToken}";
            return result;
        }

        private string GetUrlEarningsSurprises(string symbol)
        {
            var result = $"https://financialmodelingprep.com/api/v3/earnings-surprises/{symbol}?apikey={_settings.ApiToken}";
            return result;
        }

        private string GetUrlRating(string symbol)
        {
            var result = $"https://financialmodelingprep.com/api/v3/historical-rating/{symbol}?limit=100&apikey={_settings.ApiToken}";
            return result;
        }

        private string GetUrlDCF(string symbol)
        {
            var result = $"https://financialmodelingprep.com/api/v3/historical-discounted-cash-flow/{symbol}?period=quarter&apikey={_settings.ApiToken}";
            return result;
        }

        private string GetUrlSecFillings(string symbol)
        {
            var result = $"https://financialmodelingprep.com/api/v3/sec_filings/{symbol}?limit=200&apikey={_settings.ApiToken}";
            return result;
        }

        private string GetUrlPressReleases(string symbol)
        {
            var result = $"https://financialmodelingprep.com/api/v3/press-releases/{symbol}?limit=100&apikey={_settings.ApiToken}";
            return result;
        }

        private string GetUrlKeyMetrics(string symbol)
        {
            var result = $"https://financialmodelingprep.com/api/v3/key-metrics/{symbol}?limit=5&apikey={_settings.ApiToken}";
            return result;
        }
    }
}

using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Stocks.Model.CompanyOutlook;
using Stocks.Model.DCF;
using Stocks.Model.EarningSurprice;
using Stocks.Model.GainersLosers;
using Stocks.Model.KeyMetrics;
using Stocks.Model.PressReleases;
using Stocks.Model.Profile;
using Stocks.Model.Rating;
using Stocks.Model.SecFillings;

namespace Stocks.Blazor.Services
{
    public class IuiStockService : Model.Shared.IStockService
    {
        private readonly HttpClient _httpClient;

        public IuiStockService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<StockProfile>> GetStockProfile(string symbol)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, $"/api/Stock/Profile?stock={symbol}");
            using var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead);
            var result = await response.Content.ReadAsAsync<List<StockProfile>>();
            return result;
        }

        public async Task<CompanyOutlookModel> GetCompanyOutlook(string symbol)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, $"/api/Stock/CompanyOutlook?stock={symbol}");
            using var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead);
            var result = await response.Content.ReadAsAsync<CompanyOutlookModel>();
            return result;
        }

        public async Task<List<KeyMetrics>> GetKeyMetrics(string symbol)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, $"/api/Stock/KeyMetrics?stock={symbol}");
            using var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead);
            var result = await response.Content.ReadAsAsync<List<KeyMetrics>>();
            return result;
        }

        public async Task<List<PressReleases>> GetPressReleases(string symbol)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, $"/api/Stock/PressReleases?stock={symbol}");
            using var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead);
            var result = await response.Content.ReadAsAsync<List<PressReleases>>();
            return result;
        }

        public async Task<List<SecFillings>> GetSecFillings(string symbol)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, $"/api/Stock/SecFillings?stock={symbol}");
            using var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead);
            var result = await response.Content.ReadAsAsync<List<SecFillings>>();
            return result;
        }

        public async Task<List<Historical_discounted_cash_flows_Model>> GetDCF(string symbol)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, $"/api/Stock/Dcf?stock={symbol}");
            using var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead);
            var result = await response.Content.ReadAsAsync<List<Historical_discounted_cash_flows_Model>>();
            return result;
        }

        public async Task<List<RatingHistoric>> Rating(string symbol)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, $"/api/Stock/Rating?stock={symbol}");
            using var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead);
            var result = await response.Content.ReadAsAsync<List<RatingHistoric>>();
            return result;
        }

        public async Task<List<EarningSurprice>> EarningsSurprises(string symbol)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, $"/api/Stock/EarningsSurprises?stock={symbol}");
            using var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead);
            var result = await response.Content.ReadAsAsync<List<EarningSurprice>>();
            return result;
        }

        public async Task<List<Stocknew>> StockNews(string symbol)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, $"/api/Stock/StockNews?stock={symbol}");
            using var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead);
            var result = await response.Content.ReadAsAsync<List<Stocknew>>();
            return result;
        }

        public async Task<List<GainersLosers>> Gainers()
        {
            var request = new HttpRequestMessage(HttpMethod.Get, $"/api/Stock/Gainers");
            using var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead);
            var result = await response.Content.ReadAsAsync<List<GainersLosers>>();
            return result;
        }

        public async Task<List<GainersLosers>> Losers()
        {
            var request = new HttpRequestMessage(HttpMethod.Get, $"/api/Stock/Losers");
            using var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead);
            var result = await response.Content.ReadAsAsync<List<GainersLosers>>();
            return result;
        }
    }
}

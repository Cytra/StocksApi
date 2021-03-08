using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Stocks.Model.Portfolio;
using Stocks.Model.Profile;
using Stocks.Model.Shared;

namespace Stocks.UI.Services
{
    public class PortfolioProvider : IPortfolioProvider
    {
        private readonly HttpClient _httpClient;

        public PortfolioProvider(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<PortfolioItem>> AllPortfolio(bool withDeleted)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, $"/api/Portfolio/AllPortfolio?withDeleted={withDeleted}");
            using var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead);
            var result = await response.Content.ReadAsAsync<List<PortfolioItem>>();
            return result;
        }

        public async Task AddStock(PortfolioRequest payload)
        {
            var request = new HttpRequestMessage(HttpMethod.Post, $"/api/Portfolio/Stock");
            request.Content = JsonContent.Create(payload);
            using var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead);
        }

        public async Task DeleteStock(Guid stockId)
        {
            var request = new HttpRequestMessage(HttpMethod.Delete, $"/api/Portfolio/Stock?stockId={stockId}");
            using var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead);
        }
    }
}

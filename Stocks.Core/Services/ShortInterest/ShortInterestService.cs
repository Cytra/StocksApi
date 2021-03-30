using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Stocks.Core.Services.ShortInterest
{
    public interface IShortInterestService
    {
        Task<string> GetHighShortInterestData();
    }
    public class ShortInterestService : IShortInterestService
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public ShortInterestService(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<string> GetHighShortInterestData()
        {
            var client = _httpClientFactory.CreateClient("highInterest");
            var httpRequest = new HttpRequestMessage(HttpMethod.Get, "/all/1");
            using var response = await client.SendAsync(httpRequest, HttpCompletionOption.ResponseHeadersRead);
            var result = await response.Content.ReadAsStringAsync();
            return result;
        }
    }
}

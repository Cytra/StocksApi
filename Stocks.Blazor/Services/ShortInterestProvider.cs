using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Stocks.Core.Services.ShortInterest;
using Stocks.Model.Shared;
using Stocks.Model.ShortInterest;

namespace Stocks.Blazor.Services
{
    public class ShortInterestProvider : IShortInterestProvider
    {
        private readonly HttpClient _httpClient;

        public ShortInterestProvider(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<ShortInterest>> GetShortInterestList()
        {
            var request = new HttpRequestMessage(HttpMethod.Get, $"/api/ShortInterest/ShortInterest");
            using var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead);
            var result = await response.Content.ReadAsAsync<List<ShortInterest>>();
            return result;
        }
    }
}

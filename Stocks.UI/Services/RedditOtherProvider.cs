using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using Stocks.Model.Reddit;
using Stocks.Model.Shared;

namespace Stocks.UI.Services
{
    public class RedditOtherProvider : IRedditOtherProvider
    {
        private readonly HttpClient _httpClient;

        public RedditOtherProvider(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<RedditDdDtoList> GetDdList(RedditOtherRequest payload)
        {
            var request = new HttpRequestMessage(HttpMethod.Post, $"/api/Reddit/Dd");
            request.Content = JsonContent.Create(payload);
            using var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead);
            var result = await response.Content.ReadAsAsync<RedditDdDtoList>();
            return result;
        }
    }
}

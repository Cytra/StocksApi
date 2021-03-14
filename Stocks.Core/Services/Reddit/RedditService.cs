using System.Net.Http;
using System.Threading.Tasks;
using Stocks.Model.Reddit;

namespace Stocks.Core.Services.Reddit
{
    public interface IRedditService
    {
        Task<RedditDdResponse> GetLatestDd(RedditDbRequest request);
    }
    public class RedditService : IRedditService
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public RedditService(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<RedditDdResponse> GetLatestDd(RedditDbRequest request)
        {
            var client = _httpClientFactory.CreateClient();
            var httpRequest = new HttpRequestMessage(HttpMethod.Get, GetDdQueryString(request));
            using var response = await client.SendAsync(httpRequest, HttpCompletionOption.ResponseHeadersRead);
            var result = await response.Content.ReadAsAsync<RedditDdResponse>();
            return result;
        }

        private string GetDdQueryString(RedditDbRequest request)
        {
            var result = $"https://www.reddit.com/r/wallstreetbets/search.json?sort=new&t={request.SortType}&limit={request.Size}&q=flair%3ADD";
            return result;
        }
    }
}

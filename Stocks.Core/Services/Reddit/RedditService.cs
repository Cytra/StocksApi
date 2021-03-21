using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Stocks.Model.Reddit;

namespace Stocks.Core.Services.Reddit
{
    public interface IRedditService
    {
        Task<RedditDdResponse> GetLatestDd(RedditDbRequest request, string last);
    }
    public class RedditService : IRedditService
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public RedditService(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<RedditDdResponse> GetLatestDd(RedditDbRequest request, string last)
        {
            var client = _httpClientFactory.CreateClient();
            var httpRequest = new HttpRequestMessage(HttpMethod.Get, string.IsNullOrWhiteSpace(last) ? GetDdQueryString(request) : GetDdQueryString(request, last));
            using var response = await client.SendAsync(httpRequest, HttpCompletionOption.ResponseHeadersRead);
            var result = await response.Content.ReadAsAsync<RedditDdResponse>();
            return result;
        }

        private string GetDdQueryString(RedditDbRequest request)
        {
            var result = $"https://www.reddit.com/r/wallstreetbets/search.json?sort=new&t={request.SortType}&limit={request.Size}&q=flair%3ADD";
            return result;
        }

        private string GetDdQueryString(RedditDbRequest request, string after)
        {
            var result = $"https://www.reddit.com/r/wallstreetbets/search.json?sort=new&limit={request.Size}&q=flair%3ADD&after=t3_{after}";
            return result;
        }
    }
}

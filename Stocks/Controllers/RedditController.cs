using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Stocks.Core.Services.Reddit;
using Stocks.Model.Reddit;
using Stocks.Model.Shared;

namespace Stocks.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class RedditController : ControllerBase
    {
        private readonly IRedditOtherProvider _redditOtherProvider;
        public RedditController(IRedditOtherProvider redditOtherProvider)
        {
            _redditOtherProvider = redditOtherProvider;
        }

        [HttpPost]
        public async Task<RedditDdDtoList> Dd(RedditOtherRequest request)
        {
            var result = await _redditOtherProvider.GetDdList(request);
            return result;
        }

        [HttpGet]
        public async Task<RedditDdDto> Dd(int id)
        {
            var result = await _redditOtherProvider.GetDbItem(id);
            return result;
        }
    }
}

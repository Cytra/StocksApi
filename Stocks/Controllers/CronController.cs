using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Stocks.Core.Providers.SaveToDbProviders;
using Stocks.Model.Dividend;
using Stocks.Model.Reddit;

namespace Stocks.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class CronController : ControllerBase
    {
        private readonly IRedditDBProvider _redditDBProvider;
        public CronController(IRedditDBProvider redditDbProvider)
        {
            _redditDBProvider = redditDbProvider;
        }

        [HttpPost]
        public async Task<IActionResult> UpdateRedditDdDB(RedditDbRequest request)
        {
            await _redditDBProvider.GetDdList(request);
            return Ok();
        }
    }
}

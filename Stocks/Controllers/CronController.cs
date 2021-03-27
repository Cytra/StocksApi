using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Stocks.Core.Helpers;
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
        private readonly IYahooFinanceDbProvider _yahooFinanceDbProvider;
        public CronController(IRedditDBProvider redditDbProvider, IYahooFinanceDbProvider yahooFinanceDbProvider)
        {
            _redditDBProvider = redditDbProvider;
            _yahooFinanceDbProvider = yahooFinanceDbProvider;
        }

        [HttpPost]
        public async Task<IActionResult> UpdateRedditDdDB(RedditDbRequest request)
        {
            await _redditDBProvider.GetDdList(request);
            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> UpdateStockOptionOpenInterest()
        {
            //var tasks = StockLists.OptionOpenInterestStockList.Select(async stock =>
            //{
            //    await _yahooFinanceDbProvider.GetStockOptionOpenInterest(stock);
            //});
            //await Task.WhenAll(tasks);

            foreach (var stock in StockLists.OptionOpenInterestStockList)
            {

                await _yahooFinanceDbProvider.GetStockOptionOpenInterest(stock);
                Thread.Sleep(1000);
            }
            return Ok();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Stocks.Core.Helpers;
using Stocks.Core.Providers.Other;
using Stocks.Data.Entities.YahooFinance;
using Stocks.Model.Shared;
using Stocks.Model.YahooFinance;

namespace Stocks.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class YahooFinanceController : ControllerBase
    {
        private readonly IYahooFinanceOtherProvider _yahooFinanceOtherProvider;
        public YahooFinanceController(IYahooFinanceOtherProvider yahooFinanceOtherProvider)
        {
            _yahooFinanceOtherProvider = yahooFinanceOtherProvider;
        }

        [HttpGet]
        public async Task<List<YahooFinanceOptionEntityGroupBy>> OpenInterest(string ticker)
        {
            var result = await _yahooFinanceOtherProvider.GetOpenInterest(ticker);
            return result;
        }

        [HttpGet]
        public async Task<List<string>> OpenInterestStocks()
        {
            var result = await _yahooFinanceOtherProvider.GetOpenInterestStockList();
            return result;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Stocks.Core.Services.Screener;
using Stocks.Model.Screener;
using Stocks.Model.Shared;

namespace Stocks.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class ScreenController : ControllerBase
    {

        private readonly IStockScreenerPrivider _stockScreenerPrivider;
        public ScreenController(IStockScreenerPrivider stockScreenerPrivider)
        {
            _stockScreenerPrivider = stockScreenerPrivider;
        }

        [HttpPost]
        public async Task<StockScreenerResponseList> Screen(StockScreenerRequest request)
        {
            var result = await _stockScreenerPrivider.GetStocks(request);
            return result;
        }
    }
}

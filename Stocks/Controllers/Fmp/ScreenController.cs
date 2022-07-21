using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Stocks.Model.Fmp.Screener;
using Stocks.Model.Shared;

namespace Stocks.Controllers.Fmp
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

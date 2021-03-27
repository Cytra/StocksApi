using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Stocks.Core.Services.StockPrice;
using Stocks.Model.Shared;

namespace Stocks.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class PriceController : ControllerBase
    {
        private readonly IStockPriceService _stockPriceService;
        public PriceController(IStockPriceService stockPriceService)
        {
            _stockPriceService = stockPriceService;
        }

        [HttpPost]
        public async Task<IActionResult> StockPrice(string ticker)
        {
            var result = await _stockPriceService.GetHistoricPrices(ticker);
            return Ok(result);
        }
    }
}

using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Stocks.Core.Providers.Other;
using Stocks.Core.Services.StockPrice;
using Stocks.Model.Shared;
using Stocks.Model.StockPrice;

namespace Stocks.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class PriceController : ControllerBase
    {
        private readonly IStockPriceService _stockPriceService;
        public readonly IStockPriceProvider _stockPriceProvider;
        public PriceController(IStockPriceService stockPriceService, IStockPriceProvider stockPriceProvider)
        {
            _stockPriceService = stockPriceService;
            _stockPriceProvider = stockPriceProvider;
        }

        [HttpPost]
        public async Task<IActionResult> StockPrice(string ticker)
        {
            var result = await _stockPriceService.GetHistoricPrices(ticker);
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> StockPriceForUi(StockPricesForUiRequest request)
        {
            var result = await _stockPriceProvider.GetPricesForUi(request);
            return Ok(result);
        }
    }
}

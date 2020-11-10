using Microsoft.AspNetCore.Mvc;
using Stocks.Core.Providers;
using System.Threading.Tasks;
using Stocks.Model.Requests;
using Stocks.Core.Services;

namespace Stocks.Controllers
{
    [ApiController]
    [Route("api/[action]")]
    public class StocksController : ControllerBase
    {
        private readonly IDcfProvider _stockProvider;
        private readonly IStockService _stockService;
        public StocksController(IDcfProvider stockProvider, IStockService stockService)
        {
            _stockProvider = stockProvider;
            _stockService = stockService;
        }

        [HttpPost]
        public async Task<IActionResult> UpdateDCFs(DCFRequest request)
        {
            await _stockProvider.UpdateDCFs(request);
            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> GetSortedStockList(DCFRequest request)
        {
            var result = await _stockService.GetSortedStocks(request);
            return Ok(result.Count);  
        }

        [HttpGet]
        public async Task<IActionResult> GetStockList()
        {
            var result = await _stockService.GetStockList();
            return Ok(result.Count);
        }
    }
}

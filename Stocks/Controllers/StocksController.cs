using Microsoft.AspNetCore.Mvc;
using Stocks.Core.Providers;
using System.Threading.Tasks;
using Stocks.Core.Providers.SaveToDbProviders;
using Stocks.Core.Services.StockList;
using Stocks.Model.DCF;

namespace Stocks.Controllers
{
    //[ApiController]
    //[Route("api/[controller]/[action]")]
    public class StocksController : ControllerBase
    {
        private readonly IDcfProvider _stockProvider;
        private readonly IStockListService _stockListService;
        public StocksController(
            IDcfProvider stockProvider,
            IStockListService stockListService)
        {
            _stockProvider = stockProvider;
            _stockListService = stockListService;
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
            var result = await _stockListService.GetSortedStocks(request);
            return Ok(result.Count);  
        }

        [HttpGet]
        public async Task<IActionResult> GetStockList()
        {
            var result = await _stockListService.GetStockList();
            return Ok(result.Count);
        }
    }
}

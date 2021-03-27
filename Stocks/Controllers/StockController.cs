using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Stocks.Model.CompanyOutlook;
using Stocks.Model.Shared;

namespace Stocks.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class StockController : ControllerBase
    {
        private readonly IStockService _stockService;
        public StockController(IStockService stockService)
        {
            _stockService = stockService;
        }

        [HttpGet]
        public async Task<IActionResult> Profile(string stock)
        {
            var result = await _stockService.GetStockProfile(stock);
            return Ok(result);
        }

        [HttpGet]
        public async Task<CompanyOutlookModel> CompanyOutlook(string stock)
        {
            var result = await _stockService.GetCompanyOutlook(stock);
            return result;
        }
    }
}

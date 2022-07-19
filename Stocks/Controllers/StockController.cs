using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Stocks.Model.FMP.CompanyOutlook;
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

        [HttpGet]
        public async Task<IActionResult> KeyMetrics(string stock)
        {
            var result = await _stockService.GetKeyMetrics(stock);
            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> PressReleases(string stock)
        {
            var result = await _stockService.GetPressReleases(stock);
            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> SecFillings(string stock)
        {
            var result = await _stockService.GetSecFillings(stock);
            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> Dcf(string stock)
        {
            var result = await _stockService.GetDCF(stock);
            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> Rating(string stock)
        {
            var result = await _stockService.Rating(stock);
            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> EarningsSurprises(string stock)
        {
            var result = await _stockService.EarningsSurprises(stock);
            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> StockNews(string stock)
        {
            var result = await _stockService.StockNews(stock);
            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> Gainers()
        {
            var result = await _stockService.Gainers();
            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> Losers()
        {
            var result = await _stockService.Losers();
            return Ok(result);
        }
    }
}

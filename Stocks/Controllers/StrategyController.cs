using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Stocks.Core.Providers;
using Stocks.Core.Providers.SaveToDbProviders;
using Stocks.Core.Strategies;
using Stocks.Model.Dividend;
using Stocks.Model.Strategy;

namespace Stocks.Controllers
{
    //[ApiController]
    //[Route("api/[controller]/[action]")]
    public class StrategyController : ControllerBase
    {
        private readonly IMomentumStrategy _momentumStrategy;
        private readonly IDcfStrategy _dcfStrategy;
        private readonly IDividendProvider _dividendProvider;
        public StrategyController(IMomentumStrategy momentumStrategy, IDcfStrategy dcfStrategy, IDividendProvider dividendProvider)
        {
            _momentumStrategy = momentumStrategy;
            _dcfStrategy = dcfStrategy;
            _dividendProvider = dividendProvider;
        }

        [HttpPost]
        public async Task<IActionResult> GetMomentumStockPrices(StrategyRequest request)
        {
            var timer = new Stopwatch();
            timer.Start();
            await _momentumStrategy.GetStockPrices(request.Dividend, request.MarketCapMoreThan, request.From, request.To, request.Sector, request.VolumeMoreThan);
            timer.Stop();
            return Ok("Time taken: " + timer.Elapsed.ToString(@"m\:ss\.fff"));
        }

        [HttpPost]
        public async Task<IActionResult> GetDCFData(StrategyRequest request)
        {
            var timer = new Stopwatch(); 
            timer.Start();
            await _dcfStrategy.Get(request);
            timer.Stop();
            return Ok("Time taken: " + timer.Elapsed.ToString(@"m\:ss\.fff"));
        }

        [HttpPost]
        public async Task<IActionResult> DividendArbitrage(DividendCalendarRequest request)
        {
            var result = await _dividendProvider.GetDividendCalendarWithPrices(request);
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> DividendArbitrage2(DividendCalendarRequest request)
        {
            var timer = new Stopwatch();
            timer.Start();
            await _dividendProvider.GetDividendCalendarWithPrices2(request);
            timer.Stop();
            return Ok("Time taken: " + timer.Elapsed.ToString(@"m\:ss\.fff"));
        }
    }
}

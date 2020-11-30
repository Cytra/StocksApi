using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Stocks.Core.Strategies;
using Stocks.Model.Strategy;

namespace Stocks.Controllers
{
    [ApiController]
    [Route("api/[action]")]
    public class StrategyController : ControllerBase
    {
        private readonly IMomentumStrategy _momentumStrategy;
        private readonly IDcfStrategy _dcfStrategy;
        public StrategyController(IMomentumStrategy momentumStrategy, IDcfStrategy dcfStrategy)
        {
            _momentumStrategy = momentumStrategy;
            _dcfStrategy = dcfStrategy;
        }

        [HttpPost]
        public async Task<IActionResult> GetMomentumStockPrices(StrategyRequest request)
        {
            await _momentumStrategy.GetStockPrices(request.Dividend, request.MarketCapMoreThan, request.From, request.To, request.Sector, request.VolumeMoreThan);
            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> GetDCF(StrategyRequest request)
        {
            await _dcfStrategy.Get(request);
            return Ok();
        }
    }
}

using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Stocks.Core.Providers.SaveToDbProviders;

namespace Stocks.Controllers.Fmp
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class StockIndexController : ControllerBase
    {
        private readonly ISPYconstituentProvider _SPYconstituentProvider;
        public StockIndexController(ISPYconstituentProvider spYconstituentProvider)
        {
            _SPYconstituentProvider = spYconstituentProvider;
        }

        [HttpGet]
        public async Task<IActionResult> GetSpyHistory()
        {
            var result = await _SPYconstituentProvider.GetSpyHistory();
            return Ok(result);
        }
    }
}

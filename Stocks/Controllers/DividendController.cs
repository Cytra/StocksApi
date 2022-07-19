using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Stocks.Core.Providers;
using Stocks.Core.Providers.SaveToDbProviders;
using Stocks.Model.FMP.Dividend;

namespace Stocks.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class DividendController : ControllerBase
    {
        private readonly IDividendProvider _dividendProvider;
        public DividendController(IDividendProvider dividendProvider)
        {
            _dividendProvider = dividendProvider;
        }

        [HttpPost]
        public async Task<IActionResult> GetDividendCalendar(DividendCalendarRequest request)
        {
            var result = await _dividendProvider.GetDividendCalendar(request);
            return Ok(result);
        }
    }
}

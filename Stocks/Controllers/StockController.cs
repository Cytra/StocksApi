using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Stocks.Core.Services.Profile;

namespace Stocks.Controllers
{
    [ApiController]
    [Route("api/[action]")]
    public class StockController : ControllerBase
    {
        private readonly IProfileService _profileService;
        public StockController(IProfileService profileService)
        {
            _profileService = profileService;
        }

        [HttpGet]
        public async Task<IActionResult> Profile(string stock)
        {
            var result = await _profileService.GetStockProfile(stock);
            return Ok(result);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Razor;
using Stocks.Core.Providers;
using Stocks.Model.Portfolio;
using Stocks.Model.Shared;

namespace Stocks.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class PortfolioController : ControllerBase
    {
        private readonly IPortfolioProvider _portfolioProvider;
        public PortfolioController(IPortfolioProvider portfolioProvider)
        {
            _portfolioProvider = portfolioProvider;
        }

        [HttpGet]
        public async Task<IActionResult> AllPortfolio(bool withDeleted)
        {
            var result = await _portfolioProvider.AllPortfolio(withDeleted);
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Stock(PortfolioRequest request)
        {
            await _portfolioProvider.AddStock(request);
            return Ok();
        }

        [HttpDelete]
        public async Task<IActionResult> Stock(Guid stockId)
        {
            await _portfolioProvider.DeleteStock(stockId);
            return Ok();
        }
    }
}

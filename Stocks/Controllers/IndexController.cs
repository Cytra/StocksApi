using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Stocks.Core.Providers;
using Stocks.Core.Providers.SaveToDbProviders;

namespace Stocks.Controllers
{
    [ApiController]
    [Route("api/[action]")]
    public class IndexController : ControllerBase
    {
        private readonly ISPYconstituentProvider _SPYconstituentProvider;
        public IndexController(ISPYconstituentProvider spYconstituentProvider)
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

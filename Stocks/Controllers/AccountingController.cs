using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Stocks.Model.Dividend;

namespace Stocks.Controllers
{
    [ApiController]
    [Route("api/[action]")]
    public class AccountingController : ControllerBase
    {
        public AccountingController()
        {
            
        }

        [HttpPost]
        public async Task<IActionResult> Test()
        {

            return Ok();
        }
    }
}

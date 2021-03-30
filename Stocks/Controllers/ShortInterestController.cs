﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Stocks.Core.Providers.Other;
using Stocks.Model.Calendar;
using Stocks.Model.Shared;

namespace Stocks.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class ShortInterestController : ControllerBase
    {
        private readonly IShortInterestProvider _shortInterestProvider;
        public ShortInterestController(IShortInterestProvider shortInterestProvider)
        {
            _shortInterestProvider = shortInterestProvider;
        }

        [HttpGet]
        public async Task<IActionResult> ShortInterest()
        {
            var result = await _shortInterestProvider.GetShortInterestList();
            return Ok(result);
        }
    }
}

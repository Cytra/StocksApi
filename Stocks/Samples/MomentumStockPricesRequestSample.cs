using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Stocks.Model.Strategy;
using Swashbuckle.AspNetCore.Filters;

namespace Stocks.Samples
{
    public class MomentumStockPricesRequestSample : IMultipleExamplesProvider<StrategyRequest>
    {
        public IEnumerable<SwaggerExample<StrategyRequest>> GetExamples()
        {
            yield return SwaggerExample.Create("Tech", new StrategyRequest()
            {
                Dividend = 0,
                MarketCapMoreThan = 1000000,
                Sector = "Technology",
                VolumeMoreThan = 100000,
                From = DateTime.Now.AddDays(-20),
                To = DateTime.Now
            });

            yield return SwaggerExample.Create("All", new StrategyRequest()
            {
                Dividend = 0,
                MarketCapMoreThan = 1000000,
                Sector = null,
                VolumeMoreThan = 100000,
                From = DateTime.Now.AddDays(-20),
                To = DateTime.Now
            });
        }
    }
}

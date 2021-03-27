using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Stocks.Model.Screener;
using Swashbuckle.AspNetCore.Filters;

namespace Stocks.Samples
{
    public class StockScreenerRequestSample : IExamplesProvider<StockScreenerRequest>
    {
        public StockScreenerRequest GetExamples()
        {
            return new StockScreenerRequest()
            {
                MarketCapMoreThan =  100000000000,
                Sector = Sector.FinancialServices
            };
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Stocks.Model.Portfolio;
using Swashbuckle.AspNetCore.Filters;

namespace Stocks.Samples
{
    public class PortfolioRequestSample : IExamplesProvider<PortfolioRequest>
    {
        public PortfolioRequest GetExamples()
        {
            return new PortfolioRequest()
            {
                Amount = 10,
                BuyPrice = 134,
                Ticker = "AAPL"
            };
        }
    }
}

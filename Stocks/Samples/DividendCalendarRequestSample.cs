using System;
using System.Collections.Generic;
using Stocks.Model.Dividend;
using Swashbuckle.AspNetCore.Filters;

namespace Stocks.Samples
{
    public class DividendCalendarRequestSample : IMultipleExamplesProvider<DividendCalendarRequest>
    {
        public IEnumerable<SwaggerExample<DividendCalendarRequest>> GetExamples()
        {
            yield return SwaggerExample.Create("Sample", new DividendCalendarRequest()
            {
                From = DateTime.Now,
                To = DateTime.Now.AddDays(10)
            });
        }
    }
}

using System;
using System.Collections.Generic;
using Stocks.Model.FMP.Dividend;
using Swashbuckle.AspNetCore.Filters;

namespace Stocks.Samples
{
    public class DividendCalendarRequestSample : IMultipleExamplesProvider<DividendCalendarRequest>
    {
        public IEnumerable<SwaggerExample<DividendCalendarRequest>> GetExamples()
        {
            yield return SwaggerExample.Create("Month", new DividendCalendarRequest()
            {
                From = DateTime.Now,
                To = DateTime.Now.AddDays(30)
            });

            yield return SwaggerExample.Create("2 Month", new DividendCalendarRequest()
            {
                From = DateTime.Now,
                To = DateTime.Now.AddDays(60)
            });

            yield return SwaggerExample.Create("3 Month", new DividendCalendarRequest()
            {
                From = DateTime.Now,
                To = DateTime.Now.AddDays(90)
            });

            yield return SwaggerExample.Create("Month with past 2 weeks", new DividendCalendarRequest()
            {
                From = DateTime.Now.AddDays(-14),
                To = DateTime.Now.AddDays(30)
            });
        }
    }
}

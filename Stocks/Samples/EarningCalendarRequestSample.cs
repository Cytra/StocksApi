using System;
using System.Collections.Generic;
using Stocks.Model.Calendar;
using Stocks.Model.Strategy;
using Swashbuckle.AspNetCore.Filters;

namespace Stocks.Samples
{
    public class EarningCalendarRequestSample : IMultipleExamplesProvider<CalendarRequest>
    {
        public IEnumerable<SwaggerExample<CalendarRequest>> GetExamples()
        {
            yield return SwaggerExample.Create("Next 10 days", new CalendarRequest()
            {
                From = DateTime.Now,
                To = DateTime.Now.AddDays(10)
            });
            yield return SwaggerExample.Create("Past 10 days", new CalendarRequest()
            {
                From = DateTime.Now.AddDays(-10),
                To = DateTime.Now
            });
            yield return SwaggerExample.Create("Past 3 months", new CalendarRequest()
            {
                From = DateTime.Now.AddDays(-100),
                To = DateTime.Now
            });
        }
    }
}

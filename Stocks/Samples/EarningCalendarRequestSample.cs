using System;
using Stocks.Model.Calendar;
using Swashbuckle.AspNetCore.Filters;

namespace Stocks.Samples
{
    public class EarningCalendarRequestSample : IExamplesProvider<CalendarRequest>
    {
        public CalendarRequest GetExamples()
        {
            return new CalendarRequest()
            {
                From = DateTime.Now,
                To = DateTime.Now.AddDays(10)
            };
        }
    }
}

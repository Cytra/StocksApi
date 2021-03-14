using System;
using Stocks.Model.Reddit;
using Swashbuckle.AspNetCore.Filters;

namespace Stocks.Samples
{
    public class RedditOtherRequestSample : IExamplesProvider<RedditOtherRequest>
    {
        public RedditOtherRequest GetExamples()
        {
            return new RedditOtherRequest()
            {
                DateFrom = DateTime.Now.AddDays(-3),
                DateTo = DateTime.Now,
                Size = 100,
                RowsPerPage = 10,
                Page = 1,
            };
        }
    }

    public class RedditDbRequestSample : IExamplesProvider<RedditDbRequest>
    {
        public RedditDbRequest GetExamples()
        {
            return new RedditDbRequest()
            {
                SortType = RedditSortType.day,
                Size = 1000
            };
        }
    }
}

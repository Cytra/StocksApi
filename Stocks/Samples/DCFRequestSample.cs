using Swashbuckle.AspNetCore.Filters;
using System.Collections.Generic;
using Stocks.Model.DCF;

namespace Stocks.Samples
{
    //public class DCFRequestSample : IExamplesProvider<DCFRequest>
    //{
    //    public DCFRequest GetExamples()
    //    {
    //        return new DCFRequest()
    //        {
    //            DividendMoreThan = 0,
    //            MarketCapMoreThan = 1000000,
    //            Sector = "Technology",
    //            VolumeMoreThan = 100000
    //        };
    //    }
    //}

    public class DCFRequestSample : IMultipleExamplesProvider<DCFRequest>
    {
        public IEnumerable<SwaggerExample<DCFRequest>> GetExamples()
        {
            yield return SwaggerExample.Create("Tech", new DCFRequest()
            {
                DividendMoreThan = 0,
                MarketCapMoreThan = 1000000,
                Sector = "Technology",
                VolumeMoreThan = 100000
            });

            yield return SwaggerExample.Create("All", new DCFRequest()
            {
                DividendMoreThan = 0,
                MarketCapMoreThan = 1000000,
                VolumeMoreThan = 100000
            });
        }
    }
}

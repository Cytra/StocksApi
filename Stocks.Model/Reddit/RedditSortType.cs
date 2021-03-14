using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Stocks.Model.Reddit
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum RedditSortType
    {
        hour,
        day,
        week,
        month,
        year,
        all
    }
}

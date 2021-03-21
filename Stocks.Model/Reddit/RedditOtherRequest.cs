using System;
using System.ComponentModel.DataAnnotations;

namespace Stocks.Model.Reddit
{
    public class RedditOtherRequest : UtcFilterBase
    {
        [Required]
        public int Size { get; set; }
    }

    public class RedditDbRequest
    {
        [Required] public RedditSortType SortType { get; set; }
        public int Size { get; set; }
        public DateTimeOffset After { get; set; }
    }
}

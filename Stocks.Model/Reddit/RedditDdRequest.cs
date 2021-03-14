using System;
using System.ComponentModel.DataAnnotations;

namespace Stocks.Model.Reddit
{
    public class RedditDdRequest : UtcFilterBase
    {
        [Required]
        public int Size { get; set; }
    }
}

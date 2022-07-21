using System;
using System.ComponentModel.DataAnnotations;

namespace Stocks.Model.Fmp.Dividend
{
    public class DividendCalendarRequest
    {
        [Required]
        public DateTime From { get; set; }
        [Required]
        public DateTime To { get; set; }
    }
}

using System;
using System.ComponentModel.DataAnnotations;

namespace Stocks.Model.Fmp.Calendar
{
    public class CalendarRequest
    {
        [Required]
        public DateTime From { get; set; }
        [Required]
        public DateTime To { get; set; }
    }
}

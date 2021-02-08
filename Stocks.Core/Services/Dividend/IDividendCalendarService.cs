using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Stocks.Model.Dividend;

namespace Stocks.Core.Services.Dividend
{
    public interface IDividendCalendarService
    {
        Task<List<DividendCalendarItem>> GetDividendCalendar(DividendCalendarRequest request);
        Task<List<DividendCalendarItem2>> GetDividendCalendar2(DividendCalendarRequest input);
    }
}

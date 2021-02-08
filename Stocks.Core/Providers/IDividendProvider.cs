using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Stocks.Model.Dividend;

namespace Stocks.Core.Providers
{
    public interface IDividendProvider
    {
        Task<List<DividendCalendarItem>> GetDividendCalendar(DividendCalendarRequest request);
        Task<List<DividendCalendarItem>> GetDividendCalendarWithPrices(DividendCalendarRequest request);
        Task GetDividendCalendarWithPrices2(DividendCalendarRequest request);
    }
}

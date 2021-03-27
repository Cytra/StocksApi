using System.Collections.Generic;
using System.Threading.Tasks;
using Stocks.Model.Calendar;

namespace Stocks.Model.Shared
{
    public interface ICalendarService
    {
        Task<List<EarningCalendarResponseItem>> GetEarningsCalendar(CalendarRequest request);
        Task<List<IpoCalendarResponse>> GetIpoCalendar(CalendarRequest request);
        Task<List<EconomicCalendarResponse>> GetEconomicCalendar(CalendarRequest request);
    }
}

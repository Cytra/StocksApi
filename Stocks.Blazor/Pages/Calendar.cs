using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Stocks.Model.Calendar;
using Stocks.Model.Shared;

namespace Stocks.Blazor.Pages
{
    public partial class Calendar
    {
        [Inject] 
        public ICalendarService CalendarService { get; set; }
        public List<EarningCalendarResponseItem> Earnings { get; set; }
        public List<IpoCalendarResponse> Ipos { get; set; }
        public List<EconomicCalendarResponse> Economics { get; set; }

        protected override async Task OnInitializedAsync()
        {
            var request = new CalendarRequest()
            {
                From = DateTime.Now.AddDays(-1),
                To = DateTime.Now.AddDays(1)
            };
            Earnings = await CalendarService.GetEarningsCalendar(request);
            Ipos = await CalendarService.GetIpoCalendar(request);
            Economics = await CalendarService.GetEconomicCalendar(request);
        }
    }
}

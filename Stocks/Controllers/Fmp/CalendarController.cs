using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Stocks.Model.Fmp.Calendar;
using Stocks.Model.Shared;

namespace Stocks.Controllers.Fmp;

[ApiController]
[Route("api/[controller]/[action]")]
public class CalendarController : ControllerBase

{
    private readonly ICalendarService _calendarService;

    public CalendarController(ICalendarService calendarService)
    {
        _calendarService = calendarService;
    }

    [HttpPost]
    public async Task<IActionResult> GetEarningCalendar(CalendarRequest request)
    {
        var result = await _calendarService.GetEarningsCalendar(request);
        return Ok(result);
    }

    [HttpPost]
    public async Task<IActionResult> GetIpoCalendar(CalendarRequest request)
    {
        var result = await _calendarService.GetIpoCalendar(request);
        return Ok(result);
    }

    [HttpPost]
    public async Task<IActionResult> GetEconomicCalendar(CalendarRequest request)
    {
        var result = await _calendarService.GetEconomicCalendar(request);
        return Ok(result);
    }
}
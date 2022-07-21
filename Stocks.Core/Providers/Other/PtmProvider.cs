using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stocks.Model.Fmp.Calendar;
using Stocks.Model.Shared;

namespace Stocks.Core.Providers.Other
{
    public class PtmProvider : IPtmProvider
    {
        private readonly ICalendarService _calendarService;
        public PtmProvider(ICalendarService calendarService)
        {
            _calendarService = calendarService;
        }

        public async Task<List<EconomicCalendarResponse>> GetIsmPmisManufacturing(CalendarRequest request)
        {
            var requestResult = await _calendarService.GetEconomicCalendar(request);
            return requestResult.Where(x => x._event == "ISM Manufacturing PMI").ToList();
        }

        public async Task<List<EconomicCalendarResponse>> GetIsmPmisServices(CalendarRequest request)
        {
            var requestResult = await _calendarService.GetEconomicCalendar(request);
            return requestResult.Where(x => x._event == "ISM Services PMI").ToList();
        }

        public async Task<List<EconomicCalendarResponse>> ConsumerSentimentMichigan(CalendarRequest request)
        {
            var requestResult = await _calendarService.GetEconomicCalendar(request);
            return requestResult.Where(x => x._event == "Michigan Consumer Sentiment Index").ToList();
        }

        public async Task<List<EconomicCalendarResponse>> BuildingPermits(CalendarRequest request)
        {
            var requestResult = await _calendarService.GetEconomicCalendar(request);
            return requestResult.Where(x => x._event == "Building Permits (MoM)" && x.country == "US").ToList();
        }

        public async Task<List<EconomicCalendarResponse>> NonfarmPayrolls(CalendarRequest request)
        {
            var requestResult = await _calendarService.GetEconomicCalendar(request);
            return requestResult.Where(x => x._event == "Nonfarm Payrolls").ToList();
        }

        public async Task<List<EconomicCalendarResponse>> UnemploymentRate(CalendarRequest request)
        {
            var requestResult = await _calendarService.GetEconomicCalendar(request);
            return requestResult.Where(x => x._event == "Unemployment Rate" && x.country == "US").ToList();
        }

        public async Task<List<EconomicCalendarResponse>> DurableGoods(CalendarRequest request)
        {
            var requestResult = await _calendarService.GetEconomicCalendar(request);
            return requestResult.Where(x => x._event.Contains("Durable Goods Orders")).ToList();
        }

        public async Task<List<EconomicCalendarResponse>> Gdp(CalendarRequest request)
        {
            var requestResult = await _calendarService.GetEconomicCalendar(request);
            return requestResult.Where(x => x._event.Contains("Gross Domestic Product") && x.country == "US").ToList();
        }

        public async Task<List<EconomicCalendarResponse>> UnemploymentRateCH(CalendarRequest request)
        {
            var requestResult = await _calendarService.GetEconomicCalendar(request);
            return requestResult.Where(x => x._event.Contains("Unemployment Rate") && x.country == "CH").ToList();
        }

        public async Task<List<EconomicCalendarResponse>> PmiCH(CalendarRequest request)
        {
            var requestResult = await _calendarService.GetEconomicCalendar(request);
            return requestResult.Where(x => x._event.Contains("Purchasing Managers") && x.country == "CH").ToList();
        }

        public async Task<List<EconomicCalendarResponse>> GdpCH(CalendarRequest request)
        {
            var requestResult = await _calendarService.GetEconomicCalendar(request);
            return requestResult.Where(x => x._event.Contains("Gross Domestic Product") && x.country == "CH").ToList();
        }

        public async Task<List<EconomicCalendarResponse>> LeadingIndicatorsCh(CalendarRequest request)
        {
            var requestResult = await _calendarService.GetEconomicCalendar(request);
            return requestResult.Where(x => x._event == "KOF Leading Indicator" && x.country == "CH").ToList();
        }

        public async Task<List<EconomicCalendarResponse>> MarkitServicesPmiEU(CalendarRequest request)
        {
            var requestResult = await _calendarService.GetEconomicCalendar(request);
            return requestResult.Where(x => x._event == "Markit Services PMI" && x.country == "EU").ToList();
        }

        public async Task<List<EconomicCalendarResponse>> UnemploymentRateEU(CalendarRequest request)
        {
            var requestResult = await _calendarService.GetEconomicCalendar(request);
            return requestResult.Where(x => x._event == "Unemployment Rate" && x.country == "EU").ToList();
        }

        public async Task<List<EconomicCalendarResponse>> MarkitManufacturingPmiEU(CalendarRequest request)
        {
            var requestResult = await _calendarService.GetEconomicCalendar(request);
            return requestResult.Where(x => x._event == "Markit Manufacturing PMI" && x.country == "EU").ToList();
        }

        public async Task<List<EconomicCalendarResponse>> M3MoneySupplyEU(CalendarRequest request)
        {
            var requestResult = await _calendarService.GetEconomicCalendar(request);
            return requestResult.Where(x => x._event.Contains("M3 Money Supply") && x.country == "EU").ToList();
        }

        public async Task<List<EconomicCalendarResponse>> ConsumerConfidenceEU(CalendarRequest request)
        {
            var requestResult = await _calendarService.GetEconomicCalendar(request);
            return requestResult.Where(x => x._event == "Consumer Confidence" && x.country == "EU").ToList();
        }
    }
}

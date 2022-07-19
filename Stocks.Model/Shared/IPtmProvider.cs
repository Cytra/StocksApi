using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Stocks.Model.FMP.Calendar;

namespace Stocks.Model.Shared
{
    public interface IPtmProvider
    {
        Task<List<EconomicCalendarResponse>> GetIsmPmisManufacturing(CalendarRequest request);
        Task<List<EconomicCalendarResponse>> GetIsmPmisServices(CalendarRequest request);
        Task<List<EconomicCalendarResponse>> ConsumerSentimentMichigan(CalendarRequest request);
        Task<List<EconomicCalendarResponse>> BuildingPermits(CalendarRequest request);
        Task<List<EconomicCalendarResponse>> NonfarmPayrolls(CalendarRequest request);
        Task<List<EconomicCalendarResponse>> UnemploymentRate(CalendarRequest request);
        Task<List<EconomicCalendarResponse>> DurableGoods(CalendarRequest request);
        Task<List<EconomicCalendarResponse>> Gdp(CalendarRequest request);
        Task<List<EconomicCalendarResponse>> UnemploymentRateCH(CalendarRequest request);
        Task<List<EconomicCalendarResponse>> PmiCH(CalendarRequest request);
        Task<List<EconomicCalendarResponse>> GdpCH(CalendarRequest request);
        Task<List<EconomicCalendarResponse>> LeadingIndicatorsCh(CalendarRequest request);
        Task<List<EconomicCalendarResponse>> MarkitServicesPmiEU(CalendarRequest request);
        Task<List<EconomicCalendarResponse>> UnemploymentRateEU(CalendarRequest request);
        Task<List<EconomicCalendarResponse>> MarkitManufacturingPmiEU(CalendarRequest request);
        Task<List<EconomicCalendarResponse>> M3MoneySupplyEU(CalendarRequest request);
        Task<List<EconomicCalendarResponse>> ConsumerConfidenceEU(CalendarRequest request);
    }
}

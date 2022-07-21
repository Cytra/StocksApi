using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Stocks.Model.Fmp.Calendar;
using Stocks.Model.Shared;

namespace Stocks.Blazor.Pages
{
    public partial class Calendar
    {
        [Inject] 
        public ICalendarService CalendarService { get; set; }
        [Inject] 
        public IPtmProvider PtmProvider { get; set; }
        public List<EarningCalendarResponseItem> Earnings { get; set; }
        public List<IpoCalendarResponse> Ipos { get; set; }
        public List<EconomicCalendarResponse> Economics { get; set; }
        public List<EconomicCalendarResponse> IsmPmisManufacturing { get; set; }
        public List<EconomicCalendarResponse> IsmPmisServices { get; set; }
        public List<EconomicCalendarResponse> ConsumerSentimentMichigan { get; set; }
        public List<EconomicCalendarResponse> BuildingPermits { get; set; }
        public List<EconomicCalendarResponse> NonfarmPayrolls { get; set; }
        public List<EconomicCalendarResponse> UnemploymentRate { get; set; }
        public List<EconomicCalendarResponse> DurableGoods { get; set; }
        public List<EconomicCalendarResponse> Gdp { get; set; }
        public List<EconomicCalendarResponse> UnemploymentRateCH { get; set; }
        public List<EconomicCalendarResponse> PmiCH { get; set; }
        public List<EconomicCalendarResponse> GdpCH { get; set; }
        public List<EconomicCalendarResponse> LeadingIndicatorsCh { get; set; }
        public List<EconomicCalendarResponse> MarkitServicesPmiEU { get; set; }
        public List<EconomicCalendarResponse> UnemploymentRateEU { get; set; }
        public List<EconomicCalendarResponse> MarkitManufacturingPmiEU { get; set; }
        public List<EconomicCalendarResponse> M3MoneySupplyEU { get; set; }
        public List<EconomicCalendarResponse> ConsumerConfidenceEU { get; set; }

        protected override async Task OnInitializedAsync()
        {
            var request = new CalendarRequest()
            {
                From = DateTime.Now.AddDays(-1),
                To = DateTime.Now.AddDays(1)
            };
            Earnings = await CalendarService.GetEarningsCalendar(new CalendarRequest()
            {
                From = DateTime.Now.AddDays(-3),
                To = DateTime.Now
            });
            Ipos = await CalendarService.GetIpoCalendar(request);
            Economics = await CalendarService.GetEconomicCalendar(request);
            var ptmInput = new CalendarRequest()
            {
                From = DateTime.Now.AddDays(-100),
                To = DateTime.Now
            };
            var ismPmisManufacturing = await PtmProvider.GetIsmPmisManufacturing(ptmInput);
            if(ismPmisManufacturing != null && ismPmisManufacturing.Count > 0)
                IsmPmisManufacturing = ismPmisManufacturing.OrderByDescending(x => x.date).ToList();

            var ismPmisServices = await PtmProvider.GetIsmPmisServices(ptmInput);
            if (ismPmisServices != null && ismPmisServices.Count > 0)
                IsmPmisServices = ismPmisServices.OrderByDescending(x => x.date).ToList();

            var consumerSentimentMichigan = await PtmProvider.ConsumerSentimentMichigan(ptmInput);
            if (consumerSentimentMichigan != null && consumerSentimentMichigan.Count > 0)
                ConsumerSentimentMichigan = consumerSentimentMichigan.OrderByDescending(x => x.date).ToList();
            
            var buildingPermits = await PtmProvider.BuildingPermits(ptmInput);
            if (buildingPermits != null && buildingPermits.Count > 0)
                BuildingPermits = buildingPermits.OrderByDescending(x => x.date).ToList();
            
            var nonfarmPayrolls = await PtmProvider.NonfarmPayrolls(ptmInput);
            if (nonfarmPayrolls != null && nonfarmPayrolls.Count > 0)
                NonfarmPayrolls = nonfarmPayrolls.OrderByDescending(x => x.date).ToList();
            
            var unemploymentRate = await PtmProvider.UnemploymentRate(ptmInput);
            if (unemploymentRate != null && unemploymentRate.Count > 0) 
                UnemploymentRate = unemploymentRate.OrderByDescending(x => x.date).ToList();
            
            var durableGoods = await PtmProvider.DurableGoods(ptmInput);
            if (durableGoods != null && durableGoods.Count > 0) 
                DurableGoods = durableGoods.OrderByDescending(x => x.date).ToList();
            
            var gdp = await PtmProvider.Gdp(ptmInput);
            if (gdp != null && gdp.Count > 0)
                Gdp = gdp.OrderByDescending(x => x.date).ToList();

            var unemploymentRateCH = await PtmProvider.UnemploymentRateCH(ptmInput);
            if (unemploymentRateCH != null && unemploymentRateCH.Count > 0) 
                UnemploymentRateCH = unemploymentRateCH.OrderByDescending(x => x.date).ToList();
            
            var pmiCH = await PtmProvider.PmiCH(ptmInput);
            if (pmiCH != null && pmiCH.Count > 0) 
                PmiCH = pmiCH.OrderByDescending(x => x.date).ToList();

            var gdpCH = await PtmProvider.GdpCH(ptmInput);
            if (gdpCH != null && gdpCH.Count > 0) 
                GdpCH = gdpCH.OrderByDescending(x => x.date).ToList();

            var leadingIndicatorsCh = await PtmProvider.LeadingIndicatorsCh(ptmInput);
            if (leadingIndicatorsCh != null && leadingIndicatorsCh.Count > 0) 
                LeadingIndicatorsCh = leadingIndicatorsCh.OrderByDescending(x => x.date).ToList();
            
            var markitServicesPmiEU = await PtmProvider.MarkitServicesPmiEU(ptmInput);
            if (markitServicesPmiEU != null && markitServicesPmiEU.Count > 0) 
                MarkitServicesPmiEU = markitServicesPmiEU.OrderByDescending(x => x.date).ToList();
            
            var unemploymentRateEU = await PtmProvider.UnemploymentRateEU(ptmInput);
            if (unemploymentRateEU != null &&  unemploymentRateEU.Count > 0) 
                UnemploymentRateEU = unemploymentRateEU.OrderByDescending(x => x.date).ToList();
            
            var markitManufacturingPmiEU = await PtmProvider.MarkitManufacturingPmiEU(ptmInput);
            if (markitManufacturingPmiEU != null &&  markitManufacturingPmiEU.Count > 0) 
                MarkitManufacturingPmiEU = markitManufacturingPmiEU.OrderByDescending(x => x.date).ToList();
            
            var m3MoneySupplyEU = await PtmProvider.M3MoneySupplyEU(ptmInput);
            if (m3MoneySupplyEU != null &&  m3MoneySupplyEU.Count > 0) 
                M3MoneySupplyEU = m3MoneySupplyEU.OrderByDescending(x => x.date).ToList();
            
            var consumerConfidenceEU = await PtmProvider.ConsumerConfidenceEU(ptmInput);
            if (consumerConfidenceEU != null && consumerConfidenceEU.Count > 0) 
                ConsumerConfidenceEU = consumerConfidenceEU.OrderByDescending(x => x.date).ToList();
        }
    }
}

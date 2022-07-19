using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;
using Stocks.Model;
using Stocks.Model.FMP.Calendar;
using Stocks.Model.Shared;

namespace Stocks.Core.Services.Calendar
{
    public class CalendarService : ICalendarService
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly AppSettings _settings;
        public CalendarService(IHttpClientFactory httpClientFactory, IOptions<AppSettings> settings)
        {
            _httpClientFactory = httpClientFactory;
            _settings = settings.Value;
        }
        public async Task<List<EarningCalendarResponseItem>> GetEarningsCalendar(CalendarRequest request)
        {
            var client = _httpClientFactory.CreateClient();
            var httpRequest = new HttpRequestMessage(HttpMethod.Get, GetEarningsCalendarUrl(request));
            using var response = await client.SendAsync(httpRequest, HttpCompletionOption.ResponseHeadersRead);
            var result = await response.Content.ReadAsAsync<List<EarningCalendarResponseItem>>();
            return result;
        }

        public async Task<List<IpoCalendarResponse>> GetIpoCalendar(CalendarRequest request)
        {
            var client = _httpClientFactory.CreateClient();
            var httpRequest = new HttpRequestMessage(HttpMethod.Get, GetIpoCalendarUrl(request));
            using var response = await client.SendAsync(httpRequest, HttpCompletionOption.ResponseHeadersRead);
            var result = await response.Content.ReadAsAsync<List<IpoCalendarResponse>>();
            return result;
        }

        public async Task<List<EconomicCalendarResponse>> GetEconomicCalendar(CalendarRequest request)
        {
            var client = _httpClientFactory.CreateClient();
            var httpRequest = new HttpRequestMessage(HttpMethod.Get, GetEconomicCalendarUrl(request));
            using var response = await client.SendAsync(httpRequest, HttpCompletionOption.ResponseHeadersRead);
            var result = await response.Content.ReadAsAsync<List<EconomicCalendarResponse>>();
            return result;
        }

        private string GetEconomicCalendarUrl(CalendarRequest input)
        {
            var result = $"https://financialmodelingprep.com/api/v3/economic_calendar?from={input.From.ToString("yyyy-MM-dd")}&to={input.To.ToString("yyyy-MM-dd")}&apikey={_settings.ApiToken}";
            return result;
        }

        private string GetIpoCalendarUrl(CalendarRequest input)
        {
            var result = $"https://financialmodelingprep.com/api/v3/ipo_calendar?from={input.From.ToString("yyyy-MM-dd")}&to={input.To.ToString("yyyy-MM-dd")}&apikey={_settings.ApiToken}";
            return result;
        }

        private string GetEarningsCalendarUrl(CalendarRequest input)
        {
            var result = $"https://financialmodelingprep.com/api/v3/earning_calendar?from={input.From.ToString("yyyy-MM-dd")}&to={input.To.ToString("yyyy-MM-dd")}&limit=100&apikey={_settings.ApiToken}";
            return result;
        }
    }
}

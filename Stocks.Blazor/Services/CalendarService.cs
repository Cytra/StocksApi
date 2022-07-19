using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Stocks.Model.FMP.Calendar;
using Stocks.Model.Shared;

namespace Stocks.Blazor.Services
{
    public class CalendarService : ICalendarService
    {
        private readonly HttpClient _httpClient;

        public CalendarService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<EarningCalendarResponseItem>> GetEarningsCalendar(CalendarRequest payload)
        {
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, "/api/Calendar/GetEarningCalendar");
            request.Content = new StringContent(JsonConvert.SerializeObject(payload), Encoding.UTF8, "application/json");
            using var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead);
            var result = await response.Content.ReadAsAsync<List<EarningCalendarResponseItem>>();
            return result;
        }

        public async Task<List<IpoCalendarResponse>> GetIpoCalendar(CalendarRequest payload)
        {
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, "/api/Calendar/GetIpoCalendar");
            request.Content = new StringContent(JsonConvert.SerializeObject(payload), Encoding.UTF8, "application/json");
            using var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead);
            var result = await response.Content.ReadAsAsync<List<IpoCalendarResponse>>();
            return result;
        }

        public async Task<List<EconomicCalendarResponse>> GetEconomicCalendar(CalendarRequest payload)
        {
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, "/api/Calendar/GetEconomicCalendar");
            request.Content = new StringContent(JsonConvert.SerializeObject(payload), Encoding.UTF8, "application/json");
            using var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead);
            var result = await response.Content.ReadAsAsync<List<EconomicCalendarResponse>>();
            return result;
        }
    }
}

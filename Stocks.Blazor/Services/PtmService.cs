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
    public class PtmService : IPtmProvider
    {
        private readonly HttpClient _httpClient;

        public PtmService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<EconomicCalendarResponse>> GetIsmPmisManufacturing(CalendarRequest payload)
        {
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, "/api/Ptm/IsmPmisManufacturing");
            request.Content = new StringContent(JsonConvert.SerializeObject(payload), Encoding.UTF8, "application/json");
            using var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead);
            var result = await response.Content.ReadAsAsync<List<EconomicCalendarResponse>>();
            return result;
        }

        public async Task<List<EconomicCalendarResponse>> GetIsmPmisServices(CalendarRequest payload)
        {
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, "/api/Ptm/IsmPmisServices");
            request.Content = new StringContent(JsonConvert.SerializeObject(payload), Encoding.UTF8, "application/json");
            using var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead);
            var result = await response.Content.ReadAsAsync<List<EconomicCalendarResponse>>();
            return result;
        }

        public async Task<List<EconomicCalendarResponse>> ConsumerSentimentMichigan(CalendarRequest payload)
        {
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, "/api/Ptm/ConsumerSentimentMichigan");
            request.Content = new StringContent(JsonConvert.SerializeObject(payload), Encoding.UTF8, "application/json");
            using var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead);
            var result = await response.Content.ReadAsAsync<List<EconomicCalendarResponse>>();
            return result;
        }

        public async Task<List<EconomicCalendarResponse>> BuildingPermits(CalendarRequest payload)
        {
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, "/api/Ptm/BuildingPermits");
            request.Content = new StringContent(JsonConvert.SerializeObject(payload), Encoding.UTF8, "application/json");
            using var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead);
            var result = await response.Content.ReadAsAsync<List<EconomicCalendarResponse>>();
            return result;
        }
        public async Task<List<EconomicCalendarResponse>> NonfarmPayrolls(CalendarRequest payload)
        {
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, "/api/Ptm/NonfarmPayrolls");
            request.Content = new StringContent(JsonConvert.SerializeObject(payload), Encoding.UTF8, "application/json");
            using var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead);
            var result = await response.Content.ReadAsAsync<List<EconomicCalendarResponse>>();
            return result;
        }

        public async Task<List<EconomicCalendarResponse>> UnemploymentRate(CalendarRequest payload)
        {
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, "/api/Ptm/UnemploymentRate");
            request.Content = new StringContent(JsonConvert.SerializeObject(payload), Encoding.UTF8, "application/json");
            using var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead);
            var result = await response.Content.ReadAsAsync<List<EconomicCalendarResponse>>();
            return result;
        }

        public async Task<List<EconomicCalendarResponse>> DurableGoods(CalendarRequest payload)
        {
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, "/api/Ptm/DurableGoods");
            request.Content = new StringContent(JsonConvert.SerializeObject(payload), Encoding.UTF8, "application/json");
            using var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead);
            var result = await response.Content.ReadAsAsync<List<EconomicCalendarResponse>>();
            return result;
        }

        public async Task<List<EconomicCalendarResponse>> Gdp(CalendarRequest payload)
        {
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, "/api/Ptm/Gdp");
            request.Content = new StringContent(JsonConvert.SerializeObject(payload), Encoding.UTF8, "application/json");
            using var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead);
            var result = await response.Content.ReadAsAsync<List<EconomicCalendarResponse>>();
            return result;
        }

        public async Task<List<EconomicCalendarResponse>> UnemploymentRateCH(CalendarRequest payload)
        {
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, "/api/Ptm/UnemploymentRateCH");
            request.Content = new StringContent(JsonConvert.SerializeObject(payload), Encoding.UTF8, "application/json");
            using var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead);
            var result = await response.Content.ReadAsAsync<List<EconomicCalendarResponse>>();
            return result;
        }

        public async Task<List<EconomicCalendarResponse>> PmiCH(CalendarRequest payload)
        {
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, "/api/Ptm/PmiCH");
            request.Content = new StringContent(JsonConvert.SerializeObject(payload), Encoding.UTF8, "application/json");
            using var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead);
            var result = await response.Content.ReadAsAsync<List<EconomicCalendarResponse>>();
            return result;
        }

        public async Task<List<EconomicCalendarResponse>> GdpCH(CalendarRequest payload)
        {
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, "/api/Ptm/GdpCH");
            request.Content = new StringContent(JsonConvert.SerializeObject(payload), Encoding.UTF8, "application/json");
            using var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead);
            var result = await response.Content.ReadAsAsync<List<EconomicCalendarResponse>>();
            return result;
        }

        public async Task<List<EconomicCalendarResponse>> LeadingIndicatorsCh(CalendarRequest payload)
        {
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, "/api/Ptm/LeadingIndicatorsCh");
            request.Content = new StringContent(JsonConvert.SerializeObject(payload), Encoding.UTF8, "application/json");
            using var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead);
            var result = await response.Content.ReadAsAsync<List<EconomicCalendarResponse>>();
            return result;
        }

        public async Task<List<EconomicCalendarResponse>> MarkitServicesPmiEU(CalendarRequest payload)
        {
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, "/api/Ptm/MarkitServicesPmiEU");
            request.Content = new StringContent(JsonConvert.SerializeObject(payload), Encoding.UTF8, "application/json");
            using var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead);
            var result = await response.Content.ReadAsAsync<List<EconomicCalendarResponse>>();
            return result;
        }

        public async Task<List<EconomicCalendarResponse>> UnemploymentRateEU(CalendarRequest payload)
        {
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, "/api/Ptm/UnemploymentRateEU");
            request.Content = new StringContent(JsonConvert.SerializeObject(payload), Encoding.UTF8, "application/json");
            using var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead);
            var result = await response.Content.ReadAsAsync<List<EconomicCalendarResponse>>();
            return result;
        }

        public async Task<List<EconomicCalendarResponse>> MarkitManufacturingPmiEU(CalendarRequest payload)
        {
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, "/api/Ptm/MarkitManufacturingPmiEU");
            request.Content = new StringContent(JsonConvert.SerializeObject(payload), Encoding.UTF8, "application/json");
            using var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead);
            var result = await response.Content.ReadAsAsync<List<EconomicCalendarResponse>>();
            return result;
        }

        public async Task<List<EconomicCalendarResponse>> M3MoneySupplyEU(CalendarRequest payload)
        {
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, "/api/Ptm/M3MoneySupplyEU");
            request.Content = new StringContent(JsonConvert.SerializeObject(payload), Encoding.UTF8, "application/json");
            using var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead);
            var result = await response.Content.ReadAsAsync<List<EconomicCalendarResponse>>();
            return result;
        }

        public async Task<List<EconomicCalendarResponse>> ConsumerConfidenceEU(CalendarRequest payload)
        {
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, "/api/Ptm/ConsumerConfidenceEU");
            request.Content = new StringContent(JsonConvert.SerializeObject(payload), Encoding.UTF8, "application/json");
            using var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead);
            var result = await response.Content.ReadAsAsync<List<EconomicCalendarResponse>>();
            return result;
        }
    }
}

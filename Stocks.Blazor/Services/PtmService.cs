using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Stocks.Model.Fmp.Calendar;
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
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, "/api/ProfessionalTradingMasterclass/IsmPmisManufacturing");
            request.Content = new StringContent(JsonConvert.SerializeObject(payload), Encoding.UTF8, "application/json");
            using var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead);
            var result = await response.Content.ReadAsAsync<List<EconomicCalendarResponse>>();
            return result;
        }

        public async Task<List<EconomicCalendarResponse>> GetIsmPmisServices(CalendarRequest payload)
        {
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, "/api/ProfessionalTradingMasterclass/IsmPmisServices");
            request.Content = new StringContent(JsonConvert.SerializeObject(payload), Encoding.UTF8, "application/json");
            using var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead);
            var result = await response.Content.ReadAsAsync<List<EconomicCalendarResponse>>();
            return result;
        }

        public async Task<List<EconomicCalendarResponse>> ConsumerSentimentMichigan(CalendarRequest payload)
        {
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, "/api/ProfessionalTradingMasterclass/ConsumerSentimentMichigan");
            request.Content = new StringContent(JsonConvert.SerializeObject(payload), Encoding.UTF8, "application/json");
            using var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead);
            var result = await response.Content.ReadAsAsync<List<EconomicCalendarResponse>>();
            return result;
        }

        public async Task<List<EconomicCalendarResponse>> BuildingPermits(CalendarRequest payload)
        {
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, "/api/ProfessionalTradingMasterclass/BuildingPermits");
            request.Content = new StringContent(JsonConvert.SerializeObject(payload), Encoding.UTF8, "application/json");
            using var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead);
            var result = await response.Content.ReadAsAsync<List<EconomicCalendarResponse>>();
            return result;
        }
        public async Task<List<EconomicCalendarResponse>> NonfarmPayrolls(CalendarRequest payload)
        {
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, "/api/ProfessionalTradingMasterclass/NonfarmPayrolls");
            request.Content = new StringContent(JsonConvert.SerializeObject(payload), Encoding.UTF8, "application/json");
            using var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead);
            var result = await response.Content.ReadAsAsync<List<EconomicCalendarResponse>>();
            return result;
        }

        public async Task<List<EconomicCalendarResponse>> UnemploymentRate(CalendarRequest payload)
        {
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, "/api/ProfessionalTradingMasterclass/UnemploymentRate");
            request.Content = new StringContent(JsonConvert.SerializeObject(payload), Encoding.UTF8, "application/json");
            using var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead);
            var result = await response.Content.ReadAsAsync<List<EconomicCalendarResponse>>();
            return result;
        }

        public async Task<List<EconomicCalendarResponse>> DurableGoods(CalendarRequest payload)
        {
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, "/api/ProfessionalTradingMasterclass/DurableGoods");
            request.Content = new StringContent(JsonConvert.SerializeObject(payload), Encoding.UTF8, "application/json");
            using var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead);
            var result = await response.Content.ReadAsAsync<List<EconomicCalendarResponse>>();
            return result;
        }

        public async Task<List<EconomicCalendarResponse>> Gdp(CalendarRequest payload)
        {
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, "/api/ProfessionalTradingMasterclass/Gdp");
            request.Content = new StringContent(JsonConvert.SerializeObject(payload), Encoding.UTF8, "application/json");
            using var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead);
            var result = await response.Content.ReadAsAsync<List<EconomicCalendarResponse>>();
            return result;
        }

        public async Task<List<EconomicCalendarResponse>> UnemploymentRateCH(CalendarRequest payload)
        {
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, "/api/ProfessionalTradingMasterclass/UnemploymentRateCH");
            request.Content = new StringContent(JsonConvert.SerializeObject(payload), Encoding.UTF8, "application/json");
            using var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead);
            var result = await response.Content.ReadAsAsync<List<EconomicCalendarResponse>>();
            return result;
        }

        public async Task<List<EconomicCalendarResponse>> PmiCH(CalendarRequest payload)
        {
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, "/api/ProfessionalTradingMasterclass/PmiCH");
            request.Content = new StringContent(JsonConvert.SerializeObject(payload), Encoding.UTF8, "application/json");
            using var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead);
            var result = await response.Content.ReadAsAsync<List<EconomicCalendarResponse>>();
            return result;
        }

        public async Task<List<EconomicCalendarResponse>> GdpCH(CalendarRequest payload)
        {
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, "/api/ProfessionalTradingMasterclass/GdpCH");
            request.Content = new StringContent(JsonConvert.SerializeObject(payload), Encoding.UTF8, "application/json");
            using var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead);
            var result = await response.Content.ReadAsAsync<List<EconomicCalendarResponse>>();
            return result;
        }

        public async Task<List<EconomicCalendarResponse>> LeadingIndicatorsCh(CalendarRequest payload)
        {
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, "/api/ProfessionalTradingMasterclass/LeadingIndicatorsCh");
            request.Content = new StringContent(JsonConvert.SerializeObject(payload), Encoding.UTF8, "application/json");
            using var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead);
            var result = await response.Content.ReadAsAsync<List<EconomicCalendarResponse>>();
            return result;
        }

        public async Task<List<EconomicCalendarResponse>> MarkitServicesPmiEU(CalendarRequest payload)
        {
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, "/api/ProfessionalTradingMasterclass/MarkitServicesPmiEU");
            request.Content = new StringContent(JsonConvert.SerializeObject(payload), Encoding.UTF8, "application/json");
            using var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead);
            var result = await response.Content.ReadAsAsync<List<EconomicCalendarResponse>>();
            return result;
        }

        public async Task<List<EconomicCalendarResponse>> UnemploymentRateEU(CalendarRequest payload)
        {
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, "/api/ProfessionalTradingMasterclass/UnemploymentRateEU");
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
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, "/api/ProfessionalTradingMasterclass/M3MoneySupplyEU");
            request.Content = new StringContent(JsonConvert.SerializeObject(payload), Encoding.UTF8, "application/json");
            using var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead);
            var result = await response.Content.ReadAsAsync<List<EconomicCalendarResponse>>();
            return result;
        }

        public async Task<List<EconomicCalendarResponse>> ConsumerConfidenceEU(CalendarRequest payload)
        {
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, "/api/ProfessionalTradingMasterclass/ConsumerConfidenceEU");
            request.Content = new StringContent(JsonConvert.SerializeObject(payload), Encoding.UTF8, "application/json");
            using var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead);
            var result = await response.Content.ReadAsAsync<List<EconomicCalendarResponse>>();
            return result;
        }
    }
}

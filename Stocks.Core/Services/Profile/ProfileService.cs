using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using Stocks.Model;
using Stocks.Model.Profile;

namespace Stocks.Core.Services.Profile
{
    public class ProfileService : IProfileService
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly AppSettings _settings;
        public ProfileService(IHttpClientFactory httpClientFactory, IOptions<AppSettings> settings)
        {
            _httpClientFactory = httpClientFactory;
            _settings = settings.Value;
        }
        public async Task<List<StockProfile>> GetStockProfile(string symbol)
        {
            var httpClient = _httpClientFactory.CreateClient();
            var request = new HttpRequestMessage(HttpMethod.Get, GetUrl(symbol));
            request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            using var response = await httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead);
            var stream = await response.Content.ReadAsStreamAsync();
            using StreamReader reader = new StreamReader(stream);
            using JsonTextReader jsonReader = new JsonTextReader(reader);
            JsonSerializer ser = new JsonSerializer();
            var result = ser.Deserialize<List<StockProfile>>(jsonReader);
            return result;
        }

        private string GetUrl(string symbol)
        {
            var result = $"https://financialmodelingprep.com/api/v3/profile/{symbol}?apikey={_settings.ApiToken}";
            return result;
        }
    }
}

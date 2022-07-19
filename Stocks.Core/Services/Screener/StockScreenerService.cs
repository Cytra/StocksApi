using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Options;
using Stocks.Core.Extensions;
using Stocks.Model;
using Stocks.Model.FMP.Screener;
using Stocks.Model.Shared;

namespace Stocks.Core.Services.Screener
{
    public class StockScreenerService : IStockScreenerService
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly AppSettings _settings;
        public StockScreenerService(IHttpClientFactory httpClientFactory, IOptions<AppSettings> settings)
        {
            _httpClientFactory = httpClientFactory;
            _settings = settings.Value;
        }
        public async Task<List<StockScreenerResponse>> GetStocks(StockScreenerRequest request)
        {
            var client = _httpClientFactory.CreateClient();
            var httpRequest = new HttpRequestMessage(HttpMethod.Get, GetUrl(request));
            using var response = await client.SendAsync(httpRequest, HttpCompletionOption.ResponseHeadersRead);
            var result = await response.Content.ReadAsAsync<List<StockScreenerResponse>>();
            return result;
        }

        private string GetUrl(StockScreenerRequest request)
        {
            const string url = "https://financialmodelingprep.com/api/v3/stock-screener";
            var param = new Dictionary<string, string>();

            if (request.MarketCapMoreThan != null)
            {
                param.Add("marketCapMoreThan",request.MarketCapMoreThan.ToString());
            }
            if (request.MarketCapLowerThan != null)
            {
                param.Add("marketCapLowerThan", request.MarketCapLowerThan.ToString());
            }
            if (request.PriceMoreThan != null)
            {
                param.Add("priceMoreThan", request.PriceMoreThan.ToString());
            }
            if (request.PriceLowerThan != null)
            {
                param.Add("priceLowerThan", request.PriceLowerThan.ToString());
            }
            if (request.BetaMoreThan != null)
            {
                param.Add("betaMoreThan", request.BetaMoreThan.ToString());
            }
            if (request.BetaLowerThan != null)
            {
                param.Add("betaLowerThan", request.BetaLowerThan.ToString());
            }
            if (request.VolumeMoreThan != null)
            {
                param.Add("volumeMoreThan", request.VolumeMoreThan.ToString());
            }
            if (request.VolumeLowerThan != null)
            {
                param.Add("volumeLowerThan", request.VolumeLowerThan.ToString());
            }
            if (request.DividendMoreThan != null)
            {
                param.Add("dividendMoreThan", request.DividendMoreThan.ToString());
            }
            if (request.DividendLowerThan != null)
            {
                param.Add("dividendLowerThan", request.DividendLowerThan.ToString());
            }
            if (request.IsActivelyTrading != null)
            {
                param.Add("isActivelyTrading", request.IsActivelyTrading.ToString());
            }
            if (request.IsEtf != null)
            {
                param.Add("isEtf", request.IsEtf.ToString());
            }
            if (request.Limit != null)
            {
                param.Add("limit", request.Limit.ToString());
            }
            if (request.Exchange != null)
            {
                param.Add("exchange", request.Exchange.ToDescription());
            }
            if (request.Country != null)
            {
                param.Add("country", request.Country.ToString());
            }
            if (request.Industry != null)
            {
                param.Add("industry", request.Industry.ToDescription());
            }
            if (request.Sector != null)
            {
                param.Add("sector", request.Sector.ToDescription());
            }
            param.Add("apikey", _settings.ApiToken);
            var newUrl = new Uri(QueryHelpers.AddQueryString(url, param));
            return newUrl.ToString();
        }
    }
}

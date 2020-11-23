using System.Collections.Generic;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using System.IO;
using Stocks.Data.Repositories;
using Stocks.Data.Entities.DCF;
using AutoMapper;
using Stocks.Core.Services.StockList;
using Stocks.Model.DCF;

namespace Stocks.Core.Providers
{
    public class DcfProvider : IDcfProvider
    {
        private const string Token = "3102ef91f3e039d1d49f03cb0537acab";

        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IStocksRepository _stocksRepository;
        private readonly IMapper _mapper;
        private readonly IStockListService _stockListService;
        public DcfProvider(
            IMapper mapper, 
            IHttpClientFactory httpClientFactory, 
            IStocksRepository stocksRepository, 
            IStockListService stockListService)
        {
            _mapper = mapper;
            _httpClientFactory = httpClientFactory; 
            _stocksRepository = stocksRepository;
            _stockListService = stockListService;
        }

        public async Task<List<Historical_discounted_cash_flows_Model>> GetDCF(string stock)
        {
            var httpClient = _httpClientFactory.CreateClient();
            var request = new HttpRequestMessage(HttpMethod.Get, GetDCFListUrl(stock));
            request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            using var response = await httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead);
            var stream = await response.Content.ReadAsStreamAsync();
            using StreamReader reader = new StreamReader(stream);
            using JsonTextReader jsonReader = new JsonTextReader(reader);
            JsonSerializer ser = new JsonSerializer();
            var result = ser.Deserialize<List<Historical_discounted_cash_flows_Model>>(jsonReader);
            return result;
        }

        public async Task UpdateDCFs(DCFRequest request)
        {
            var stocks = await _stockListService.GetSortedStocks(request);
            foreach (var stock in stocks)
            {
                await _stocksRepository.DeleteDCF(stock.Symbol);
                var stockDcfs = await GetDCF(stock.Symbol);
                foreach (var dcf in stockDcfs)
                {
                    var dbStockDcfs = _mapper.Map<List<Historical_discounted_cash_flow_Entity>>(dcf.historicalDCF);
                    foreach (var dbDcf in dbStockDcfs)
                    {
                        dbDcf.Symbol = stock.Symbol;
                    }
                    await _stocksRepository.SaveDCFs(dbStockDcfs);
                }
            }
        }

        private string GetDCFListUrl(string stock)
        {
            var result = $"https://financialmodelingprep.com/api/v3/" + $"historical-discounted-cash-flow/{stock}?apikey=" + Token;
            return result;
        }
    }
}

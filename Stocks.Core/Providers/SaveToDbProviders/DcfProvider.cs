using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Stocks.Core.Services.DCF;
using Stocks.Core.Services.StockList;
using Stocks.Data.Entities.DCF;
using Stocks.Data.Repositories;
using Stocks.Model.DCF;

namespace Stocks.Core.Providers.SaveToDbProviders
{
    public interface IDcfProvider
    {
        Task UpdateDCFs(DCFRequest request);
    }
    public class DcfProvider : IDcfProvider
    {
        private const string Token = "3102ef91f3e039d1d49f03cb0537acab";

        private readonly IStocksRepository _stocksRepository;
        private readonly IMapper _mapper;
        private readonly IStockListService _stockListService;
        private readonly IDCFService _dcfService;
        public DcfProvider(
            IMapper mapper,
            IStocksRepository stocksRepository, 
            IStockListService stockListService, 
            IDCFService dcfService)
        {
            _mapper = mapper;
            _stocksRepository = stocksRepository;
            _stockListService = stockListService;
            _dcfService = dcfService;
        }

        public async Task UpdateDCFs(DCFRequest request)
        {
            var stocks = await _stockListService.GetSortedStocks(request);
            foreach (var stock in stocks)
            {
                await _stocksRepository.DeleteDCF(stock.Symbol);
                var stockDcfs = await _dcfService.GetDividendCalendar2(stock.Symbol);
                foreach (var dcf in stockDcfs)
                {
                    var dbStockDcfs = _mapper.Map<List<Historical_discounted_cash_flow_Entity>>(dcf);
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
            var result = $"https://financialmodelingprep.com/api/v3/historical-discounted-cash-flow/{stock}?apikey=" + Token;
            return result;
        }
    }
}

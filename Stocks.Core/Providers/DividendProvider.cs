using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Stocks.Core.Extensions;
using Stocks.Core.Services.Dividend;
using Stocks.Core.Services.StockPrice;
using Stocks.Data.Entities.Dividend;
using Stocks.Data.Repositories;
using Stocks.Model.Dividend;
using Stocks.Model.StockPrice;

namespace Stocks.Core.Providers
{
    public class DividendProvider : IDividendProvider
    {
        private readonly IMapper _mapper;
        private readonly IStocksRepository _stocksRepository;
        private readonly IDividendCalendarService _dividendCalendarService;
        private readonly IStockPriceService _stockPriceService;
        public DividendProvider(
            IMapper mapper, 
            IStocksRepository stocksRepository, 
            IDividendCalendarService dividendCalendarService, 
            IStockPriceService stockPriceService)
        {
            _mapper = mapper;
            _stocksRepository = stocksRepository;
            _dividendCalendarService = dividendCalendarService;
            _stockPriceService = stockPriceService;
        }
        public async Task<List<DividendCalendarItem>> GetDividendCalendar(DividendCalendarRequest request)
        {
            var result = await _dividendCalendarService.GetDividendCalendar(request);
            return result;
        }

        public async Task<List<DividendCalendarItem>> GetDividendCalendarWithPrices(DividendCalendarRequest request)
        {
            var result = await _dividendCalendarService.GetDividendCalendar(request);

            await UpdateStockPrices(result);

            await _stocksRepository.DeleteAllDividendCalendarEntities();

            var stocksToInsert = _mapper.Map<List<DividendCalendarEntity>>(result);
            await _stocksRepository.SaveDividendCalendarEntities(stocksToInsert);
            return result;
        }

        private async Task UpdateStockPrices(List<DividendCalendarItem> stocks)
        {
            var stockSplits = ListExtensions.Split(stocks, 10);
            var allPrices = new ConcurrentBag<StockPriceItem>();
            foreach (var stockSplit in stockSplits)
            {
                var stockSymbols = StringExtensions.GetSymbolsString(stockSplit.Select(x => x.Symbol).ToArray());
                var prices = await _stockPriceService.GetStockPrices(stockSymbols);
                foreach (var price in prices)
                {
                    allPrices.Add(price);
                }
            }

            foreach (var stockPrice in allPrices)
            {
                var stockToUpdate = stocks.FirstOrDefault(x => x.Symbol == stockPrice.Symbol);
                if (stockToUpdate != null)
                {
                    stockToUpdate.Price = stockPrice.Price;
                }
            }
        }
    }
}

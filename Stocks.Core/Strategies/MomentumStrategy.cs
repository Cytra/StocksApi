using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Stocks.Core.Extensions;
using Stocks.Core.Services.StockList;
using Stocks.Core.Services.StockPrice;
using Stocks.Data.Entities.StockPrice;
using Stocks.Data.Repositories;
using Stocks.Model.DCF;

namespace Stocks.Core.Strategies
{
    public class MomentumStrategy : IMomentumStrategy
    {
        private readonly IStockListService _stockListService;
        private readonly IStockPriceService _stockPriceService;
        private readonly IStocksRepository _stocksRepository;
        private readonly IMapper _mapper;
        public MomentumStrategy(IStockListService stockListService, IStockPriceService stockPriceService, IStocksRepository stocksRepository, IMapper mapper)
        {
            _stockListService = stockListService;
            _stockPriceService = stockPriceService;
            _stocksRepository = stocksRepository;
            _mapper = mapper;
        }

        public async Task GetStockPrices(int dividend, long marketCapMoreThan, DateTime from, DateTime to, string sector, long volumeMoreThan)
        {
            await _stocksRepository.DeleteAllStockPriceHistoricEntities();

            var sortedStocks = await _stockListService.GetSortedStocks(new DCFRequest()
            {
                DividendMoreThan = dividend,
                MarketCapMoreThan = marketCapMoreThan,
                Sector = sector,
                VolumeMoreThan = volumeMoreThan
            });

            var splitList = ListExtensions.Split(sortedStocks, 5);
            foreach (var stockItem in splitList)
            {
                var dbEntities = new List<StockPriceHistoricEntity>();
                var stockSymbols = StringExtensions.GetSymbolsString(stockItem.Select(x => x.Symbol).ToArray());
                var historicPrices = await _stockPriceService.GetHistoricPrices(stockSymbols, from, to);
                if (historicPrices.HistoricalStockList != null)
                {
                    foreach (var historicPrice in historicPrices.HistoricalStockList)
                    {
                        var stockEntities = _mapper.Map<List<StockPriceHistoricEntity>>(historicPrice.Historical);
                        foreach (var stockEntity in stockEntities)
                        {
                            stockEntity.Symbol = historicPrice.Symbol;
                        }
                        dbEntities.AddRange(stockEntities);
                    }
                }
                await _stocksRepository.SaveStockPriceHistoricEntities(dbEntities);
            }

            var spyPrice = await _stockPriceService.GetHistoricPrices($"SPY?from={from.ToString("yyyy-MM-dd")}&to={to.ToString("yyyy-MM-dd")}");

            var spyEntities = _mapper.Map<List<StockPriceHistoricEntity>>(spyPrice.Historical);
            foreach (var stockEntity in spyEntities)
            {
                stockEntity.Symbol = spyPrice.Symbol;
            }
            spyEntities.AddRange(spyEntities);

            await _stocksRepository.SaveStockPriceHistoricEntities(spyEntities);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Stocks.Core.Providers;
using Stocks.Core.Services.StockList;
using Stocks.Data.Repositories;
using Stocks.Model.DCF;
using Stocks.Model.Strategy;

namespace Stocks.Core.Strategies
{
    public class DcfStrategy : IDcfStrategy
    {
        private readonly IIncomeStatementProvider _incomeStatementProvider;
        private readonly IStocksRepository _stocksRepository;
        private readonly IStockListService _stockListService;
        public DcfStrategy(IIncomeStatementProvider incomeStatementProvider, IStocksRepository stocksRepository, IStockListService stockListService)
        {
            _incomeStatementProvider = incomeStatementProvider;
            _stocksRepository = stocksRepository;
            _stockListService = stockListService;
        }

        public async Task Get(StrategyRequest request)
        {
            await _stocksRepository.DeleteIncomeStatementEntities();

            var sortedStocks = await _stockListService.GetSortedStocks(new DCFRequest()
            {
                DividendMoreThan = request.Dividend,
                MarketCapMoreThan = request.MarketCapMoreThan,
                Sector = request.Sector,
                VolumeMoreThan = request.VolumeMoreThan
            });

            foreach (var stock in sortedStocks)
            {
                await _incomeStatementProvider.GetIncomeStatements(stock.Symbol);
            }
        }
    }
}

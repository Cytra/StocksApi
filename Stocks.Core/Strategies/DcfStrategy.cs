using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stocks.Core.Extensions;
using Stocks.Core.Providers;
using Stocks.Core.Services.FinancialStatements;
using Stocks.Core.Services.Profile;
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
        private readonly IProfileProvider _profileProvider;

        public DcfStrategy(IIncomeStatementProvider incomeStatementProvider, IStocksRepository stocksRepository, IStockListService stockListService, IProfileProvider profileProvider)
        {
            _incomeStatementProvider = incomeStatementProvider;
            _stocksRepository = stocksRepository;
            _stockListService = stockListService;
            _profileProvider = profileProvider;
        }

        public async Task Get(StrategyRequest request)
        {
            await _stocksRepository.DeleteIncomeStatementEntities();
            await _stocksRepository.DeleteStockProfileEntities();

            var sortedStocks = await _stockListService.GetSortedStocks(new DCFRequest()
            {
                DividendMoreThan = request.Dividend,
                MarketCapMoreThan = request.MarketCapMoreThan,
                Sector = request.Sector,
                VolumeMoreThan = request.VolumeMoreThan
            });

            var stockSplits = ListExtensions.Split(sortedStocks, 5);
            foreach (var stockSplit in stockSplits)
            {
                var stockSymbols = StringExtensions.GetSymbolsString(stockSplit.Select(x => x.Symbol).ToArray());
                var stockProfiles = await _profileProvider.GetStockProfile(stockSymbols);
            }

            foreach (var stock in sortedStocks)
            {
                await _incomeStatementProvider.GetIncomeStatements(stock.Symbol);
            }
        }
    }
}

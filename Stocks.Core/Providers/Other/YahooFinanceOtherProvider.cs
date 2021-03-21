using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stocks.Core.Helpers;
using Stocks.Data.Entities.YahooFinance;
using Stocks.Data.Repositories;
using Stocks.Model.Shared;
using Stocks.Model.YahooFinance;

namespace Stocks.Core.Providers.Other
{

    public class YahooFinanceOtherProvider : IYahooFinanceOtherProvider
    {
        private readonly IStocksRepository _stocksRepository;
        public YahooFinanceOtherProvider(IStocksRepository stocksRepository)
        {
            _stocksRepository = stocksRepository;
        }

        public async Task<List<YahooFinanceOptionEntityGroupBy>> GetOpenInterest(string ticker)
        {
            var result = new List<YahooFinanceOptionEntityGroupBy>();
            var groupedEntities = await _stocksRepository.GetYahooFinanceOptionEntities(ticker);
            foreach (var date in groupedEntities.Select(x=> x.Created).Distinct())
            {
                var items = groupedEntities.Where(x => x.Created == date).ToList();
                var callOpenInterest = items.SingleOrDefault(x => x.Type == OptionType.Call);
                var putOpenInterest = items.SingleOrDefault(x => x.Type == OptionType.Put);
                var itemToAdd = new YahooFinanceOptionEntityGroupBy()
                {
                    Ticker = ticker,
                    Created = date,
                    OpenInterestCall = callOpenInterest?.OpenInterest ?? 0,
                    OpenInterestPut = putOpenInterest?.OpenInterest ?? 0,
                    CallPutRatio = putOpenInterest?.OpenInterest != null ? decimal.Round((decimal)callOpenInterest.OpenInterest/putOpenInterest.OpenInterest, 2) : 0
                };
                result.Add(itemToAdd);
            }
            return result;
        }

        public async Task<List<string>> GetOpenInterestStockList()
        {
            return StockLists.OptionOpenInterestStockList;
        }
    }
}

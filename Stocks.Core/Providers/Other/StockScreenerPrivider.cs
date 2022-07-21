using System.Collections.Generic;
using System.Threading.Tasks;
using Stocks.Model;
using Stocks.Model.Fmp.Screener;
using Stocks.Model.Shared;

namespace Stocks.Core.Providers.Other
{
    public class StockScreenerPrivider : IStockScreenerPrivider
    {
        private readonly IStockScreenerService _stockScreenerService;
        public StockScreenerPrivider(IStockScreenerService stockScreenerService)
        {
            _stockScreenerService = stockScreenerService;
        }
        public async Task<StockScreenerResponseList> GetStocks(StockScreenerRequest request)
        {
            var stocks = await _stockScreenerService.GetStocks(request);
            foreach (var stock in stocks)
            {
                if (stock.price > 1)
                {
                    stock.DividendYield = (decimal)(stock.lastAnnualDividend / stock.price);
                }
                else
                {
                    stock.DividendYield = 0;
                }
                
            }

            var filteredStocks = new List<StockScreenerResponse>();
            foreach (var stock in stocks)
            {
                if (request.DividendYieldLowerThan != null  && request.DividendYieldMoreThan != null)
                {
                    if (stock.DividendYield >= request.DividendYieldMoreThan &&
                        stock.DividendYield <= request.DividendYieldLowerThan)
                    {
                        filteredStocks.Add(stock);
                    }
                }

                if (request.DividendYieldLowerThan == null && request.DividendYieldMoreThan != null)
                {
                    if (stock.DividendYield >= request.DividendYieldMoreThan)
                    {
                        filteredStocks.Add(stock);
                    }
                }

                if (request.DividendYieldLowerThan != null && request.DividendYieldMoreThan == null)
                {
                    if (stock.DividendYield <= request.DividendYieldLowerThan)
                    {
                        filteredStocks.Add(stock);
                    }
                }

                if (request.DividendYieldLowerThan == null && request.DividendYieldMoreThan == null)
                {
                    filteredStocks.Add(stock);
                }
            }
            return new StockScreenerResponseList()
            {
                Items = filteredStocks,
                Paging = new PagingModel()
                {
                    Page = 1,
                    PageSize = request.RowsPerPage,
                    TotalItems = stocks.Count
                }
            };
        }
    }
}

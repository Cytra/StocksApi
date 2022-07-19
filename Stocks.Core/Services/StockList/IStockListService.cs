using System.Collections.Generic;
using System.Threading.Tasks;
using Stocks.Model.FMP.DCF;
using Stocks.Model.FMP.StockList;

namespace Stocks.Core.Services.StockList
{
    public interface IStockListService
    {
        Task<List<StockScreenListItem>> GetSortedStocks(DCFRequest input);
        Task<List<StockListItem>> GetStockList();
    }
}

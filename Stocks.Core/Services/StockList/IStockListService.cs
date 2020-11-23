using System.Collections.Generic;
using System.Threading.Tasks;
using Stocks.Model.DCF;
using Stocks.Model.StockList;

namespace Stocks.Core.Services.StockList
{
    public interface IStockListService
    {
        Task<List<StockScreenListItem>> GetSortedStocks(DCFRequest input);
        Task<List<StockListItem>> GetStockList();
    }
}

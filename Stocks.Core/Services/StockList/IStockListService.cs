using System.Collections.Generic;
using System.Threading.Tasks;
using Stocks.Model.Fmp.DCF;
using Stocks.Model.Fmp.StockList;

namespace Stocks.Core.Services.StockList
{
    public interface IStockListService
    {
        Task<List<StockScreenListItem>> GetSortedStocks(DCFRequest input);
        Task<List<StockListItem>> GetStockList();
    }
}

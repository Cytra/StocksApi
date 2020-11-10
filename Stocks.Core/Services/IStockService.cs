using Stocks.Model.FMP.Requests.StockList;
using Stocks.Model.Requests;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Stocks.Core.Services
{
    public interface IStockService
    {
        Task<List<StockListItem>> GetStockList();
        Task<List<StockScreenListItem>> GetSortedStocks(DCFRequest input);
    }
}

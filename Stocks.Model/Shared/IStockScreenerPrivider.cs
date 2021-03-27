using System.Threading.Tasks;
using Stocks.Model.Screener;

namespace Stocks.Model.Shared
{
    public interface IStockScreenerPrivider
    {
        Task<StockScreenerResponseList> GetStocks(StockScreenerRequest request);
    }
}

using System.Threading.Tasks;
using Stocks.Model.FMP.Screener;

namespace Stocks.Model.Shared
{
    public interface IStockScreenerPrivider
    {
        Task<StockScreenerResponseList> GetStocks(StockScreenerRequest request);
    }
}

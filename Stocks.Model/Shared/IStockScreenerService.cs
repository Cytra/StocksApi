using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Stocks.Model.Screener;

namespace Stocks.Model.Shared
{
    public interface IStockScreenerService
    {
        Task<List<StockScreenerResponse>> GetStocks(StockScreenerRequest request);
    }
}

using System.Collections.Generic;
using System.Threading.Tasks;
using Stocks.Model.StockPrice;

namespace Stocks.Core.Services.StockPrice
{
    public interface IStockPriceService
    {
        Task<List<StockPriceItem>> GetStockPrices(string symbol);
    }
}

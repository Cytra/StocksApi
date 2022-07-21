using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Stocks.Model.Fmp.StockPrice;

namespace Stocks.Model.Shared
{
    public interface IStockPriceProvider
    {
        Task<List<StockPriceItem>> GetStockPrices(List<string> symbols);
        Task<List<StockPricesForUi>> GetPricesForUi(StockPricesForUiRequest request);

    }
}

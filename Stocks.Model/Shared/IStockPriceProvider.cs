using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Stocks.Model.Reddit;
using Stocks.Model.StockPrice;

namespace Stocks.Model.Shared
{
    public interface IStockPriceProvider
    {
        Task<List<StockPriceItem>> GetStockPrices(List<string> symbols);
        Task<RedditDdDtoList> GetStockPricesForUi(List<RedditDdDto> dto, RedditOtherRequest request);
        Task<List<StockPricesForUi>> GetPricesForUi(StockPricesForUiRequest request);

    }
}

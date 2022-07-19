using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Stocks.Model.FMP.StockPrice;

namespace Stocks.Model.Shared
{
    public interface IStockPriceService
    {
        Task<List<StockPriceItem>> GetStockPrices(string symbol);
        Task<StockPriceHistoricSimple> GetHistoricSimplePrices(string symbol);
        Task<StockPriceHistoricList> GetHistoricPrices(string symbol, DateTime from, DateTime to);
        Task<StockPriceHistoric> GetHistoricPrices(string symbol);
    }
}

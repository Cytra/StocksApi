using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Stocks.Model.StockPrice;

namespace Stocks.Core.Services.StockPrice
{
    public interface IStockPriceService
    {
        Task<List<StockPriceItem>> GetStockPrices(string symbol);
        Task<StockPriceHistoricSimple> GetHistoricSimplePrices(string symbol);
        Task<StockPriceHistoricList> GetHistoricPrices(string symbol, DateTime from, DateTime to);
        Task<StockPriceHistoric> GetHistoricPrices(string symbol);
    }
}

using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Stocks.Core.Extensions;
using Stocks.Core.Services.StockPrice;
using Stocks.Model.StockPrice;

namespace Stocks.Core.Providers.Other
{
    public interface IStockPriceProvider
    {
        Task<List<StockPriceItem>> GetStockPrices(List<string> symbols);
    }
    public class StockPriceProvider : IStockPriceProvider
    {
        private readonly IStockPriceService _stockPriceService;
        public StockPriceProvider(IStockPriceService stockPriceService)
        {
            _stockPriceService = stockPriceService;
        }

        public async Task<List<StockPriceItem>> GetStockPrices(List<string> symbols)
        {
            var result = new List<StockPriceItem>();
            var stockSplits = ListExtensions.Split(symbols, 10);
            foreach (var stockSplit in stockSplits)
            {
                var stockSymbols = StringExtensions.GetSymbolsString(symbols);
                var prices = await _stockPriceService.GetStockPrices(stockSymbols);
                foreach (var price in prices)
                {
                    result.Add(price);
                }
            }
            return result;
        }
    }
}

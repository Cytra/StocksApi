using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Stocks.Model.StockPrice;

namespace Stocks.Core.Strategies
{
    public interface IMomentumStrategy
    {
        Task GetStockPrices(int dividend, long marketCapMoreThan, DateTime from, DateTime to, string sector, long volumeMoreThan);
    }
}

using Stocks.Model.Profile;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Stocks.UI.Services
{
    public interface IStockService
    {
        Task<List<StockProfile>> GetStockProfile(string symbol);
    }
}

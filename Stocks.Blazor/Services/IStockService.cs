using System.Collections.Generic;
using System.Threading.Tasks;
using Stocks.Model.Profile;

namespace Stocks.Blazor.Services
{
    public interface IStockService
    {
        Task<List<StockProfile>> GetStockProfile(string symbol);
    }
}

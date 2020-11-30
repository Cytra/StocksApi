using System.Collections.Generic;
using System.Threading.Tasks;
using Stocks.Model.Profile;

namespace Stocks.Core.Providers
{
    public interface IProfileProvider
    {
        Task<List<StockProfile>> GetStockProfile(string symbol);
    }
}

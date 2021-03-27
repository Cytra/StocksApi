using System.Collections.Generic;
using System.Threading.Tasks;
using Stocks.Model.CompanyOutlook;
using Stocks.Model.Profile;

namespace Stocks.Model.Shared
{
    public interface IStockService
    {
        Task<List<StockProfile>> GetStockProfile(string symbol);
        Task<CompanyOutlookModel> GetCompanyOutlook(string symbol);
    }
}

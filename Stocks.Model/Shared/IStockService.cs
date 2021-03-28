using System.Collections.Generic;
using System.Threading.Tasks;
using Stocks.Model.CompanyOutlook;
using Stocks.Model.DCF;
using Stocks.Model.Profile;
using Stocks.Model.Rating;

namespace Stocks.Model.Shared
{
    public interface IStockService
    {
        Task<List<StockProfile>> GetStockProfile(string symbol);
        Task<CompanyOutlookModel> GetCompanyOutlook(string symbol);
        Task<List<KeyMetrics.KeyMetrics>> GetKeyMetrics(string symbol);
        Task<List<PressReleases.PressReleases>> GetPressReleases(string symbol);
        Task<List<SecFillings.SecFillings>> GetSecFillings(string symbol);
        Task<List<Historical_discounted_cash_flows_Model>> GetDCF(string symbol);
        Task<List<RatingHistoric>> Rating(string symbol);
    }
}

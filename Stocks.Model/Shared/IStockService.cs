using System.Collections.Generic;
using System.Threading.Tasks;
using Stocks.Model.FMP.CompanyOutlook;
using Stocks.Model.FMP.DCF;
using Stocks.Model.FMP.EarningSurprice;
using Stocks.Model.FMP.GainersLosers;
using Stocks.Model.FMP.KeyMetrics;
using Stocks.Model.FMP.PressReleases;
using Stocks.Model.FMP.Profile;
using Stocks.Model.FMP.Rating;
using Stocks.Model.FMP.SecFillings;

namespace Stocks.Model.Shared
{
    public interface IStockService
    {
        Task<List<StockProfile>> GetStockProfile(string symbol);
        Task<CompanyOutlookModel> GetCompanyOutlook(string symbol);
        Task<List<KeyMetrics>> GetKeyMetrics(string symbol);
        Task<List<PressReleases>> GetPressReleases(string symbol);
        Task<List<SecFillings>> GetSecFillings(string symbol);
        Task<List<Historical_discounted_cash_flows_Model>> GetDCF(string symbol);
        Task<List<RatingHistoric>> Rating(string symbol);
        Task<List<EarningSurprice>> EarningsSurprises(string symbol);
        Task<List<Stocknew>> StockNews(string symbol);
        Task<List<GainersLosers>> Gainers();
        Task<List<GainersLosers>> Losers();
    }
}

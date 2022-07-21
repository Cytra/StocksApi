using System.Collections.Generic;
using System.Threading.Tasks;
using Stocks.Model.Fmp.CompanyOutlook;
using Stocks.Model.Fmp.DCF;
using Stocks.Model.Fmp.EarningSurprice;
using Stocks.Model.Fmp.GainersLosers;
using Stocks.Model.Fmp.KeyMetrics;
using Stocks.Model.Fmp.PressReleases;
using Stocks.Model.Fmp.Profile;
using Stocks.Model.Fmp.Rating;
using Stocks.Model.Fmp.SecFillings;

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
